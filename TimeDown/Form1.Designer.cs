﻿namespace TimeDown
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
			this.mi120m = new System.Windows.Forms.ToolStripMenuItem();
			this.mi90m = new System.Windows.Forms.ToolStripMenuItem();
			this.mi60m = new System.Windows.Forms.ToolStripMenuItem();
			this.mi30m = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.miOff = new System.Windows.Forms.ToolStripMenuItem();
			this.tTimer = new System.Windows.Forms.Timer(this.components);
			this.miExit = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
			this.notifyIcon1.BalloonTipText = "15 Minuten bis zum Herunterfahren! :0";
			this.notifyIcon1.BalloonTipTitle = "Aufbassen!";
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "0 Sekunden";
			this.notifyIcon1.Visible = true;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi120m,
            this.mi90m,
            this.mi60m,
            this.mi30m,
            this.miOff,
            this.toolStripSeparator1,
            this.miExit});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(141, 142);
			// 
			// mi120m
			// 
			this.mi120m.Name = "mi120m";
			this.mi120m.Size = new System.Drawing.Size(140, 22);
			this.mi120m.Text = "120 Minuten";
			this.mi120m.Click += new System.EventHandler(this.mi120m_Click);
			// 
			// mi90m
			// 
			this.mi90m.Name = "mi90m";
			this.mi90m.Size = new System.Drawing.Size(140, 22);
			this.mi90m.Text = "90 Minuten";
			this.mi90m.Click += new System.EventHandler(this.mi90m_Click);
			// 
			// mi60m
			// 
			this.mi60m.Name = "mi60m";
			this.mi60m.Size = new System.Drawing.Size(140, 22);
			this.mi60m.Text = "60 Minuten";
			this.mi60m.Click += new System.EventHandler(this.mi60m_Click);
			// 
			// mi30m
			// 
			this.mi30m.Name = "mi30m";
			this.mi30m.Size = new System.Drawing.Size(140, 22);
			this.mi30m.Text = "30 Minuten";
			this.mi30m.Click += new System.EventHandler(this.mi30m_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
			// 
			// miOff
			// 
			this.miOff.Checked = true;
			this.miOff.CheckState = System.Windows.Forms.CheckState.Checked;
			this.miOff.Name = "miOff";
			this.miOff.Size = new System.Drawing.Size(140, 22);
			this.miOff.Text = "Deaktiviert";
			this.miOff.Click += new System.EventHandler(this.miOff_Click);
			// 
			// tTimer
			// 
			this.tTimer.Enabled = true;
			this.tTimer.Interval = 1000;
			this.tTimer.Tick += new System.EventHandler(this.tTimer_Tick);
			// 
			// miExit
			// 
			this.miExit.Name = "miExit";
			this.miExit.Size = new System.Drawing.Size(140, 22);
			this.miExit.Text = "Beenden";
			this.miExit.Click += new System.EventHandler(this.miExit_Click);
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

    }
}
