using System;
using System.Windows.Forms;

namespace TimeDown {
  public partial class Form1 : Form {
    private int _iTimer = 0;
    private bool _bSilent = false;

    public Form1() {
      InitializeComponent();
      miCBAction.SelectedIndex = 0;
    }

    private void tTimer_Tick(object sender, EventArgs e) {
      if (_iTimer > 0) {
        _iTimer--;
        if (_iTimer == 900) {
          if (_bSilent == false) {
            if (miCBAction.SelectedIndex == 0) {
              notifyIcon1.BalloonTipText = "15 Minuten bis zum Herunterfahren.";
            } else {
              notifyIcon1.BalloonTipText = "15 Minuten bis zum neu starten.";
            }
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon1.ShowBalloonTip(60000);
          }
        } else if (_iTimer == 0) {
          #region Checked state
          miOff.Checked = true;
          mi30m.Checked = false;
          mi60m.Checked = false;
          mi90m.Checked = false;
          mi120m.Checked = false;
          miCustom.Checked = false;
          #endregion
          if (miCBAction.SelectedIndex == 0) {
            notifyIcon1.BalloonTipText = "Windows wird heruntergefahren.";
            TimeDownExt.DoExitWin(TimeDownExt.EWX_SHUTDOWN);
          } else {
            notifyIcon1.BalloonTipText = "Windows wird neu gestartet.";
            TimeDownExt.DoExitWin(TimeDownExt.EWX_REBOOT);
          }
          if (_bSilent == false) { notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning; notifyIcon1.ShowBalloonTip(10000); }
        }
      }
      if (miOff.Checked == false) { notifyIcon1.Text = _iTimer + " Sekunden"; } else { notifyIcon1.Text = "Bereit"; }
    }

    private void miExit_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void miOff_Click(object sender, EventArgs e) {
      #region Checked state
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
      #region Checked state
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
      #region Checked state
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
      #region Checked state
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
      #region Checked state
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
          MessageBox.Show("Geben sie eine ganze Zahl ein!", "TimeDown", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        if (irTimer > 0) {
          if (fTimeInput.cbTimescale.SelectedIndex == 1) {
            irTimer = irTimer * 60;
          } else if (fTimeInput.cbTimescale.SelectedIndex == 2) {
            irTimer = irTimer * 60 * 60;
          }
          #region Checked state
          miOff.Checked = false;
          mi30m.Checked = false;
          mi60m.Checked = false;
          mi90m.Checked = false;
          mi120m.Checked = false;
          miCustom.Checked = true;
          #endregion
          _iTimer = irTimer;
          miCustom.Text = _iTimer + " Sekunden";
        }
      }
      fTimeInput.Dispose();
    }

    private void miSilent_Click(object sender, EventArgs e) {
      _bSilent = !_bSilent;
      miSilent.Checked = _bSilent;
    }
  }
}
