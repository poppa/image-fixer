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

      nudMaxWidth.Value = Convert.ToDecimal(Properties.Settings.Default.imageMaxWidth);
      nudMaxHeight.Value = Convert.ToDecimal(Properties.Settings.Default.imageMaxHeight);
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      Log.Debug("Combobox index changed...\n");

      var cb = (ComboBox)sender;
      var idx = cb.SelectedIndex;
      var item = cb.SelectedItem;

      if (idx > -1) {
        var obj = (Preset)item;
        currentPreset = obj;

        Log.Debug("   {0} is default?: {1}\n", obj.Name, obj.IsDefault);

        if (obj.IsDefault) {
          btnSave.Enabled = false;         
        }
        else {
          btnSave.Enabled = true;
        }
      }
      else {
        Log.Debug("   Changed index is -1\n");
      }
    }

    private void cbConfig_SelectedValueChanged(object sender, EventArgs e)
    {
      Log.Debug("Combobox selected value changed...\n");
    }

    private void cbConfig_TextChanged(object sender, EventArgs e)
    {
      var cb = (ComboBox)sender;
      var idx = cb.SelectedIndex;
      var item = cb.SelectedItem;
      var tlen = cb.Text.Trim().Length;

      Log.Debug("Combobox text changed at index {0} : {2}...\n",
         idx, cb.Text);

      if (currentPreset != null && currentPreset.IsDefault) {
        return;
      }

      if (idx > -1) {
        var obj = (Preset)item;

        Log.Debug("Obj: {0} : {1}\n", obj.Name, obj.Saturation);

        if (obj.IsDefault) {
          btnSave.Enabled = false;
          btnDelete.Enabled = false;
          return;
        }
        else {
          btnSave.Enabled = tlen > 0;
          btnDelete.Enabled = true;
        }
      }
      else {
        btnSave.Enabled = tlen > 0;
      }
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

    private MainWindow parentInstance()
    {
      return (MainWindow)Owner;
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      var val1 = Convert.ToInt32(nudMaxWidth.Value);
      var val2 = Convert.ToInt32(nudMaxHeight.Value);
      Properties.Settings.Default.imageMaxWidth = val1;
      Properties.Settings.Default.imageMaxHeight = val2;
      Properties.Settings.Default.Save();

      if (cbConfig.SelectedIndex > -1) {
        var item = cbConfig.SelectedItem;
        parentInstance().LoadPreset((Preset)item);
      }

      this.Close();
    }

    private void SettingsWindow_Shown(object sender, EventArgs e)
    {
      MainWindow pw = parentInstance();
      if (pw != null) {
        ArrayList dp = pw.GetDeafaultPresets();
        foreach (object ps in dp) {
          cbConfig.Items.Add((DefaultPreset)ps);
        }

        Preset curp = pw.CurrentPreset;

        if (curp != null) {
          int i = 0;
          foreach (var item in cbConfig.Items) {
            Preset p = (Preset)item;
            if (p.Name == curp.Name) {
              Log.Debug("Select: {0}\n", p.Name);
              cbConfig.SelectedIndex = i;
              break;
            }

            i++;
          }
        }
      }
      else {
        Log.Debug("Owner window is null!\n");
      }
    }
  }
}
