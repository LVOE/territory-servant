using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using PdfSharp.Pdf.AcroForms;
using PdfSharp.Pdf.IO;

namespace Territory_Servant {
  class Template {
    public string template_file = "";

    public Template(string template_file) {
      this.template_file = template_file;
    }

    private XGraphics gfx;
    private XTextFormatter tf;
    public bool export_pdf(string filepath) {
      try {
        if (!File.Exists(this.template_file))
          return false;

        PdfDocument document = new PdfDocument();
        document.Info.Title = Form1.map.name;
        document.Info.Author = "Territory Servant";
        document.Info.Subject = "";
        document.Info.Keywords = "";

        Bitmap map1 = Form1.map.bmp;
        Bitmap map2 = generate_distance_map();

        // add map borders
        Graphics g = Graphics.FromImage((Image)map1);
        g.DrawRectangle(Pens.Black, 0, 0, map1.Width - 2, map1.Height - 2);
        g = Graphics.FromImage((Image)map2);
        g.DrawRectangle(Pens.Black, 0, 0, map1.Width - 2, map1.Height - 2);

        // Read template file
        XmlDocument xml = new XmlDocument();
        xml.Load(this.template_file);

        // page /////////////////////////////////////////////////////////////////////////////////
        XmlNodeList nodes = xml.SelectNodes("/template/page");
        if (nodes.Count > 0) {
          foreach (XmlNode node in nodes) {
            PdfPage page = document.AddPage();
            page.Size = PdfSharp.PageSize.Letter;
            page.Orientation = PdfSharp.PageOrientation.Landscape;
            this.gfx = XGraphics.FromPdfPage(page);
            this.tf = new XTextFormatter(this.gfx);
            this.gfx.Clear(Color.White);
            XGraphicsState state = gfx.Save();

            // map //////////////////////////////////////////////////////////////////////////////////
            nodes = node.SelectNodes("map");
            if (nodes.Count > 0) {
              double x, y, width, height;
              int type;
              foreach (XmlNode e_node in nodes) {
                if (e_node.Attributes.Count > 0) {

                  if (e_node.Attributes["type"] != null)
                    type = Convert.ToInt16(e_node.Attributes["type"].Value);
                  else
                    type = 1;
                  if (e_node.Attributes["x"] != null)
                    x = Convert.ToDouble(e_node.Attributes["x"].Value);
                  else
                    x = 0;
                  if (e_node.Attributes["y"] != null)
                    y = Convert.ToDouble(e_node.Attributes["y"].Value);
                  else
                    y = 0;
                  if (e_node.Attributes["width"] != null)
                    width = Convert.ToDouble(e_node.Attributes["width"].Value) * 72 / map1.HorizontalResolution;
                  else
                    width = 0;
                  if (e_node.Attributes["height"] != null)
                    height = Convert.ToDouble(e_node.Attributes["height"].Value) * 72 / map1.VerticalResolution;
                  else
                    height = 0;

                  XImage img_map;
                  switch (type) {
                    case 2:
                      img_map = XImage.FromGdiPlusImage((Image)map2);
                      break;
                    default:
                      img_map = XImage.FromGdiPlusImage((Image)map1);
                      break;
                  }
                  img_map.Interpolate = false;

                  if (width == 0 || height == 0)
                    this.gfx.DrawImage(img_map, x, y);
                  else
                    this.gfx.DrawImage(img_map, x, y, width, height);
                }
              }
            }
            /////////////////////////////////////////////////////////////////////////////////////////
            // text /////////////////////////////////////////////////////////////////////////////////
            nodes = node.SelectNodes("text");
            if (nodes.Count > 0)
              parse_text(nodes);

            nodes = node.SelectNodes("cong_name");
            if (nodes.Count > 0)
              parse_text(nodes);

            nodes = node.SelectNodes("map_name");
            if (nodes.Count > 0)
              parse_text(nodes);

            nodes = node.SelectNodes("dnc_list");
            if (nodes.Count > 0)
              parse_text(nodes);

            nodes = node.SelectNodes("directions");
            if (nodes.Count > 0)
              parse_text(nodes);
            /////////////////////////////////////////////////////////////////////////////////////////

            this.gfx.Restore(state);
          }
        }
        /////////////////////////////////////////////////////////////////////////////////////////
        document.Save(filepath);

        return true;
      } catch {
        return false;
      }
    }

    private void parse_text(XmlNodeList nodes) {
      double x, y, width, height, font_size;
      string align, font_family, font_style, prefix, suffix;
      Color color;

      foreach (XmlNode node in nodes) {
        if (node.Attributes.Count > 0) {

          if (node.Attributes["x"] != null)
            x = Convert.ToDouble(node.Attributes["x"].Value);
          else
            x = 0;
          if (node.Attributes["y"] != null)
            y = Convert.ToDouble(node.Attributes["y"].Value);
          else
            y = 0;
          if (node.Attributes["width"] != null)
            width = Convert.ToDouble(node.Attributes["width"].Value);
          else
            width = 0;
          if (node.Attributes["height"] != null)
            height = Convert.ToDouble(node.Attributes["height"].Value);
          else
            height = 0;
          if (node.Attributes["size"] != null)
            font_size = Convert.ToDouble(node.Attributes["size"].Value);
          else
            font_size = 14;
          if (node.Attributes["prefix"] != null)
            prefix = node.Attributes["prefix"].Value;
          else
            prefix = "";
          if (node.Attributes["suffix"] != null)
            suffix = node.Attributes["suffix"].Value;
          else
            suffix = "";
          if (node.Attributes["font"] != null)
            font_family = node.Attributes["font"].Value;
          else
            font_family = "Arial";
          if (node.Attributes["style"] != null)
            font_style = node.Attributes["style"].Value;
          else
            font_style = "regular";
          if (node.Attributes["align"] != null)
            align = node.Attributes["align"].Value;
          else
            align = "left";
          if (node.Attributes["color"] != null) {
            try {
              color = ColorTranslator.FromHtml(node.Attributes["color"].Value);
            } catch {
              color = Color.Black;
            }
          } else
            color = Color.Black;

          XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.WinAnsi, PdfFontEmbedding.Default);

          XFontStyle style = XFontStyle.Regular;
          switch (font_style.ToLower()) {
            case "bold":
              style = XFontStyle.Bold;
              break;
            case "bolditalic":
              style = XFontStyle.BoldItalic;
              break;
            case "italic":
              style = XFontStyle.Italic;
              break;
            case "strikeout":
              style = XFontStyle.Strikeout;
              break;
            case "underline":
              style = XFontStyle.Underline;
              break;
          }

          XFont font = new XFont(font_family, font_size, style, options);
          XStringFormat format = new XStringFormat();
          switch (align.ToLower()) {
            case "left":
              format.Alignment = XStringAlignment.Near;
              break;
            case "center":
              format.Alignment = XStringAlignment.Center;
              break;
            case "right":
              format.Alignment = XStringAlignment.Far;
              break;
          }

          switch (node.Name.ToLower()) {
            case "cong_name":
              this.gfx.DrawString(prefix + Form1.settings.cong_name + suffix, font, new XSolidBrush(XColor.FromArgb(color)), new XRect(x, y, width, height), format);
              break;
            case "map_name":
              this.gfx.DrawString(prefix + Form1.map.name + suffix, font, new XSolidBrush(XColor.FromArgb(color)), new XRect(x, y, width, height), format);
              break;
            case "dnc_list":
              this.tf.DrawString(prefix + generate_dnc_list(font, width) + suffix, font, new XSolidBrush(XColor.FromArgb(color)), new XRect(x, y, width, height), XStringFormats.TopLeft);
              break;
            case "directions":
              this.tf.DrawString(prefix + generate_directions(font, width) + suffix, font, new XSolidBrush(XColor.FromArgb(color)), new XRect(x, y, width, height), XStringFormats.TopLeft);              
              break;
            case "text":
              this.gfx.DrawString(node.InnerText, font, new XSolidBrush(XColor.FromArgb(color)), new XRect(x, y, width, height), format);
              break;
          }
        }
      }
    }

    private Bitmap generate_distance_map() {    
      double scale = 1;
      for (int i = 1; i <= (Form1.map.main_zoom - Form1.map.area_zoom); i++)
        scale = scale * .5;

      Bitmap map1_shrunk = ResizeBitmap(Form1.map.bmp, Convert.ToInt32(Math.Round(Form1.map.bmp.Width * scale)), Convert.ToInt32(Math.Round(Form1.map.bmp.Height * scale)));
      Bitmap map2_merged = Form1.map.bmp2;
      int start_x = (map2_merged.Width / 2) - (map1_shrunk.Width / 2);
      int start_y = (map2_merged.Height / 2) - (map1_shrunk.Height / 2);
      for (int x = 0; x < map1_shrunk.Width; x++) {
        for (int y = 0; y < map1_shrunk.Height; y++) {
          //  if (Form1.get_property_type(map1_shrunk.GetPixel(start_x, start_y)) == Form1.property_type.Property) {
            switch (Form1.get_property_type(map1_shrunk.GetPixel(x, y))) {
              case Form1.property_type.Home:
                map2_merged.SetPixel(start_x + x, start_y + y, Form1.get_color_by_property_type(Form1.property_type.Home));
                break;
              case Form1.property_type.DNC:
                map2_merged.SetPixel(start_x + x, start_y + y, Form1.get_color_by_property_type(Form1.property_type.DNC));
                break;
              case Form1.property_type.SO:
                map2_merged.SetPixel(start_x + x, start_y + y, Form1.get_color_by_property_type(Form1.property_type.SO));
                break;
            }
          }
      //  }
      }

      return map2_merged;
    }

    private string generate_directions(XFont font, double width) {
      string directions = "";

      if (Form1.map.directions.Length > 0) {
        string[] lines = Form1.map.directions.Split(Environment.NewLine.ToCharArray());

        foreach (string line in lines) {
          directions += word_wrap(line, font, width);   
          if(line == "")
            directions += Environment.NewLine;
        }
      }

      return directions;
    }

    private string word_wrap(string line, XFont font, double width) {
      if (line.Length < 1)
        return "";

      string n_line = line;

      try {
        XSize size = this.gfx.MeasureString(line, font, XStringFormats.TopLeft);
        int c = 0;
        while (size.Width > width) {
          c++;
          n_line = line.Substring(0, line.Length - c) + "-";
          size = this.gfx.MeasureString(n_line, font, XStringFormats.TopLeft);
        }
        if (c > 0)
          n_line += Environment.NewLine + word_wrap(line.Substring(line.Length - (c + 1)), font, width);
      } catch { }

      return n_line;
    }

    private string generate_dnc_list(XFont font, double width) {
      string list = "";

      if (Form1.map.dncs.Count > 0) {
        int c = 0;
        foreach (DNC dnc in Form1.map.dncs) {
          list += "Date: " + dnc.date_recorded.ToShortDateString() + Environment.NewLine;
          list += "Address: " + dnc.house_number + " " + dnc.street_address.Replace(Environment.NewLine, Environment.NewLine) + Environment.NewLine;
          list += "Notes: " + dnc.notes.Replace(Environment.NewLine, Environment.NewLine);
          c++;
          if (c < Form1.map.dncs.Count)
            list += Environment.NewLine + " " + Environment.NewLine;
        }
        list = word_wrap(list, font, width);
      }

      return list;
    }

    public static Bitmap ResizeBitmap(Bitmap b, int nWidth, int nHeight) {
      Bitmap result = new Bitmap(nWidth, nHeight);
      using (Graphics g = Graphics.FromImage((Image)result))
        g.DrawImage(b, 0, 0, nWidth, nHeight);
      return result;
    }
  }
}
