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
  public partial class SavePreset : Form
  {
    private Dictionary<string, object> currentSettings;

    public SavePreset()
    {
      InitializeComponent();
    }

    private void tbName_TextChanged(object sender, EventArgs e)
    {
      var t = (TextBox)sender;
      var v = t.Text.Trim();

      if (v.Length > 0) {
        btnSave.Enabled = true;
      }
      else {
        btnSave.Enabled = false;
      }
    }

    private MainWindow getParent()
    {
      return (MainWindow)Owner;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      Log.Debug("Save this shit!\n");

      var intensity = Convert.ToInt32(currentSettings["intensity"]);
      var contrast = Convert.ToInt32(currentSettings["contrast"]);
      var saturation = Convert.ToInt32(currentSettings["saturation"]);
      string preview = null, sourceDir = null, targetDir = null;
      if (currentSettings["previewPath"] != null)
        preview = currentSettings["previewPath"].ToString();
      if (currentSettings["lastSourceDir"] != null)
        sourceDir = currentSettings["lastSourceDir"].ToString();
      if (currentSettings["lastTargetDir"] != null) 
        targetDir = currentSettings["lastTargetDir"].ToString();

      Preset ps = new Preset();
      ps.Name = tbName.Text.Trim();
      ps.PreviewImage = preview;
      ps.DestinationDir = targetDir;
      ps.SourceDir = sourceDir;
      ps.Saturation = saturation;
      ps.Contrast = contrast;
      ps.Intensity = intensity;

      ps.Save();

      Properties.Settings.Default.Save();

      this.Close();
    }

    private void SavePreset_Load(object sender, EventArgs e)
    {
      currentSettings = ((MainWindow)Owner).GetSettings();
    }
  }
}
