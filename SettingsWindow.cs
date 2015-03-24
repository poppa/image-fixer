using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImgRescale
{
  public partial class SettingsWindow : Form
  {
    public SettingsWindow()
    {
      InitializeComponent();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      Log.Debug("Combobox index changed...\n");
    }

    private void cbConfig_SelectedValueChanged(object sender, EventArgs e)
    {
      Log.Debug("Combobox selected value changed...\n");
    }

    private void cbConfig_TextChanged(object sender, EventArgs e)
    {
      var cb = (ComboBox)sender;
      var idx = cb.SelectedIndex;

      if (!btnSave.Enabled) {
        if (cb.Text.Trim().Length > 0)
          btnSave.Enabled = true;
      }
      else {
        if (cb.Text.Trim().Length <= 0)
          btnSave.Enabled = false;
      }

      Log.Debug("Combobox text changed at index {0} to {1} : {2}...\n", 
         idx, cb.SelectedValue, cb.Text);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      var idx = cbConfig.SelectedIndex;
      var text = cbConfig.Text;
      var cfg = ((MainWindow)Owner).GetSettings();

      if (idx == -1) {
        Log.Debug("Create new Config...{0} : {1}\n", text, cfg["lastSourceDir"]);

      }
      else {
        Log.Debug("Update current config...{0} to {1}\n", idx, text);
      }
    }
  }
}
