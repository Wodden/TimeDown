namespace TimeDown
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.miCustom = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.mi120m = new System.Windows.Forms.ToolStripMenuItem();
      this.mi90m = new System.Windows.Forms.ToolStripMenuItem();
      this.mi60m = new System.Windows.Forms.ToolStripMenuItem();
      this.mi30m = new System.Windows.Forms.ToolStripMenuItem();
      this.miOff = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.miCBAction = new System.Windows.Forms.ToolStripComboBox();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.miSilent = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.miExit = new System.Windows.Forms.ToolStripMenuItem();
      this.tTimer = new System.Windows.Forms.Timer(this.components);
      this.miStartup = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
      this.notifyIcon1.BalloonTipText = "15 Minuten bis zum Herunterfahren! :0";
      this.notifyIcon1.BalloonTipTitle = "Achtung!";
      this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
      this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
      this.notifyIcon1.Text = "Bereit";
      this.notifyIcon1.Visible = true;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCustom,
            this.toolStripSeparator3,
            this.mi120m,
            this.mi90m,
            this.mi60m,
            this.mi30m,
            this.miOff,
            this.toolStripSeparator2,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.miExit});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(165, 220);
      // 
      // miCustom
      // 
      this.miCustom.Name = "miCustom";
      this.miCustom.Size = new System.Drawing.Size(164, 22);
      this.miCustom.Text = "Benutzerdefiniert";
      this.miCustom.Click += new System.EventHandler(this.miCustom_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
      // 
      // mi120m
      // 
      this.mi120m.Name = "mi120m";
      this.mi120m.Size = new System.Drawing.Size(164, 22);
      this.mi120m.Text = "120 Minuten";
      this.mi120m.Click += new System.EventHandler(this.mi120m_Click);
      // 
      // mi90m
      // 
      this.mi90m.Name = "mi90m";
      this.mi90m.Size = new System.Drawing.Size(164, 22);
      this.mi90m.Text = "90 Minuten";
      this.mi90m.Click += new System.EventHandler(this.mi90m_Click);
      // 
      // mi60m
      // 
      this.mi60m.Name = "mi60m";
      this.mi60m.Size = new System.Drawing.Size(164, 22);
      this.mi60m.Text = "60 Minuten";
      this.mi60m.Click += new System.EventHandler(this.mi60m_Click);
      // 
      // mi30m
      // 
      this.mi30m.Name = "mi30m";
      this.mi30m.Size = new System.Drawing.Size(164, 22);
      this.mi30m.Text = "30 Minuten";
      this.mi30m.Click += new System.EventHandler(this.mi30m_Click);
      // 
      // miOff
      // 
      this.miOff.Checked = true;
      this.miOff.CheckState = System.Windows.Forms.CheckState.Checked;
      this.miOff.Name = "miOff";
      this.miOff.Size = new System.Drawing.Size(164, 22);
      this.miOff.Text = "Deaktiviert";
      this.miOff.Click += new System.EventHandler(this.miOff_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCBAction,
            this.toolStripSeparator4,
            this.miSilent,
            this.miStartup});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
      this.toolStripMenuItem1.Text = "Optionen";
      // 
      // miCBAction
      // 
      this.miCBAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.miCBAction.Items.AddRange(new object[] {
            "Herunterfahren",
            "Neustarten"});
      this.miCBAction.Name = "miCBAction";
      this.miCBAction.Size = new System.Drawing.Size(121, 23);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(194, 6);
      // 
      // miSilent
      // 
      this.miSilent.Name = "miSilent";
      this.miSilent.Size = new System.Drawing.Size(197, 22);
      this.miSilent.Text = "Still";
      this.miSilent.Click += new System.EventHandler(this.miSilent_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
      // 
      // miExit
      // 
      this.miExit.Name = "miExit";
      this.miExit.Size = new System.Drawing.Size(164, 22);
      this.miExit.Text = "Beenden";
      this.miExit.Click += new System.EventHandler(this.miExit_Click);
      // 
      // tTimer
      // 
      this.tTimer.Enabled = true;
      this.tTimer.Interval = 1000;
      this.tTimer.Tick += new System.EventHandler(this.tTimer_Tick);
      // 
      // miStartup
      // 
      this.miStartup.Name = "miStartup";
      this.miStartup.Size = new System.Drawing.Size(197, 22);
      this.miStartup.Text = "Beim Systemstart laden";
      this.miStartup.Click += new System.EventHandler(this.miStartup_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 264);
      this.Name = "Form1";
      this.ShowInTaskbar = false;
      this.Text = "Form1";
      this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi120m;
        private System.Windows.Forms.ToolStripMenuItem mi90m;
        private System.Windows.Forms.ToolStripMenuItem mi60m;
        private System.Windows.Forms.ToolStripMenuItem mi30m;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miOff;
        public System.Windows.Forms.Timer tTimer;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miCustom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ToolStripComboBox miCBAction;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem miSilent;
        private System.Windows.Forms.ToolStripMenuItem miStartup;

    }
}

