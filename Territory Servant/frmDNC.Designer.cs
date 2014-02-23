namespace Territory_Servant {
  partial class frmDNC {
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
      this.txtHouseNumber = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtNotes = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.chksexual_offender = new System.Windows.Forms.CheckBox();
      this.dtpDateRecorded = new System.Windows.Forms.DateTimePicker();
      this.label3 = new System.Windows.Forms.Label();
      this.txtStreetName = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtHouseNumber
      // 
      this.txtHouseNumber.Location = new System.Drawing.Point(90, 16);
      this.txtHouseNumber.Name = "txtHouseNumber";
      this.txtHouseNumber.Size = new System.Drawing.Size(48, 20);
      this.txtHouseNumber.TabIndex = 0;
      this.txtHouseNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHouseNumber_KeyUp);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "House No:";
      // 
      // txtNotes
      // 
      this.txtNotes.Location = new System.Drawing.Point(18, 86);
      this.txtNotes.Multiline = true;
      this.txtNotes.Name = "txtNotes";
      this.txtNotes.Size = new System.Drawing.Size(240, 124);
      this.txtNotes.TabIndex = 4;
      this.txtNotes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNotes_KeyUp);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 70);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Notes:";
      // 
      // btnSave
      // 
      this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnSave.Enabled = false;
      this.btnSave.Location = new System.Drawing.Point(17, 216);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(117, 35);
      this.btnSave.TabIndex = 6;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(140, 216);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(116, 35);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // chksexual_offender
      // 
      this.chksexual_offender.AutoSize = true;
      this.chksexual_offender.Location = new System.Drawing.Point(156, 69);
      this.chksexual_offender.Name = "chksexual_offender";
      this.chksexual_offender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.chksexual_offender.Size = new System.Drawing.Size(102, 17);
      this.chksexual_offender.TabIndex = 3;
      this.chksexual_offender.Text = "Sexual Offender";
      this.chksexual_offender.UseVisualStyleBackColor = true;
      // 
      // dtpDateRecorded
      // 
      this.dtpDateRecorded.CustomFormat = "MM/dd/yyyy";
      this.dtpDateRecorded.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpDateRecorded.Location = new System.Drawing.Point(180, 15);
      this.dtpDateRecorded.Name = "dtpDateRecorded";
      this.dtpDateRecorded.Size = new System.Drawing.Size(78, 20);
      this.dtpDateRecorded.TabIndex = 1;
      this.dtpDateRecorded.Value = new System.DateTime(2011, 2, 1, 0, 0, 0, 0);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(144, 18);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(33, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Date:";
      // 
      // txtStreetName
      // 
      this.txtStreetName.Location = new System.Drawing.Point(90, 41);
      this.txtStreetName.Name = "txtStreetName";
      this.txtStreetName.Size = new System.Drawing.Size(168, 20);
      this.txtStreetName.TabIndex = 2;
      this.txtStreetName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStreetName_KeyUp);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(15, 44);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(69, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "Street Name:";
      // 
      // frmDNC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(272, 261);
      this.ControlBox = false;
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtStreetName);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.dtpDateRecorded);
      this.Controls.Add(this.chksexual_offender);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtNotes);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtHouseNumber);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmDNC";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Add DNC";
      this.TopMost = true;
      this.Shown += new System.EventHandler(this.frmDNC_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnCancel;
    public System.Windows.Forms.TextBox txtHouseNumber;
    public System.Windows.Forms.TextBox txtNotes;
    public System.Windows.Forms.Button btnSave;
    public System.Windows.Forms.CheckBox chksexual_offender;
    private System.Windows.Forms.Label label3;
    public System.Windows.Forms.DateTimePicker dtpDateRecorded;
    public System.Windows.Forms.TextBox txtStreetName;
    private System.Windows.Forms.Label label5;
  }
}