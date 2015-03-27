using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ImgRescale
{
  public partial class SettingsWindow : Form
  {
    private Preset currentPreset;

    public SettingsWindow()
    {
      InitializeComponent();

      nudMaxWidth.Value = Properties.Settings.Default.imageMaxWidth;
      nudMaxHeight.Value = Properties.Settings.Default.imageMaxHeight;
      nudJpegQuality.Value = Properties.Settings.Default.jpegQuality;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      /*
      var idx = cbConfig.SelectedIndex;
      var text = cbConfig.Text;
      var cfg = ((MainWindow)Owner).GetSettings();

      if (idx == -1) {
        Log.Debug("Create new Config...{0} : {1}\n", text, cfg["lastSourceDir"]);

      }
      else {
        Log.Debug("Update current config...{0} to {1}\n", idx, text);
      }
       * */
    }

    private MainWindow parentInstance()
    {
      return (MainWindow)Owner;
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      var val1 = Convert.ToInt32(nudMaxWidth.Value);
      var val2 = Convert.ToInt32(nudMaxHeight.Value);
      var val3 = Convert.ToInt32(nudJpegQuality.Value);

      Properties.Settings.Default.imageMaxWidth = val1;
      Properties.Settings.Default.imageMaxHeight = val2;
      Properties.Settings.Default.jpegQuality = val3;
      Properties.Settings.Default.Save();

      this.Close();
    }

    private void SettingsWindow_Shown(object sender, EventArgs e)
    {
      MainWindow pw = parentInstance();
      if (pw != null) {
        cbPresetsBinding.DataSource = pw.Presets;
        cbPresets.DataSource = cbPresetsBinding;
        cbPresets.DisplayMember = "Name";
      }
      else {
        Log.Debug("Owner window is null!\n");
      }
    }

    private void cbPresets_SelectedIndexChanged(object sender, EventArgs e)
    {
      btnEditPreset.Enabled = cbPresets.SelectedIndex > 0;
      btnDeletePreset.Enabled = cbPresets.SelectedIndex > 0;
    }
  }
}
