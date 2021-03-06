﻿namespace Territory_Servant {
  partial class frmSettings {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.label1 = new System.Windows.Forms.Label();
        this.txtCongName = new System.Windows.Forms.TextBox();
        this.btnSave = new System.Windows.Forms.Button();
        this.btnClose = new System.Windows.Forms.Button();
        this.label2 = new System.Windows.Forms.Label();
        this.txtHallAddress = new System.Windows.Forms.TextBox();
        this.colorDialog = new System.Windows.Forms.ColorDialog();
        this.label3 = new System.Windows.Forms.Label();
        this.pbxHouseColor = new System.Windows.Forms.PictureBox();
        this.pbxDNCColor = new System.Windows.Forms.PictureBox();
        this.label4 = new System.Windows.Forms.Label();
        this.pbxSOColor = new System.Windows.Forms.PictureBox();
        this.label5 = new System.Windows.Forms.Label();
        this.label6 = new System.Windows.Forms.Label();
        this.tbrMainZoom = new System.Windows.Forms.TrackBar();
        this.label7 = new System.Windows.Forms.Label();
        this.tbrAreaZoom = new System.Windows.Forms.TrackBar();
        this.label8 = new System.Windows.Forms.Label();
        this.label9 = new System.Windows.Forms.Label();
        this.label10 = new System.Windows.Forms.Label();
        this.label11 = new System.Windows.Forms.Label();
        this.label12 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.pbxHouseColor)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pbxDNCColor)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pbxSOColor)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.tbrMainZoom)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.tbrAreaZoom)).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(21, 12);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(104, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Congregation Name:";
        // 
        // txtCongName
        // 
        this.txtCongName.Location = new System.Drawing.Point(131, 9);
        this.txtCongName.Name = "txtCongName";
        this.txtCongName.Size = new System.Drawing.Size(187, 20);
        this.txtCongName.TabIndex = 0;
        this.txtCongName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCongName_KeyUp);
        // 
        // btnSave
        // 
        this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.btnSave.Location = new System.Drawing.Point(74, 223);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(93, 40);
        this.btnSave.TabIndex = 3;
        this.btnSave.Text = "Save";
        this.btnSave.UseVisualStyleBackColor = true;
        // 
        // btnClose
        // 
        this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnClose.Location = new System.Drawing.Point(173, 223);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(93, 40);
        this.btnClose.TabIndex = 2;
        this.btnClose.Text = "Cancel";
        this.btnClose.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(12, 38);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(113, 13);
        this.label2.TabIndex = 0;
        this.label2.Text = "Kingdom Hall Address:";
        // 
        // txtHallAddress
        // 
        this.txtHallAddress.Location = new System.Drawing.Point(131, 35);
        this.txtHallAddress.Name = "txtHallAddress";
        this.txtHallAddress.Size = new System.Drawing.Size(187, 20);
        this.txtHallAddress.TabIndex = 1;
        this.txtHallAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHallAddress_KeyUp);
        // 
        // colorDialog
        // 
        this.colorDialog.AnyColor = true;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(12, 69);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(68, 13);
        this.label3.TabIndex = 4;
        this.label3.Text = "House Color:";
        // 
        // pbxHouseColor
        // 
        this.pbxHouseColor.BackColor = System.Drawing.SystemColors.Control;
        this.pbxHouseColor.Location = new System.Drawing.Point(86, 64);
        this.pbxHouseColor.Name = "pbxHouseColor";
        this.pbxHouseColor.Size = new System.Drawing.Size(25, 24);
        this.pbxHouseColor.TabIndex = 5;
        this.pbxHouseColor.TabStop = false;
        this.pbxHouseColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxHouseColor_MouseClick);
        // 
        // pbxDNCColor
        // 
        this.pbxDNCColor.BackColor = System.Drawing.SystemColors.Control;
        this.pbxDNCColor.Location = new System.Drawing.Point(194, 64);
        this.pbxDNCColor.Name = "pbxDNCColor";
        this.pbxDNCColor.Size = new System.Drawing.Size(25, 24);
        this.pbxDNCColor.TabIndex = 7;
        this.pbxDNCColor.TabStop = false;
        this.pbxDNCColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxDNCColor_MouseClick);
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(128, 69);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(60, 13);
        this.label4.TabIndex = 6;
        this.label4.Text = "DNC Color:";
        // 
        // pbxSOColor
        // 
        this.pbxSOColor.BackColor = System.Drawing.SystemColors.Control;
        this.pbxSOColor.Location = new System.Drawing.Point(293, 64);
        this.pbxSOColor.Name = "pbxSOColor";
        this.pbxSOColor.Size = new System.Drawing.Size(25, 24);
        this.pbxSOColor.TabIndex = 9;
        this.pbxSOColor.TabStop = false;
        this.pbxSOColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxSOColor_MouseClick);
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(235, 69);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(52, 13);
        this.label5.TabIndex = 8;
        this.label5.Text = "SO Color:";
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(42, 191);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(256, 13);
        this.label6.TabIndex = 10;
        this.label6.Text = "Color and Zoom changes will only apply to new maps";
        // 
        // tbrMainZoom
        // 
        this.tbrMainZoom.Location = new System.Drawing.Point(98, 101);
        this.tbrMainZoom.Maximum = 18;
        this.tbrMainZoom.Minimum = 15;
        this.tbrMainZoom.Name = "tbrMainZoom";
        this.tbrMainZoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        this.tbrMainZoom.Size = new System.Drawing.Size(220, 45);
        this.tbrMainZoom.TabIndex = 11;
        this.tbrMainZoom.TabStop = false;
        this.tbrMainZoom.Value = 17;
        this.tbrMainZoom.Scroll += new System.EventHandler(this.tbrMainZoom_Scroll);
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new System.Drawing.Point(12, 104);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(92, 13);
        this.label7.TabIndex = 12;
        this.label7.Text = "Main Zoom Level:";
        // 
        // tbrAreaZoom
        // 
        this.tbrAreaZoom.Location = new System.Drawing.Point(98, 144);
        this.tbrAreaZoom.Maximum = 17;
        this.tbrAreaZoom.Minimum = 14;
        this.tbrAreaZoom.Name = "tbrAreaZoom";
        this.tbrAreaZoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        this.tbrAreaZoom.Size = new System.Drawing.Size(220, 45);
        this.tbrAreaZoom.TabIndex = 11;
        this.tbrAreaZoom.TabStop = false;
        this.tbrAreaZoom.Value = 16;
        this.tbrAreaZoom.Scroll += new System.EventHandler(this.tbrAreaZoom_Scroll);
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Location = new System.Drawing.Point(13, 147);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(91, 13);
        this.label8.TabIndex = 12;
        this.label8.Text = "Area Zoom Level:";
        // 
        // label9
        // 
        this.label9.BackColor = System.Drawing.SystemColors.Control;
        this.label9.Location = new System.Drawing.Point(104, 164);
        this.label9.Name = "label9";
        this.label9.Size = new System.Drawing.Size(16, 16);
        this.label9.TabIndex = 13;
        this.label9.Text = "+";
        this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // label10
        // 
        this.label10.BackColor = System.Drawing.SystemColors.Control;
        this.label10.Location = new System.Drawing.Point(104, 121);
        this.label10.Name = "label10";
        this.label10.Size = new System.Drawing.Size(16, 16);
        this.label10.TabIndex = 13;
        this.label10.Text = "+";
        this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // label11
        // 
        this.label11.BackColor = System.Drawing.SystemColors.Control;
        this.label11.Location = new System.Drawing.Point(297, 121);
        this.label11.Name = "label11";
        this.label11.Size = new System.Drawing.Size(17, 17);
        this.label11.TabIndex = 13;
        this.label11.Text = "-";
        this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // label12
        // 
        this.label12.BackColor = System.Drawing.SystemColors.Control;
        this.label12.Location = new System.Drawing.Point(297, 164);
        this.label12.Name = "label12";
        this.label12.Size = new System.Drawing.Size(17, 17);
        this.label12.TabIndex = 13;
        this.label12.Text = "-";
        this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // frmSettings
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(341, 275);
        this.ControlBox = false;
        this.Controls.Add(this.label12);
        this.Controls.Add(this.label11);
        this.Controls.Add(this.label10);
        this.Controls.Add(this.label9);
        this.Controls.Add(this.label8);
        this.Controls.Add(this.tbrAreaZoom);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.tbrMainZoom);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.pbxSOColor);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.pbxDNCColor);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.pbxHouseColor);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.btnClose);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.txtHallAddress);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.txtCongName);
        this.Controls.Add(this.label1);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "frmSettings";
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Settings";
        this.TopMost = true;
        ((System.ComponentModel.ISupportInitialize)(this.pbxHouseColor)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pbxDNCColor)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pbxSOColor)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.tbrMainZoom)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.tbrAreaZoom)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.TextBox txtCongName;
    private System.Windows.Forms.Label label2;
    public System.Windows.Forms.TextBox txtHallAddress;
    public System.Windows.Forms.Button btnSave;
    public System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.ColorDialog colorDialog;
    private System.Windows.Forms.Label label3;
    public System.Windows.Forms.PictureBox pbxHouseColor;
    public System.Windows.Forms.PictureBox pbxDNCColor;
    private System.Windows.Forms.Label label4;
    public System.Windows.Forms.PictureBox pbxSOColor;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    public System.Windows.Forms.TrackBar tbrMainZoom;
    public System.Windows.Forms.TrackBar tbrAreaZoom;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
  }
}