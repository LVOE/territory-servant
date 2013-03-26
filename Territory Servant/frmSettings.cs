using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Territory_Servant {
  public partial class frmSettings : Form {
    public bool color_change_enabled = true;

    public frmSettings() {
      InitializeComponent();
    }

    private void txtCongName_KeyUp(object sender, KeyEventArgs e) {
      if (txtCongName.Text.Length > 0 && txtHallAddress.Text.Length > 0)
        btnSave.Enabled = true;
      else
        btnSave.Enabled = false;
    }

    private void txtHallAddress_KeyUp(object sender, KeyEventArgs e) {
      if (txtCongName.Text.Length > 0 && txtHallAddress.Text.Length > 0)
        btnSave.Enabled = true;
      else
        btnSave.Enabled = false;
    }

    private void pbxHouseColor_MouseClick(object sender, MouseEventArgs e) {

      if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
        pbxHouseColor.BackColor = colorDialog.Color;
      }
    }

    private void pbxDNCColor_MouseClick(object sender, MouseEventArgs e) {

      if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
        pbxDNCColor.BackColor = colorDialog.Color;
      }
    }

    private void pbxSOColor_MouseClick(object sender, MouseEventArgs e) {

      if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
        pbxSOColor.BackColor = colorDialog.Color;
      }
    }

    private void tbrMainZoom_Scroll(object sender, EventArgs e)
    {
        if (tbrAreaZoom.Value >= tbrMainZoom.Value)
            tbrAreaZoom.Value = tbrMainZoom.Value - 1;
    }

    private void tbrAreaZoom_Scroll(object sender, EventArgs e)
    {
        if (tbrMainZoom.Value <= tbrAreaZoom.Value)
            tbrMainZoom.Value = tbrAreaZoom.Value + 1;
    }
  }
}
