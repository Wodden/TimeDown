namespace TimeDown {
  partial class TimeInputForm {
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
      this.tbDuration = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.cbTimescale = new System.Windows.Forms.ComboBox();
      this.bSubmit = new System.Windows.Forms.Button();
      this.bCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // tbDuration
      // 
      this.tbDuration.Location = new System.Drawing.Point(15, 25);
      this.tbDuration.MaxLength = 5;
      this.tbDuration.Name = "tbDuration";
      this.tbDuration.Size = new System.Drawing.Size(91, 20);
      this.tbDuration.TabIndex = 0;
      this.tbDuration.Text = "120";
      this.tbDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(175, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Zeitspanne bis zum Herunterfahren:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // cbTimescale
      // 
      this.cbTimescale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbTimescale.FormattingEnabled = true;
      this.cbTimescale.Items.AddRange(new object[] {
            "Sekunden",
            "Minuten",
            "Stunden"});
      this.cbTimescale.Location = new System.Drawing.Point(112, 24);
      this.cbTimescale.Name = "cbTimescale";
      this.cbTimescale.Size = new System.Drawing.Size(75, 21);
      this.cbTimescale.TabIndex = 2;
      // 
      // bSubmit
      // 
      this.bSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.bSubmit.Location = new System.Drawing.Point(15, 52);
      this.bSubmit.Name = "bSubmit";
      this.bSubmit.Size = new System.Drawing.Size(75, 23);
      this.bSubmit.TabIndex = 3;
      this.bSubmit.Text = "Ok";
      this.bSubmit.UseVisualStyleBackColor = true;
      // 
      // bCancel
      // 
      this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bCancel.Location = new System.Drawing.Point(111, 51);
      this.bCancel.Name = "bCancel";
      this.bCancel.Size = new System.Drawing.Size(75, 23);
      this.bCancel.TabIndex = 4;
      this.bCancel.Text = "Abbrechen";
      this.bCancel.UseVisualStyleBackColor = true;
      // 
      // TimeInputForm
      // 
      this.AcceptButton = this.bSubmit;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.bCancel;
      this.ClientSize = new System.Drawing.Size(204, 83);
      this.ControlBox = false;
      this.Controls.Add(this.bCancel);
      this.Controls.Add(this.bSubmit);
      this.Controls.Add(this.cbTimescale);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbDuration);
      this.Name = "TimeInputForm";
      this.Text = "TimeInputForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button bSubmit;
    private System.Windows.Forms.Button bCancel;
    public System.Windows.Forms.TextBox tbDuration;
    public System.Windows.Forms.ComboBox cbTimescale;
  }
}