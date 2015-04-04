using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace TimeDown {
  public partial class Form1 : Form {
    private int _iTimer = 0;
    private bool _bSilent = false;
    private bool _bStartup = false;

    public Form1() {
      InitializeComponent();
      miCBAction.SelectedIndex = 0;
      if (String.IsNullOrEmpty((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "TimeDown", ""))) { miStartup.Checked = true; _bStartup = true; }
    }

    private void tTimer_Tick(object sender, EventArgs e) {
      if (_iTimer > 0) {
        _iTimer--;
        if (_iTimer == 900) {
          if (_bSilent == false) {
            if (miCBAction.SelectedIndex == 0) {
              notifyIcon1.ShowBalloonTip(60000, "TimeDown", "15 Minuten bis zum herunterfahren.", ToolTipIcon.Warning);
            } else {
              notifyIcon1.ShowBalloonTip(60000, "TimeDown", "15 Minuten bis zum neu starten.", ToolTipIcon.Warning);
            }
          }
        } else if (_iTimer == 0) {
          #region Auswahl aktualisieren
          miOff.Checked = true;
          mi30m.Checked = false;
          mi60m.Checked = false;
          mi90m.Checked = false;
          mi120m.Checked = false;
          miCustom.Checked = false;
          #endregion
          if (miCBAction.SelectedIndex == 0) {
            if (_bSilent == false) { notifyIcon1.ShowBalloonTip(10000, "TimeDown", "Windows wird heruntergefahren.", ToolTipIcon.Info); };
            TimeDownExt.DoExitWin(TimeDownExt.EWX_SHUTDOWN);
          } else {
            if (_bSilent == false) { notifyIcon1.ShowBalloonTip(10000, "TimeDown", "Windows wird neu gestartet.", ToolTipIcon.Info); };
            TimeDownExt.DoExitWin(TimeDownExt.EWX_REBOOT);
          }
        }
      }
      if (miOff.Checked == false) { notifyIcon1.Text = String.Format("{0} Sekunden bis zum herunterfahren.", _iTimer); } else { notifyIcon1.Text = "Bereit"; }
    }

    private void miExit_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void miOff_Click(object sender, EventArgs e) {
      #region Auswahl aktualisieren
      miOff.Checked = true;
      mi30m.Checked = false;
      mi60m.Checked = false;
      mi90m.Checked = false;
      mi120m.Checked = false;
      miCustom.Checked = false;
      #endregion
      _iTimer = 0;
      miCustom.Text = "Benutzerdefiniert";
    }

    private void mi30m_Click(object sender, EventArgs e) {
      #region Auswahl aktualisieren
      miOff.Checked = false;
      mi30m.Checked = true;
      mi60m.Checked = false;
      mi90m.Checked = false;
      mi120m.Checked = false;
      miCustom.Checked = false;
      #endregion
      _iTimer = 1800;
      miCustom.Text = "Benutzerdefiniert";
    }

    private void mi60m_Click(object sender, EventArgs e) {
      #region Auswahl aktualisieren
      miOff.Checked = false;
      mi30m.Checked = false;
      mi60m.Checked = true;
      mi90m.Checked = false;
      mi120m.Checked = false;
      miCustom.Checked = false;
      #endregion
      _iTimer = 3600;
      miCustom.Text = "Benutzerdefiniert";
    }

    private void mi90m_Click(object sender, EventArgs e) {
      #region Auswahl aktualisieren
      miOff.Checked = false;
      mi30m.Checked = false;
      mi60m.Checked = false;
      mi90m.Checked = true;
      mi120m.Checked = false;
      miCustom.Checked = false;
      #endregion
      _iTimer = 5400;
      miCustom.Text = "Benutzerdefiniert";
    }

    private void mi120m_Click(object sender, EventArgs e) {
      #region Auswahl aktualisieren
      miOff.Checked = false;
      mi30m.Checked = false;
      mi60m.Checked = false;
      mi90m.Checked = false;
      mi120m.Checked = true;
      miCustom.Checked = false;
      #endregion
      _iTimer = 7200;
      miCustom.Text = "Benutzerdefiniert";
    }

    private void miCustom_Click(object sender, EventArgs e) {
      TimeInputForm fTimeInput = new TimeInputForm();
      if (fTimeInput.ShowDialog(this) == DialogResult.OK) {
        int irTimer = 0;
        try {
          irTimer = System.Convert.ToInt32(fTimeInput.tbDuration.Text);
        } catch {
          irTimer = 0;
          MessageBox.Show("Geben sie eine Ganze Zahl an!", "TimeDown", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        if (irTimer > 0) {
          if (fTimeInput.cbTimescale.SelectedIndex == 1) {
            irTimer = irTimer * 60;
          } else if (fTimeInput.cbTimescale.SelectedIndex == 2) {
            irTimer = irTimer * 60 * 60;
          }
          #region Auswahl aktualisieren
          miOff.Checked = false;
          mi30m.Checked = false;
          mi60m.Checked = false;
          mi90m.Checked = false;
          mi120m.Checked = false;
          miCustom.Checked = true;
          #endregion
          _iTimer = irTimer;
          miCustom.Text = String.Format("{0} Sekunden", _iTimer);
        }
      }
      fTimeInput.Dispose();
    }

    private void miSilent_Click(object sender, EventArgs e) {
      _bSilent = !_bSilent;
      miSilent.Checked = _bSilent;
    }

    private void miStartup_Click(object sender, EventArgs e) {
      _bStartup = !_bStartup;
      miStartup.Checked = _bStartup;
      if (_bStartup) {
        try {
          Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "TimeDown", string.Format("\"{0}\"", (string)Application.ExecutablePath));
        } catch (Exception eRegWrite) {
          throw new Exception(eRegWrite.Message, eRegWrite.InnerException);
        }
      } else {
        try {
          Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "TimeDown", "");
        } catch (Exception eRegWrite) {
          throw new Exception(eRegWrite.Message, eRegWrite.InnerException);
        }
      }
    }
  }
}
