using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Territory_Servant
{
    public partial class frmWhatsNew : Form
    {
        public frmWhatsNew()
        {
            InitializeComponent();
        }

        private void frmWhatsNew_Load(object sender, EventArgs e)
        {
            wbrMain.Url = new System.Uri("http://territoryservant.lvoe.us/whatsNew");
        }
    }
}
