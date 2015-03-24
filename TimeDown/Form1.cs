using System;
using System.Windows.Forms;

namespace TimeDown {
  public partial class Form1 : Form {
    private int _iTimer = 0;

    public Form1() {
      InitializeComponent();
    }

    private void miExit_Click( object sender, EventArgs e ) {
      Application.Exit();
    }

    private void tTimer_Tick( object sender, EventArgs e ) {
      if ( _iTimer > 0 ) {
        _iTimer--;
        if ( _iTimer == 900 ) {
          notifyIcon1.ShowBalloonTip(60000);
        } else if ( _iTimer == 0 ) {
          #region Checked state
          miOff.Checked = true;
          mi30m.Checked = false;
          mi60m.Checked = false;
          mi90m.Checked = false;
          mi120m.Checked = false;
          #endregion
          notifyIcon1.ShowBalloonTip(15000, notifyIcon1.BalloonTipTitle, "Windows wird heruntergefahren.", ToolTipIcon.Info);
          TimeDownExt.DoExitWin(TimeDownExt.EWX_SHUTDOWN);
        }
      }
      notifyIcon1.Text = _iTimer + " Sekunden";
    }

    private void miOff_Click( object sender, EventArgs e ) {
      #region Checked state
      miOff.Checked = true;
      mi30m.Checked = false;
      mi60m.Checked = false;
      mi90m.Checked = false;
      mi120m.Checked = false;
      #endregion
      _iTimer = 0;
    }

    private void mi30m_Click( object sender, EventArgs e ) {
      #region Checked state
      miOff.Checked = false;
      mi30m.Checked = true;
      mi60m.Checked = false;
      mi90m.Checked = false;
      mi120m.Checked = false;
      #endregion
      _iTimer = 1800;
    }

    private void mi60m_Click( object sender, EventArgs e ) {
      #region Checked state
      miOff.Checked = false;
      mi30m.Checked = false;
      mi60m.Checked = true;
      mi90m.Checked = false;
      mi120m.Checked = false;
      #endregion
      _iTimer = 3600;
    }

    private void mi90m_Click( object sender, EventArgs e ) {
      #region Checked state
      miOff.Checked = false;
      mi30m.Checked = false;
      mi60m.Checked = false;
      mi90m.Checked = true;
      mi120m.Checked = false;
      #endregion
      _iTimer = 5400;
    }

    private void mi120m_Click( object sender, EventArgs e ) {
      #region Checked state
      miOff.Checked = false;
      mi30m.Checked = false;
      mi60m.Checked = false;
      mi90m.Checked = false;
      mi120m.Checked = true;
      #endregion
      _iTimer = 7200;
    }
  }
}
