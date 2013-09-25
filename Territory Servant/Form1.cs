using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.IO;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.MapProviders;

namespace Territory_Servant {
  public partial class Form1 : Form {
    public Form1(string[] args) {
      if(args.Length > 0 && File.Exists(args[0]))
        current_file = args[0];

      InitializeComponent();
    }

    public const double Version = 1.2;

    public static Map map;
    public static Settings settings;

    string current_file = "";
    bool map_locked = false;
    bool map_unsaved = false;
    Point[] map_points;
    GMapOverlay polygons;
    FloodFiller flood_filler = new FloodFiller();
    GMapPolygon poly;
    Template template;

    frmDNC dnc_form = new frmDNC();
    frmSettings settings_form = new frmSettings();

    public enum property_type {
      Property = 1,
      Home = 2,
      DNC = 3,
      SO = 4,
    }   

    private void Form1_Load(object sender, EventArgs e) {
      FileAssociation.Associate(".map", "LVOE.TerritoryServant", "map File", Path.GetDirectoryName(Application.ExecutablePath) + @"\icon.ico", Application.ExecutablePath);

      gmMain.MapProvider = GMapProviders.GoogleMap;
      gmMain.Scale(new SizeF(2, 2));
      gmMain.Scale(new SizeF(0.5F, 0.5F));
        GMapOverlay objects = new GMapOverlay(gmMain, "objects");
      gmMain.Overlays.Add(objects);
      polygons = new GMapOverlay(gmMain, "polygons");
      gmMain.Overlays.Add(polygons);
      flood_filler.FillStyle = FloodFillStyle.Queue;

      map = new Map();
      settings = new Settings();
      load_settings();

      map.house_color = settings.house_color;
      map.dnc_color = settings.dnc_color;
      map.so_color = settings.so_color;

      if (settings.cong_name.Length < 1 || settings.hall_address.Length < 1) {
        settings_form.txtCongName.Text = settings.cong_name;
        settings_form.txtHallAddress.Text = settings.hall_address;
        settings_form.pbxHouseColor.BackColor = settings.house_color;
        settings_form.pbxDNCColor.BackColor = settings.dnc_color;
        settings_form.pbxSOColor.BackColor = settings.so_color;
        settings_form.tbrMainZoom.Value = settings.main_zoom;
        settings_form.tbrAreaZoom.Value = settings.area_zoom;

        settings_form.btnClose.Enabled = false;
        settings_form.btnSave.Enabled = false;

        if (settings_form.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
          save_settings();
          txtTemplate.Text = Path.GetDirectoryName(Application.ExecutablePath) + @"\Templates\default.xml";
          txtFrom.Text = settings.hall_address;
        }
      }

      GMaps.Instance.UseMemoryCache = false;

      map.main_zoom = settings.main_zoom;
      map.area_zoom = settings.area_zoom;

      if (current_file.Length > 0) {
        load_map(current_file);
      } else {
        gmMain.Zoom = settings.main_zoom;
        gmMain.MinZoom = settings.main_zoom;
        gmMain.MaxZoom = settings.main_zoom;

        GDirections tmpDirections;

        GoogleMapProvider.Instance.GetDirections(out tmpDirections, settings.hall_address, settings.hall_address, false, false, false, false, false);
        PointLatLng pnt = tmpDirections.StartLocation;

        gmMain.Position = new PointLatLng(pnt.Lat, pnt.Lng);
      }

      xppNavigate.Expand = true;
      xppMark.Expand = false;
      xppDirections.Expand = false;
      xppExport.Expand = false;
      btnLock.Visible = true;
      lstDNC.Visible = false;
      txtDirections.Visible = false;
      txtExportLog.Visible = false;
      lblDirectionsInstructions.Visible = false;
      lblExportInstructions.Visible = false;

      this.Text = "Territory Servant - Untitled Map";

      Form1_Resize(null, null);

      try {
        Updater updater = new Updater();
        updater.check_for_updates();
      } catch { }
    }

    private void Form1_Resize(object sender, EventArgs e) {
      txtExportLog.Height = xPanderPanelList1.Height - 268;
      txtDirections.Height = xPanderPanelList1.Height - 387;

      txtNotes.Height = xPanderPanelList1.Height - 437;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
      if (map_unsaved) {
        switch (MessageBox.Show("Do you want to save changes you made to this map?", "Unsaved Changes", MessageBoxButtons.YesNoCancel)) {
          case System.Windows.Forms.DialogResult.Yes:
            mnuMapSave_Click(null, null);
            if (txtMapName.Text.Length < 1)
                e.Cancel = true;
            break;
          case System.Windows.Forms.DialogResult.Cancel:
            e.Cancel = true;
            break;
        }
      }
    }

    private void load_settings() {
      string filename = Path.GetDirectoryName(Application.ExecutablePath) + @"\settings.dat";

      if (!File.Exists(filename))
        return;

      Settings default_settings = new Settings();

      settings = (Settings)StringToObject(File.ReadAllText(filename));
      settings_form.txtCongName.Text = settings.cong_name;
      settings_form.txtHallAddress.Text = settings.hall_address;

      if (settings.house_color != Color.Empty)
        settings_form.pbxHouseColor.BackColor = settings.house_color;
      else
        settings_form.pbxHouseColor.BackColor = default_settings.house_color;

      if (settings.dnc_color != Color.Empty)
        settings_form.pbxDNCColor.BackColor = settings.dnc_color;
      else
        settings_form.pbxDNCColor.BackColor = default_settings.dnc_color;

      if (settings.so_color != Color.Empty)
        settings_form.pbxSOColor.BackColor = settings.so_color;
      else
        settings_form.pbxSOColor.BackColor = default_settings.so_color;

      if (settings.main_zoom < settings_form.tbrMainZoom.Minimum)
        settings_form.tbrMainZoom.Value = default_settings.main_zoom;
      else
        settings_form.tbrMainZoom.Value = settings.main_zoom;
      if (settings.area_zoom < settings_form.tbrAreaZoom.Minimum)
        settings_form.tbrAreaZoom.Value = default_settings.main_zoom;
      else
        settings_form.tbrAreaZoom.Value = settings.area_zoom;

      if (settings.last_template == "")
        settings.last_template = Path.GetDirectoryName(Application.ExecutablePath) + @"\Templates\default.xml";

      if (settings.last_template.Length > 0 && File.Exists(settings.last_template)) {
        txtTemplate.Text = settings.last_template;
        txtTemplate.Select(txtTemplate.TextLength, 0);
        txtTemplate.ScrollToCaret();
        label1.Focus();
      }

      if (txtFrom.Text.Length <= 0)
        txtFrom.Text = settings.hall_address;

      save_settings();
    }

    private void save_settings() {
      string filename = Path.GetDirectoryName(Application.ExecutablePath) + @"\settings.dat";
      settings.cong_name = settings_form.txtCongName.Text;
      settings.hall_address = settings_form.txtHallAddress.Text;
      settings.last_template = txtTemplate.Text;
      settings.house_color = settings_form.pbxHouseColor.BackColor;
      settings.dnc_color = settings_form.pbxDNCColor.BackColor;
      settings.so_color = settings_form.pbxSOColor.BackColor;
      settings.main_zoom = settings_form.tbrMainZoom.Value;
      settings.area_zoom = settings_form.tbrAreaZoom.Value;

      if (!map.locked) {
        map.main_zoom = settings.main_zoom;
        map.area_zoom = settings.area_zoom;
      }

      if (!map.locked && gmMain.Zoom != settings_form.tbrMainZoom.Value) {
        gmMain.MinZoom = settings_form.tbrMainZoom.Value;
        gmMain.MaxZoom = settings_form.tbrMainZoom.Value;
        gmMain.Zoom = settings_form.tbrMainZoom.Value;
        gmMain.Update();
      }

      File.WriteAllText(filename, ObjectToString(settings));
    }

    private void txtMapName_KeyUp(object sender, KeyEventArgs e) {
      map_changed();
    }

    // Lock & Unlock /////////////////////////////////////////////////////////////
    private void btnLock_Click(object sender, MouseEventArgs e) {
      if (e.Button == System.Windows.Forms.MouseButtons.Left) {
        if (!map_locked) {
          map_changed();
          lock_map();
        } else {
          if (MessageBox.Show("Are you sure you would like to unlock this map? You will lose all house markings, directions and DNCs", "Unlock Map", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
            map_changed();
            unlock_map();
          }
        }

        pbMain.Focus();
      }
    }

    private void lock_map() {
      settings_form.color_change_enabled = false;
      Cursor.Hide();
      this.Enabled = false;

      // store bound points
      try {
        if (poly.Points.Count >= 3) {
          map_points = new Point[poly.Points.Count];
          var i = 0;
          foreach (PointLatLng point in poly.Points) {
            GPoint tmp = gmMain.FromLatLngToLocal(point);
            map_points[i] = new Point(unchecked((int)tmp.X), unchecked((int)tmp.Y));
            i++;
          }
        }
      } catch (Exception) { }

      try {
        polygons.Polygons.Clear();
        poly.Points.Clear();
        poly = null;
        gmMain.Update();
      } catch (Exception) { }

      map_locked = true;
      btnLock.Text = "LOCKING...";
      btnSearch.Enabled = false;
      txtSearch.Enabled = false;

      tmrLock.Enabled = true;
    }

    private void unlock_map() {
      settings_form.color_change_enabled = true;
      map_locked = false;
      btnLock.Text = "LOCK";
      btnSearch.Enabled = true;
      txtSearch.Enabled = true;

      pbMain.Visible = false;
      gmMain.Visible = true;
      gmMain.CanDragMap = true;

      map.locked = false;

      xppExport.Expand = false;
      xppMark.Expand = false;
      xppDirections.Expand = false;
      xppNavigate.Expand = true;
      btnLock.Visible = true;
      lstDNC.Visible = false;
      txtDirections.Visible = false;
      txtExportLog.Visible = false;
      lblDirectionsInstructions.Visible = false;
      lblExportInstructions.Visible = false;

      lstDNC.Items.Clear();
      map.dncs.Clear();
      txtDirections.Text = "";
      txtTo.Text = "";

      map.house_color = settings.house_color;
      map.dnc_color = settings.dnc_color;
      map.so_color = settings.so_color;
      map.main_zoom = settings.main_zoom;
      map.area_zoom = settings.area_zoom;
    }

    private void tmrLock_Tick(object sender = null, EventArgs e = null) {
      tmrLock.Enabled = false;
      
      if (!map.locked) { // Map not loaded
        if (tmrLock.Interval != 700) {
          pbMain.Image = gmMain.ToImage();

          gmMain.MinZoom = settings.area_zoom;
          gmMain.MaxZoom = settings.area_zoom;
          gmMain.Zoom = settings.area_zoom;
          gmMain.Update();
          tmrLock.Interval = 700;
          return;
        }

        pbDistance.Image = gmMain.ToImage();
        gmMain.MinZoom = settings.main_zoom;
        gmMain.MaxZoom = settings.main_zoom;
        gmMain.Zoom = settings.main_zoom;
        tmrLock.Interval = 500;
      }

      gmMain.CanDragMap = false;
      gmMain.Visible = false;

      btnLock.Text = "LOCKED";

      xppNavigate.Expand = false;
      xppExport.Expand = false;
      xppDirections.Expand = false;
      xppMark.Expand = true;
      btnLock.Visible = false;
      lstDNC.Visible = true;
      txtDirections.Visible = false;
      txtExportLog.Visible = false;
      lblDirectionsInstructions.Visible = false;
      lblExportInstructions.Visible = false;

      pbMain.Visible = true;
      map.bmp = new Bitmap(pbMain.Image);
      map.bmp2 = new Bitmap(pbDistance.Image);
      map.locked = true;

      // fill bounds
      try {
        if (map_points.Length >= 3) {
          fill_pixels_between_points(map_points);
          pbMain.Image = map.bmp;
        }
      } catch (Exception) { }

      Cursor.Show();
      this.Enabled = true;
    }
    //////////////////////////////////////////////////////////////////////////////    
    
    // Map Object ////////////////////////////////////////////////////////////////
    private void map_changed() { 
      if(current_file.Length > 0)
        this.Text = "Territory Servant - " + Path.GetFileName(current_file) + "*";
      else
        this.Text = "Territory Servant - Untitled Map*";

      map_unsaved = true;
    }

    private void save_map(string filename, bool update_only = false) {
      map.name = txtMapName.Text;
      map.position = gmMain.Position;
      map.directions_from = txtFrom.Text;
      map.directions_to = txtTo.Text;
      map.directions = txtDirections.Text;
      map.notes = txtNotes.Text;

      if (!update_only) {
        File.WriteAllText(filename, ObjectToString(map));

        current_file = filename;
        this.Text = "Territory Servant - " + Path.GetFileName(filename);
        map_unsaved = false;
      }
    }

    private void load_map(string filename) {
      map = (Map)StringToObject(File.ReadAllText(filename));
      txtMapName.Text = map.name;
      pbMain.Image = map.bmp;
      pbDistance.Image = map.bmp2;
      txtFrom.Text = map.directions_from;
      txtTo.Text = map.directions_to;
      txtDirections.Text = map.directions;
      txtNotes.Text = map.notes;

      if (map.house_color == Color.Empty)
        map.house_color = settings.house_color;
      if (map.dnc_color == Color.Empty)
        map.dnc_color = settings.dnc_color;
      if (map.so_color == Color.Empty)
        map.so_color = settings.so_color;
      if (map.main_zoom < settings_form.tbrMainZoom.Minimum)
        map.main_zoom = 17;
      if (map.area_zoom < settings_form.tbrAreaZoom.Minimum)
        map.area_zoom = 16;

      gmMain.MinZoom = map.main_zoom;
      gmMain.MaxZoom = map.main_zoom;
      gmMain.Zoom = map.main_zoom;
      gmMain.Position = map.position;

      refresh_dnc_list();

      current_file = filename;

      if (map.locked)
        lock_map();
      else
        unlock_map();

      if (txtFrom.Text.Length <= 0)
        txtFrom.Text = settings.hall_address;

      map_unsaved = false;
      this.Text = "Territory Servant - " + Path.GetFileName(filename);
    }
    //////////////////////////////////////////////////////////////////////////////

    // Navigate Screen /////////////////////////////////////////////////////////
    private void gmMain_MouseUp(object sender, MouseEventArgs e) {
      if (!map_locked) {
        if (e.Button == System.Windows.Forms.MouseButtons.Left) {
          if (poly == null) {
            poly = new GMapPolygon(new List<PointLatLng>(), "bounds");
            polygons.Polygons.Add(poly);
          }

          poly.Points.Add(gmMain.FromLocalToLatLng(e.X, e.Y));
          gmMain.UpdatePolygonLocalPosition(poly);
        }
      }
    }

    private void gmMain_KeyUp(object sender, KeyEventArgs e) {
      if (!map_locked) {
        if (e.KeyCode == Keys.Delete) {
          try {
            polygons.Polygons.Clear();
            poly = null;
          } catch (Exception) { }
        }
      }
    }

    private void txtSearch_Enter(object sender, EventArgs e) {
      txtSearch.Text = "";
    }

    private void xppNavigate_ExpandClick(object sender, EventArgs e) {
      gmMain.CanDragMap = true;
      btnLock.Visible = true;
      lstDNC.Visible = false;
      txtDirections.Visible = false;
      txtExportLog.Visible = false;
      lblDirectionsInstructions.Visible = false;
      lblExportInstructions.Visible = false;
    }

    private void txtSearch_Leave(object sender, EventArgs e) {
      if (txtSearch.Text == "")
        txtSearch.Text = "Enter an address and hit search";
    }

    private void btnSearch_Click(object sender, EventArgs e) {
      if (txtSearch.Text != "Enter an address and hit search" && txtSearch.Text != "" && !map.locked) {
        map_changed();
        GDirections tmpDirections;
        GoogleMapProvider.Instance.GetDirections(out tmpDirections, txtSearch.Text, txtSearch.Text, false, false, false, false, false);
        PointLatLng pnt = tmpDirections.StartLocation;

        gmMain.Position = new PointLatLng(pnt.Lat, pnt.Lng);
      }
    }
    //////////////////////////////////////////////////////////////////////////////

    // Mark Screen ///////////////////////////////////////////////////////////////
    private void pbMain_MouseClick(object sender, MouseEventArgs e) {
      if (!xppMark.Expand)
        return;

      Point point = new Point(e.X, e.Y);

      if (e.Button == System.Windows.Forms.MouseButtons.Left) {
        switch (get_property_type(map.bmp.GetPixel(point.X, point.Y))) {
          case property_type.Property:
            fill(get_color_by_property_type(property_type.Home), point);
            map_changed();
            break;
          case property_type.Home:
            fill(get_color_by_property_type(property_type.Property), point);
            map_changed();
            break;
          default:
            return;
        }
      } else if (e.Button == System.Windows.Forms.MouseButtons.Right) {
        switch (get_property_type(map.bmp.GetPixel(point.X, point.Y))) {
          case property_type.Home:
            property_type prop = add_dnc(point);
            if (prop == property_type.DNC) {
              fill(get_color_by_property_type(property_type.DNC), point);
              map_changed();
            } else if (prop == property_type.SO) {
              fill(get_color_by_property_type(property_type.SO), point);
              map_changed();
            }
            break;
          default:
            return;
        }
      }
    }

    public property_type add_dnc(Point point) {
      dnc_form.txtHouseNumber.Text = "";
      dnc_form.txtStreetName.Text = "";
      dnc_form.txtNotes.Text = "";
      dnc_form.chksexual_offender.Checked = false;
      dnc_form.dtpDateRecorded.Value = DateTime.Now;
      dnc_form.btnSave.Enabled = false;

      if (dnc_form.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

        // check if duplicate house number
        foreach (DNC dnc in map.dncs) {
          if (dnc_form.txtHouseNumber.Text == dnc.house_number) {
            if (MessageBox.Show("There is already a DNC with this house number on the map. Would you like to overwrite it?", "Duplicate DNC", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
              fill(get_color_by_property_type(property_type.Home), dnc.point);
              map.dncs.Remove(dnc);
              break;
            } else {
              return 0;
            }
          }
        }

        DNC tmp = new DNC();
        tmp.house_number = dnc_form.txtHouseNumber.Text;
        tmp.street_address = dnc_form.txtStreetName.Text;
        tmp.notes = dnc_form.txtNotes.Text;
        tmp.sexual_offender = dnc_form.chksexual_offender.Checked;
        tmp.date_recorded = dnc_form.dtpDateRecorded.Value;
        tmp.point = point;

        map.dncs.Add(tmp);
        refresh_dnc_list();

        if(tmp.sexual_offender)
          return property_type.SO;

        return property_type.DNC;
      }

      return 0;
    }

    public void refresh_dnc_list() {
      lstDNC.Items.Clear();
      foreach (DNC dnc in map.dncs) {
        string dnc_text = dnc.house_number + " ";
        if (dnc.sexual_offender)
          dnc_text += dnc.street_address + " (SO)";
        else
          dnc_text += dnc.street_address;

        dnc_text += Environment.NewLine + "Date: " + dnc.date_recorded.ToShortDateString();
        dnc_text += Environment.NewLine + "Notes: " + dnc.notes;

        lstDNC.Items.Add(dnc_text);

        label1.Focus();
        map_changed();
      }
    }

    private void lstDNC_MouseDoubleClick(object sender, MouseEventArgs e) {
      if (lstDNC.SelectedIndex >= 0) {
        foreach (DNC dnc in map.dncs) {
          string[] dnc_string = lstDNC.SelectedItem.ToString().Split(Environment.NewLine.ToCharArray());
          if (dnc_string.Length < 1) return;

          if ((dnc.house_number + " " + dnc.street_address) == dnc_string[0].Replace(" (SO)", "")) {
            try {
              dnc_form.txtHouseNumber.Text = dnc.house_number;
              dnc_form.txtNotes.Text = dnc.notes;
              dnc_form.chksexual_offender.Checked = dnc.sexual_offender;
              dnc_form.dtpDateRecorded.Value = dnc.date_recorded;
              dnc_form.txtStreetName.Text = dnc.street_address;
            } catch { }
            dnc_form.btnSave.Enabled = true;

            if (dnc_form.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
              dnc.house_number = dnc_form.txtHouseNumber.Text;
              dnc.street_address = dnc_form.txtStreetName.Text;
              dnc.notes = dnc_form.txtNotes.Text;
              dnc.sexual_offender = dnc_form.chksexual_offender.Checked;
              dnc.date_recorded = dnc_form.dtpDateRecorded.Value;

              if (dnc.sexual_offender)
                fill(get_color_by_property_type(property_type.SO), dnc.point);
              else
                fill(get_color_by_property_type(property_type.DNC), dnc.point);

              refresh_dnc_list();
            }
            return;
          }
        }
      }
    }

    private void lstDNC_KeyUp(object sender, KeyEventArgs e) {
      if (lstDNC.SelectedIndex < 0)
        return;

      if (e.KeyCode == Keys.Delete) {
        foreach (DNC dnc in map.dncs) {
          string[] dnc_string = lstDNC.SelectedItem.ToString().Split(Environment.NewLine.ToCharArray());
          if (dnc_string.Length < 1) return;

          if ((dnc.house_number + " " + dnc.street_address) == dnc_string[0].Replace(" (SO)", "")) {
            fill(get_color_by_property_type(property_type.Home), dnc.point);
            map.dncs.Remove(dnc);
            refresh_dnc_list();
            return;
          }
        }
      }

      e.Handled = true;
    }

    private void xppMark_ExpandClick(object sender, EventArgs e) {
      gmMain.CanDragMap = false;
      btnLock.Visible = false;
      lstDNC.Visible = true;
      txtDirections.Visible = false;
      txtExportLog.Visible = false;
      lblDirectionsInstructions.Visible = false;
      lblExportInstructions.Visible = false;
    }
    //////////////////////////////////////////////////////////////////////////////

    // Directions Screen /////////////////////////////////////////////////////////////
    private void btnGetDirections_Click(object sender, EventArgs e) {
      if (txtFrom.Text.Length <= 0)
        return;
      if (txtTo.Text.Length <= 0)
        return;

      if (MessageBox.Show("This will clear any custom directions that you have entered. Continue?", "Direction Search", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
        return;

      GDirections directions;
      GoogleMapProvider.Instance.GetDirections(out directions, txtFrom.Text, txtTo.Text, false, false, false, false, false);

      txtDirections.Text = "";
      try {
        foreach (GDirectionStep step in directions.Steps) {
          if (step.HtmlInstructions.Contains("Destination will be")) continue;
          txtDirections.AppendText(StripHTML(step.HtmlInstructions) + Environment.NewLine + Environment.NewLine);
        }

        if (txtDirections.Text.Length > 3)
          txtDirections.Text = txtDirections.Text.Substring(0, txtDirections.Text.Length - 3);

        map.directions = txtDirections.Text;
      } catch (Exception ex) {
        txtDirections.Text = "Directions not found. Please ensure that your From and To addresses are correct.";
      }
      map_changed();
    }

    private void xppDirections_ExpandClick(object sender, EventArgs e) {
      btnLock.Visible = false;
      lstDNC.Visible = false;
      txtDirections.Visible = true;
      txtExportLog.Visible = false;
      lblDirectionsInstructions.Visible = true;
      lblExportInstructions.Visible = false;
    }

    private void txtDirections_KeyUp(object sender, KeyEventArgs e) {
      map_changed();
    }
    //////////////////////////////////////////////////////////////////////////////

    // Export Screen /////////////////////////////////////////////////////////////
    private void xppExport_ExpandClick(object sender, EventArgs e) {
      gmMain.CanDragMap = false;
    }

    private void txtTemplate_MouseClick(object sender, MouseEventArgs e) {
      if (openTemplateDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
        template = new Template(openTemplateDialog.FileName);
        txtTemplate.Text = openTemplateDialog.FileName;
        txtTemplate.Select(txtTemplate.TextLength, 0);
        txtTemplate.ScrollToCaret();
        label1.Focus();

        save_settings();
      }
    }

    private void btnExport_MouseClick(object sender, MouseEventArgs e) {
      if (!map.locked) {
        MessageBox.Show("Map must be locked before you can export.");
        return;
      }

      if (txtTemplate.Text.Length < 1) {
        MessageBox.Show("Please select a template file before exporting");
        return;
      }

      txtExportLog.Clear();

      template = new Template(txtTemplate.Text);

      if (savePdfDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
        save_map("", true);

        if (!template.export_pdf(savePdfDialog.FileName))
          txtExportLog.Text = "export failed. Please ensure that the pdf you are writing to and the template file you are using are closed before exporting.";
        else
          txtExportLog.Text = "export success";
      }
    }

    private void xppExport_ExpandClick_1(object sender, EventArgs e) {
      btnLock.Visible = false;
      lstDNC.Visible = false;
      txtDirections.Visible = false;
      txtExportLog.Visible = true;
      lblDirectionsInstructions.Visible = false;
      lblExportInstructions.Visible = true;
      txtExportLog.Clear();
    }
    //////////////////////////////////////////////////////////////////////////////        

    /// Main Menu /////////////////////////////////////////////////////////////////
    private void mnuMapSaveAs_Click(object sender, EventArgs e) {
        if (txtMapName.Text.Length < 1)
        {
            MessageBox.Show("Please enter a Map Name before saving");
            return;
        }
      if (txtMapName.Text.Length > 0)
        saveMapDialog.FileName = txtMapName.Text + ".map";
      if (saveMapDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
        save_map(saveMapDialog.FileName);
      }
    }

    private void mnuMapSave_Click(object sender, EventArgs e) {
        if (txtMapName.Text.Length < 1)
        {
            MessageBox.Show("Please enter a Map Name before saving");
            return;
        }
      if (current_file.Length > 0) {
        save_map(current_file);
      } else {
        mnuMapSaveAs_Click(null, null);
      }
    }

    private void mnuMapOpen_Click_1(object sender, EventArgs e) {
      if (openMapDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
        load_map(openMapDialog.FileName);
      }
    }

    private void txtSearch_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter)
        btnSearch_Click(null, null);
    }

    private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
      if (settings_form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        save_settings();
    }
    //////////////////////////////////////////////////////////////////////////////

    // Generic Functions /////////////////////////////////////////////////////////
    public void fill(Color color, Point point) {
      flood_filler.Bmp = map.bmp;

      flood_filler.Pt = point;

      flood_filler.Tolerance[0] = 1;
      flood_filler.Tolerance[1] = 1;
      flood_filler.Tolerance[2] = 1;

      flood_filler.FillColor = color;

      flood_filler.FloodFill();
      pbMain.Image = map.bmp;
    }

    private void fill_pixels_between_points(Point[] points) {
      // loop through all pixels and see which ones are within the polygon
      for (int x = 0; x < map.bmp.Width; x++) {
        for (int y = 0; y < map.bmp.Height; y++) {
          if (PointInPolygon(new Point(x, y), points)) {
            if (get_property_type(map.bmp.GetPixel(x, y)) == property_type.Property) // if gray
              map.bmp.SetPixel(x, y, get_color_by_property_type(property_type.Home)); // make green
          }
        }
      }
    }

    public static property_type get_property_type(Color color) {

      if (color.ToArgb() == get_color_by_property_type(property_type.Home).ToArgb()) {
        return property_type.Home;
      }

      if (color.ToArgb() == get_color_by_property_type(property_type.DNC).ToArgb()) {
        return property_type.DNC;
      }

      if (color.ToArgb() == get_color_by_property_type(property_type.SO).ToArgb()) {
        return property_type.SO;
      }

      if (color.R >= 230 && color.R <= 250
      && color.G >= 230 && color.G <= 250
      && color.B >= 220 && color.B <= 250) {
        Form1.map.property_color = color;
        return property_type.Property;
      }

      return 0;
    }

    public static Color get_color_by_property_type(property_type type) {
      switch (type) {
        case property_type.Property:
          return Form1.map.property_color;
        case property_type.Home:
          return Form1.map.house_color;
        case property_type.DNC:
          return Form1.map.dnc_color;
        case property_type.SO:
          return Form1.map.so_color;
      }

      return Color.Empty;
    }

    public string ObjectToString(object obj) {
      MemoryStream ms = new MemoryStream();
      new BinaryFormatter().Serialize(ms, obj);
      return Convert.ToBase64String(ms.ToArray());
    }

    public object StringToObject(string base64String) {
      byte[] bytes = Convert.FromBase64String(base64String);
      MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
      ms.Write(bytes, 0, bytes.Length);
      ms.Position = 0;
      return new BinaryFormatter().Deserialize(ms);
    }

    private int Distance2D(GPoint p1, GPoint p2) {
      int result = 0;

      double part1 = Math.Pow((p2.X - p1.X), 2);
      double part2 = Math.Pow((p2.Y - p1.Y), 2);
      double underRadical = part1 + part2;

      result = (int)Math.Sqrt(underRadical);
      return result;
    }

    static bool PointInPolygon(Point p, Point[] poly) {
      Point p1, p2;

      bool inside = false;

      if (poly.Length < 3) {
        return inside;
      }

      Point oldPoint = new Point(
      poly[poly.Length - 1].X, poly[poly.Length - 1].Y);

      for (int i = 0; i < poly.Length; i++) {
        Point newPoint = new Point(poly[i].X, poly[i].Y);

        if (newPoint.X > oldPoint.X) {
          p1 = oldPoint;
          p2 = newPoint;
        } else {
          p1 = newPoint;
          p2 = oldPoint;
        }

        if ((newPoint.X < p.X) == (p.X <= oldPoint.X)
        && ((long)p.Y - (long)p1.Y) * (long)(p2.X - p1.X)
         < ((long)p2.Y - (long)p1.Y) * (long)(p.X - p1.X)) {
          inside = !inside;
        }

        oldPoint = newPoint;
      }

      return inside;
    }

    public static string StripHTML(string HTMLText) {
      Regex reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
      return reg.Replace(HTMLText, "");
    }

    private void gmMain_OnTileLoadComplete(long ElapsedMilliseconds) {
      MethodInvoker m = delegate() {
        if (tmrLock.Interval == 700) { // finish locking    
          tmrLock.Enabled = true;
        }
      };
      try {
        BeginInvoke(m);
        return;
      } catch { }
    }

    private void label8_Click(object sender, EventArgs e)
    {

    }
    //////////////////////////////////////////////////////////////////////////////
  }
}
