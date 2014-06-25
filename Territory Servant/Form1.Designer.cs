namespace Territory_Servant
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gmMain = new GMap.NET.WindowsForms.GMapControl();
            this.xPanderPanelList1 = new BSE.Windows.Forms.XPanderPanelList();
            this.xppNavigate = new BSE.Windows.Forms.XPanderPanel();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.xppMark = new BSE.Windows.Forms.XPanderPanel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lstDNC = new NishBox.MultiLineListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xppDirections = new BSE.Windows.Forms.XPanderPanel();
            this.lblDirectionsInstructions = new System.Windows.Forms.Label();
            this.txtDirections = new System.Windows.Forms.TextBox();
            this.btnGetDirections = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.xppExport = new BSE.Windows.Forms.XPanderPanel();
            this.cmbTemplate = new System.Windows.Forms.ComboBox();
            this.lblExportInstructions = new System.Windows.Forms.Label();
            this.txtExportLog = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMapOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMapSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMapSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMapDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveMapDialog = new System.Windows.Forms.SaveFileDialog();
            this.tmrLock = new System.Windows.Forms.Timer(this.components);
            this.tmrDNC = new System.Windows.Forms.Timer(this.components);
            this.openTemplateDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pbDistance = new System.Windows.Forms.PictureBox();
            this.txtMapName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.savePdfDialog = new System.Windows.Forms.SaveFileDialog();
            this.xPanderPanelList1.SuspendLayout();
            this.xppNavigate.SuspendLayout();
            this.xppMark.SuspendLayout();
            this.xppDirections.SuspendLayout();
            this.xppExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // gmMain
            // 
            this.gmMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gmMain.Bearing = 0F;
            this.gmMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gmMain.CanDragMap = true;
            this.gmMain.GrayScaleMode = false;
            this.gmMain.LevelsKeepInMemmory = 5;
            this.gmMain.Location = new System.Drawing.Point(0, 0);
            this.gmMain.MarkersEnabled = true;
            this.gmMain.MaxZoom = 20;
            this.gmMain.MinZoom = 2;
            this.gmMain.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmMain.Name = "gmMain";
            this.gmMain.NegativeMode = false;
            this.gmMain.PolygonsEnabled = true;
            this.gmMain.RetryLoadTile = 0;
            this.gmMain.RoutesEnabled = true;
            this.gmMain.ShowTileGridLines = false;
            this.gmMain.Size = new System.Drawing.Size(647, 611);
            this.gmMain.TabIndex = 0;
            this.gmMain.Zoom = 0D;
            this.gmMain.OnTileLoadComplete += new GMap.NET.TileLoadComplete(this.gmMain_OnTileLoadComplete);
            this.gmMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gmMain_KeyUp);
            this.gmMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gmMain_MouseUp);
            // 
            // xPanderPanelList1
            // 
            this.xPanderPanelList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xPanderPanelList1.CaptionStyle = BSE.Windows.Forms.CaptionStyle.Flat;
            this.xPanderPanelList1.Controls.Add(this.xppNavigate);
            this.xPanderPanelList1.Controls.Add(this.xppMark);
            this.xPanderPanelList1.Controls.Add(this.xppDirections);
            this.xPanderPanelList1.Controls.Add(this.xppExport);
            this.xPanderPanelList1.GradientBackground = System.Drawing.Color.Empty;
            this.xPanderPanelList1.Location = new System.Drawing.Point(671, 57);
            this.xPanderPanelList1.Name = "xPanderPanelList1";
            this.xPanderPanelList1.PanelColors = null;
            this.xPanderPanelList1.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.xPanderPanelList1.Size = new System.Drawing.Size(235, 586);
            this.xPanderPanelList1.TabIndex = 1;
            this.xPanderPanelList1.Text = "xPanderPanelList1";
            // 
            // xppNavigate
            // 
            this.xppNavigate.CaptionFont = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold);
            this.xppNavigate.Controls.Add(this.btnLock);
            this.xppNavigate.Controls.Add(this.btnSearch);
            this.xppNavigate.Controls.Add(this.label1);
            this.xppNavigate.Controls.Add(this.txtSearch);
            this.xppNavigate.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xppNavigate.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.xppNavigate.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
            this.xppNavigate.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
            this.xppNavigate.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
            this.xppNavigate.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xppNavigate.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xppNavigate.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xppNavigate.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.xppNavigate.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xppNavigate.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xppNavigate.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xppNavigate.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xppNavigate.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xppNavigate.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xppNavigate.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xppNavigate.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xppNavigate.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xppNavigate.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xppNavigate.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xppNavigate.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.xppNavigate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xppNavigate.Image = null;
            this.xppNavigate.Name = "xppNavigate";
            this.xppNavigate.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.xppNavigate.Size = new System.Drawing.Size(235, 25);
            this.xppNavigate.TabIndex = 2;
            this.xppNavigate.Text = "Navigate";
            this.xppNavigate.ToolTipTextCloseIcon = null;
            this.xppNavigate.ToolTipTextExpandIconPanelCollapsed = null;
            this.xppNavigate.ToolTipTextExpandIconPanelExpanded = null;
            this.xppNavigate.ExpandClick += new System.EventHandler<System.EventArgs>(this.xppNavigate_ExpandClick);
            // 
            // btnLock
            // 
            this.btnLock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLock.BackColor = System.Drawing.Color.Transparent;
            this.btnLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.Location = new System.Drawing.Point(4, -11);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(227, 30);
            this.btnLock.TabIndex = 3;
            this.btnLock.TabStop = false;
            this.btnLock.Text = "LOCK";
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLock_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(5, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(225, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 221);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(5, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Enter an address and hit search";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // xppMark
            // 
            this.xppMark.CaptionFont = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold);
            this.xppMark.Controls.Add(this.txtNotes);
            this.xppMark.Controls.Add(this.lstDNC);
            this.xppMark.Controls.Add(this.label8);
            this.xppMark.Controls.Add(this.label3);
            this.xppMark.Controls.Add(this.label2);
            this.xppMark.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xppMark.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.xppMark.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
            this.xppMark.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
            this.xppMark.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
            this.xppMark.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xppMark.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xppMark.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xppMark.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.xppMark.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xppMark.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xppMark.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xppMark.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xppMark.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xppMark.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xppMark.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xppMark.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xppMark.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xppMark.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xppMark.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xppMark.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.xppMark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xppMark.Image = null;
            this.xppMark.Name = "xppMark";
            this.xppMark.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.xppMark.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.xppMark.Size = new System.Drawing.Size(235, 25);
            this.xppMark.TabIndex = 1;
            this.xppMark.Text = "Mark";
            this.xppMark.ToolTipTextCloseIcon = null;
            this.xppMark.ToolTipTextExpandIconPanelCollapsed = null;
            this.xppMark.ToolTipTextExpandIconPanelExpanded = null;
            this.xppMark.ExpandClick += new System.EventHandler<System.EventArgs>(this.xppMark_ExpandClick);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(7, 353);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(222, 106);
            this.txtNotes.TabIndex = 5;
            // 
            // lstDNC
            // 
            this.lstDNC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDNC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstDNC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstDNC.Location = new System.Drawing.Point(7, 226);
            this.lstDNC.Name = "lstDNC";
            this.lstDNC.ScrollAlwaysVisible = true;
            this.lstDNC.Size = new System.Drawing.Size(222, 106);
            this.lstDNC.TabIndex = 4;
            this.lstDNC.TabStop = false;
            this.lstDNC.UseTabStops = false;
            this.lstDNC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstDNC_KeyUp);
            this.lstDNC.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstDNC_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(4, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Other Notes:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(4, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Do Not Calls:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 178);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // xppDirections
            // 
            this.xppDirections.CaptionFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xppDirections.Controls.Add(this.lblDirectionsInstructions);
            this.xppDirections.Controls.Add(this.txtDirections);
            this.xppDirections.Controls.Add(this.btnGetDirections);
            this.xppDirections.Controls.Add(this.txtTo);
            this.xppDirections.Controls.Add(this.label5);
            this.xppDirections.Controls.Add(this.txtFrom);
            this.xppDirections.Controls.Add(this.label4);
            this.xppDirections.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xppDirections.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.xppDirections.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
            this.xppDirections.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
            this.xppDirections.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
            this.xppDirections.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xppDirections.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xppDirections.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xppDirections.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.xppDirections.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xppDirections.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xppDirections.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xppDirections.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xppDirections.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xppDirections.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xppDirections.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xppDirections.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xppDirections.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xppDirections.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xppDirections.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xppDirections.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.xppDirections.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xppDirections.Image = null;
            this.xppDirections.Name = "xppDirections";
            this.xppDirections.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.xppDirections.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.xppDirections.Size = new System.Drawing.Size(235, 25);
            this.xppDirections.TabIndex = 3;
            this.xppDirections.Text = "Directions";
            this.xppDirections.ToolTipTextCloseIcon = null;
            this.xppDirections.ToolTipTextExpandIconPanelCollapsed = null;
            this.xppDirections.ToolTipTextExpandIconPanelExpanded = null;
            this.xppDirections.ExpandClick += new System.EventHandler<System.EventArgs>(this.xppDirections_ExpandClick);
            // 
            // lblDirectionsInstructions
            // 
            this.lblDirectionsInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDirectionsInstructions.Location = new System.Drawing.Point(4, -161);
            this.lblDirectionsInstructions.Name = "lblDirectionsInstructions";
            this.lblDirectionsInstructions.Size = new System.Drawing.Size(226, 169);
            this.lblDirectionsInstructions.TabIndex = 6;
            this.lblDirectionsInstructions.Text = resources.GetString("lblDirectionsInstructions.Text");
            // 
            // txtDirections
            // 
            this.txtDirections.Location = new System.Drawing.Point(6, 115);
            this.txtDirections.Margin = new System.Windows.Forms.Padding(3, 3, 3, 180);
            this.txtDirections.Multiline = true;
            this.txtDirections.Name = "txtDirections";
            this.txtDirections.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDirections.Size = new System.Drawing.Size(223, 232);
            this.txtDirections.TabIndex = 5;
            this.txtDirections.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDirections_KeyUp);
            // 
            // btnGetDirections
            // 
            this.btnGetDirections.Location = new System.Drawing.Point(37, 82);
            this.btnGetDirections.Name = "btnGetDirections";
            this.btnGetDirections.Size = new System.Drawing.Size(193, 27);
            this.btnGetDirections.TabIndex = 4;
            this.btnGetDirections.Text = "Get Directions";
            this.btnGetDirections.UseVisualStyleBackColor = true;
            this.btnGetDirections.Click += new System.EventHandler(this.btnGetDirections_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(37, 56);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(193, 20);
            this.txtTo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "To:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(37, 30);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(193, 20);
            this.txtFrom.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "From:";
            // 
            // xppExport
            // 
            this.xppExport.CaptionFont = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold);
            this.xppExport.Controls.Add(this.cmbTemplate);
            this.xppExport.Controls.Add(this.lblExportInstructions);
            this.xppExport.Controls.Add(this.txtExportLog);
            this.xppExport.Controls.Add(this.btnExport);
            this.xppExport.Controls.Add(this.label6);
            this.xppExport.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xppExport.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.xppExport.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
            this.xppExport.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
            this.xppExport.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
            this.xppExport.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xppExport.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xppExport.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xppExport.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.xppExport.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xppExport.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xppExport.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xppExport.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xppExport.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xppExport.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xppExport.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xppExport.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xppExport.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xppExport.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xppExport.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xppExport.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.xppExport.Expand = true;
            this.xppExport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xppExport.Image = null;
            this.xppExport.Name = "xppExport";
            this.xppExport.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.xppExport.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.xppExport.Size = new System.Drawing.Size(235, 511);
            this.xppExport.TabIndex = 0;
            this.xppExport.Text = "Export";
            this.xppExport.ToolTipTextCloseIcon = null;
            this.xppExport.ToolTipTextExpandIconPanelCollapsed = null;
            this.xppExport.ToolTipTextExpandIconPanelExpanded = null;
            this.xppExport.ExpandClick += new System.EventHandler<System.EventArgs>(this.xppExport_ExpandClick_1);
            // 
            // cmbTemplate
            // 
            this.cmbTemplate.Location = new System.Drawing.Point(61, 34);
            this.cmbTemplate.Name = "cmbTemplate";
            this.cmbTemplate.Size = new System.Drawing.Size(168, 21);
            this.cmbTemplate.Sorted = true;
            this.cmbTemplate.TabIndex = 1;
            this.cmbTemplate.SelectedIndexChanged += new System.EventHandler(this.cmbTemplate_SelectedIndexChanged);
            this.cmbTemplate.TextChanged += new System.EventHandler(this.cmbTemplate_TextChanged);
            // 
            // lblExportInstructions
            // 
            this.lblExportInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExportInstructions.Location = new System.Drawing.Point(4, 439);
            this.lblExportInstructions.Name = "lblExportInstructions";
            this.lblExportInstructions.Size = new System.Drawing.Size(226, 73);
            this.lblExportInstructions.TabIndex = 4;
            this.lblExportInstructions.Text = "Click the Template box to select the template you wish to use. By default it will" +
    " be set to the last template you used.\r\n\r\nClick the Export button to export your" +
    " map.";
            // 
            // txtExportLog
            // 
            this.txtExportLog.Location = new System.Drawing.Point(7, 113);
            this.txtExportLog.Margin = new System.Windows.Forms.Padding(3, 3, 3, 83);
            this.txtExportLog.Multiline = true;
            this.txtExportLog.Name = "txtExportLog";
            this.txtExportLog.ReadOnly = true;
            this.txtExportLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExportLog.Size = new System.Drawing.Size(223, 344);
            this.txtExportLog.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(6, 62);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(224, 45);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnExport_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Template:";
            // 
            // pbMain
            // 
            this.pbMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMain.Location = new System.Drawing.Point(0, 0);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(647, 611);
            this.pbMain.TabIndex = 2;
            this.pbMain.TabStop = false;
            this.pbMain.Visible = false;
            this.pbMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMapOpen,
            this.mnuMapSave,
            this.mnuMapSaveAs});
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.mapToolStripMenuItem.Text = "Map";
            // 
            // mnuMapOpen
            // 
            this.mnuMapOpen.Name = "mnuMapOpen";
            this.mnuMapOpen.Size = new System.Drawing.Size(125, 22);
            this.mnuMapOpen.Text = "Open";
            this.mnuMapOpen.Click += new System.EventHandler(this.mnuMapOpen_Click_1);
            // 
            // mnuMapSave
            // 
            this.mnuMapSave.Name = "mnuMapSave";
            this.mnuMapSave.Size = new System.Drawing.Size(125, 22);
            this.mnuMapSave.Text = "Save";
            this.mnuMapSave.Click += new System.EventHandler(this.mnuMapSave_Click);
            // 
            // mnuMapSaveAs
            // 
            this.mnuMapSaveAs.Name = "mnuMapSaveAs";
            this.mnuMapSaveAs.Size = new System.Drawing.Size(125, 22);
            this.mnuMapSaveAs.Text = "Save As...";
            this.mnuMapSaveAs.Click += new System.EventHandler(this.mnuMapSaveAs_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // openMapDialog
            // 
            this.openMapDialog.Filter = "Maps|*.map";
            // 
            // saveMapDialog
            // 
            this.saveMapDialog.Filter = "Maps|*.map";
            // 
            // tmrLock
            // 
            this.tmrLock.Interval = 500;
            this.tmrLock.Tick += new System.EventHandler(this.tmrLock_Tick);
            // 
            // tmrDNC
            // 
            this.tmrDNC.Interval = 300;
            // 
            // openTemplateDialog
            // 
            this.openTemplateDialog.Filter = "XML files|*.xml";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.pbMain);
            this.pnlMain.Controls.Add(this.gmMain);
            this.pnlMain.Controls.Add(this.pbDistance);
            this.pnlMain.Location = new System.Drawing.Point(12, 31);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(647, 611);
            this.pnlMain.TabIndex = 4;
            // 
            // pbDistance
            // 
            this.pbDistance.Location = new System.Drawing.Point(0, 0);
            this.pbDistance.Name = "pbDistance";
            this.pbDistance.Size = new System.Drawing.Size(647, 611);
            this.pbDistance.TabIndex = 3;
            this.pbDistance.TabStop = false;
            this.pbDistance.Visible = false;
            // 
            // txtMapName
            // 
            this.txtMapName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMapName.Location = new System.Drawing.Point(732, 31);
            this.txtMapName.Name = "txtMapName";
            this.txtMapName.Size = new System.Drawing.Size(174, 20);
            this.txtMapName.TabIndex = 5;
            this.txtMapName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMapName_KeyUp);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Map Name:";
            // 
            // savePdfDialog
            // 
            this.savePdfDialog.Filter = "PDF Files|*.pdf";
            this.savePdfDialog.RestoreDirectory = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 662);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMapName);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.xPanderPanelList1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Territory Servant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.xPanderPanelList1.ResumeLayout(false);
            this.xppNavigate.ResumeLayout(false);
            this.xppNavigate.PerformLayout();
            this.xppMark.ResumeLayout(false);
            this.xppMark.PerformLayout();
            this.xppDirections.ResumeLayout(false);
            this.xppDirections.PerformLayout();
            this.xppExport.ResumeLayout(false);
            this.xppExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmMain;
        private BSE.Windows.Forms.XPanderPanelList xPanderPanelList1;
        private BSE.Windows.Forms.XPanderPanel xppDirections;
        private BSE.Windows.Forms.XPanderPanel xppExport;
        private BSE.Windows.Forms.XPanderPanel xppNavigate;
        private BSE.Windows.Forms.XPanderPanel xppMark;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMapOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuMapSave;
        private System.Windows.Forms.OpenFileDialog openMapDialog;
        private System.Windows.Forms.ToolStripMenuItem mnuMapSaveAs;
        private System.Windows.Forms.SaveFileDialog saveMapDialog;
        private System.Windows.Forms.Timer tmrLock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrDNC;
        private System.Windows.Forms.TextBox txtDirections;
        private System.Windows.Forms.Button btnGetDirections;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openTemplateDialog;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtExportLog;
        private System.Windows.Forms.Label lblDirectionsInstructions;
        private System.Windows.Forms.Label lblExportInstructions;
        private System.Windows.Forms.PictureBox pbDistance;
        private System.Windows.Forms.TextBox txtMapName;
        private System.Windows.Forms.Label label7;
        private NishBox.MultiLineListBox lstDNC;
        private System.Windows.Forms.SaveFileDialog savePdfDialog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cmbTemplate;

    }
}

