using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Territory_Servant {
  public partial class frmDNC : Form {
    public frmDNC() {
      InitializeComponent();
    }

    private void check_fields() {
      if (txtHouseNumber.Text.Length > 0 && txtStreetName.Text.Length > 0 && txtNotes.Text.Length > 0)
        btnSave.Enabled = true;
      else
        btnSave.Enabled = false;
    }

    private void txtNotes_KeyUp(object sender, KeyEventArgs e) {
      check_fields();
    }

    private void txtHouseNumber_KeyUp(object sender, KeyEventArgs e) {
      check_fields();
    }

    private void txtStreetName_KeyUp(object sender, KeyEventArgs e) {
      check_fields();
    }

    private void frmDNC_Shown(object sender, EventArgs e) {
      check_fields();
    }
  }
}
