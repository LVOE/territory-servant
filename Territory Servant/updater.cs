using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Territory_Servant {
  class Updater {
    public void check_for_updates() {
      WebDownload download = new WebDownload(60000);
      download.DownloadFileCompleted += new AsyncCompletedEventHandler(WebDownload_Completed);
      download.DownloadFileAsync(new Uri("http://territoryservant.lvoe.us/update.xml"), Path.GetDirectoryName(Application.ExecutablePath) + @"\update.dat");
    }

    private void WebDownload_Completed(object sender, AsyncCompletedEventArgs e) {
      try {
        if (!File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + @"\update.dat")) return;

        XmlDocument xml = new XmlDocument();
        xml.Load(Path.GetDirectoryName(Application.ExecutablePath) + @"\update.dat");

        bool UpdateFound = false;
        string url = "";
        XmlNodeList nodes = xml.SelectNodes("/update");
        if (nodes.Count > 0) {
          foreach (XmlNode node in nodes) {
            XmlNodeList nodes_2 = node.SelectNodes("version");
            if (nodes_2.Count > 0) {
              foreach (XmlNode node_2 in nodes_2) {
                if (node_2.InnerText.Length > 0 && Convert.ToDouble(node_2.InnerText) > Form1.Version) {
                  UpdateFound = true;
                }
              }
            }

            nodes_2 = node.SelectNodes("url");
            if (nodes_2.Count > 0) {
              foreach (XmlNode node_2 in nodes_2) {
                if (node_2.InnerText.Length > 0) {
                  url = node_2.InnerText;
                }
              }
            }
          }
        }

        if (UpdateFound && url.Length > 0) {
          if (MessageBox.Show("An update has been found for Territory Servant. Would you like to update?", "Update Found", MessageBoxButtons.YesNo) == DialogResult.Yes) {
            System.Diagnostics.Process.Start(url);
          }
        }
      } catch { }
    }
  }
}
