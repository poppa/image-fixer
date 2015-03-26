using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ImgRescale
{
  public partial class MainWindow : Form
  {
    const int PREVIEW_MAX_WIDTH = 1000;
    const int PREVIEW_MAX_HEIGHT = 800;
    private string previewPath;
    // Low resolution version to do previews on
    private Bitmap previewImg;

    private int defaultWidth = 0;
    private int defaultHeight = 0;
    private bool defaultRecurse = true;

    private float saturation = 1f;
    private float intensity = 1f;
    private float contrast = 1f;

    // Luminance vector for linear RGB
    const float rwgt = 0.3086f;
    const float gwgt = 0.6094f;
    const float bwgt = 0.0820f;

    private ImageAttributes iAttr;
    private Preset currentPreset;

    private BackgroundWorker worker = new BackgroundWorker();
    private BackgroundWorker previewWorker = new BackgroundWorker();
    Properties.Settings settings = Properties.Settings.Default;

    List<Preset> realPresets = new List<Preset>();
    List<string> presetModel = new List<string>();

    public MainWindow()
    {
      InitializeComponent();

      worker.WorkerReportsProgress = true;
      worker.WorkerSupportsCancellation = true;
      worker.DoWork += new DoWorkEventHandler(do_runApp);
      worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(on_workerCompleted);

      previewWorker.WorkerSupportsCancellation = false;
      previewWorker.DoWork += new DoWorkEventHandler(do_previewTransformation);
      previewWorker.RunWorkerCompleted  += new RunWorkerCompletedEventHandler(on_previewWorkerComplete);

      int ww = settings.winWidth;
      int wh = settings.winHeight;
      int wx = settings.winLeft;
      int wy = settings.winTop;

      if (ww > 100)
        this.Width = ww;
      if (wh > 70)
        this.Height = wh;
      if (wx >= 0)
        this.Left = wx;
      if (wy >= 0)
        this.Top = wy;

      if (settings.winMaximzed) {
        this.WindowState = FormWindowState.Maximized;
      }

      cbPresets.DataSource = presetModel;

      initPresets();
      updateGlobalSettings();
    }

    private void updateGlobalSettings()
    {
      defaultWidth = settings.imageMaxWidth;
      defaultHeight = settings.imageMaxHeight;
      Image.MaxWidth = defaultWidth;
      Image.MaxHeight = defaultHeight;
    }

    public Dictionary<string,object> GetSettings()
    {
      return new Dictionary<string, object>() {
        { "saturation", this.nudSaturation.Value },
        { "contrast", this.nudContrast.Value },
        { "intensity", this.nudIntensity.Value },
        { "lastSourceDir", this.btnSrcDir.Text },
        { "lastTargetDir", this.btnTargetDir.Text },
        { "previewPath", this.previewPath }
      };
    }

    public void LoadPreset(Preset ps)
    {
      nudContrast.Value = ps.Contrast;
      nudIntensity.Value = ps.Intensity;
      nudSaturation.Value = ps.Saturation;

      currentPreset = ps;
    }

    public Preset CurrentPreset
    {
      get { return currentPreset; }
      private set { currentPreset = value; }
    }

    private void loadPresets()
    {
      loadPresets(null);
    }

    private void initPresets()
    {
      var presets = SerializedArray.Deserialize(settings.presets);

      if (presets == null)
        return;

      foreach (var item in presets) {
        var ps = (Preset)item;
        realPresets.Add(ps);
        presetModel.Add(ps.Name);
      }

      Log.Debug("Preset model length: {0}\n", presetModel.Count);
    }

    private void loadPresets(string name)
    {
      var presets = SerializedArray.Deserialize(settings.presets);
      
      if (presets == null)
        return;

      if (presets.Count > 0) {
        Preset ps = (Preset)presets[0];
        Log.Debug("Load presets: {0} > {1}\n", presets.Count, ps.Name);
      }



      var items = cbPresets.Items;
      
      if (items.Count > 0)
        cbPresets.Items.Clear();



    }

    private void Form1_Load(object sender, EventArgs e)
    {
      statusText1.Text = "";
      //statusText2.Text = "Logfil: " + Log.Path;
      Log.Debug("\n\n-------------------\nStarting application dude...\n");

      string sd = settings.lastSrcDir;
      string td = settings.lastDestDir;

      if (!string.IsNullOrEmpty(sd))
        fbdSource.SelectedPath = sd;

      if (!string.IsNullOrEmpty(td))
        fbdTarget.SelectedPath = td;

      //Log.Debug("Source dir: {0}\n", sd);
      //Log.Debug("Target dir: {0}\n", td);

      if (!string.IsNullOrEmpty(sd))
        btnSrcDir.Text = sd;
#if DEBUG
      else
        btnSrcDir.Text = @"C:\Users\ponost\Pictures\test";
#endif

      if (!string.IsNullOrEmpty(td))
        btnTargetDir.Text = td;
#if DEBUG
      else
        btnTargetDir.Text = @"C:\Users\ponost\Pictures\res";
#endif

      Image.MaxWidth = defaultWidth;
      Image.MaxHeight = defaultHeight;
      Dir.Recurse = defaultRecurse;
    }

    private void btnSrcDir_Click(object sender, EventArgs e)
    {
      var res = fbdSource.ShowDialog();

      if (res == System.Windows.Forms.DialogResult.OK) {
        btnSrcDir.Text = fbdSource.SelectedPath;
        settings.lastSrcDir = btnSrcDir.Text;
        settings.Save();
      }
    }

    private void source_dest_Change(object sender, EventArgs e)
    {
      string a, b;
      a = btnSrcDir.Text;
      b = btnTargetDir.Text;

      if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b)) {
        btnRun.Enabled = true;
      }
      else {
        btnRun.Enabled = false;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var res = fbdTarget.ShowDialog();

      if (res == System.Windows.Forms.DialogResult.OK) {
        btnTargetDir.Text = fbdTarget.SelectedPath;
        settings.lastDestDir = btnTargetDir.Text;
        settings.Save();
      }
    }

    private void btnRun_Click(object sender, EventArgs e)
    {
      statusText1.Text = "";
      btnRun.Enabled = false;
      btnSrcDir.Enabled = false;
      btnTargetDir.Enabled = false;
      runApp();
    }

    private void do_runApp(object sender, EventArgs e)
    {
      Indexer id = Indexer.Get(btnSrcDir.Text);

      this.Invoke((MethodInvoker)delegate() {
        statusText1.Text = "";
      });

      if (Image.Instances > 0) {
        this.Invoke((MethodInvoker) delegate() {
          statusText2.Text = String.Format("Bearbetar bild {0}/{1}", 1, Image.Instances);
        });

        id.Run();
      }

      ((Dir)id).Dispose();
      id = null;
    }

    private void on_workerCompleted(object sender, EventArgs e)
    {
      Log.Debug("Worker completed...");
      reset();
    }

    private void setMatrix()
    {
      Log.Debug("Set matrix: saturation={0}, brigthness={1}, contrast={2}\n",
                saturation, intensity, contrast);

      if (iAttr != null)
        iAttr.Dispose();

      iAttr = new ImageAttributes();

      float adjBri = intensity - 1f;

      float baseSat = 1.0f - saturation;
      float baseCon = 1.0f - contrast;

      float a = ((baseSat) * rwgt + saturation) * contrast;
      float b = ((baseSat) * rwgt) * contrast;
      float c = ((baseSat) * rwgt) * contrast;

      float d = ((baseSat) * gwgt) * contrast;
      float e = ((baseSat) * gwgt + saturation) * contrast;
      float f = ((baseSat) * gwgt) * contrast;

      float g = ((baseSat) * bwgt) * contrast;
      float h = ((baseSat) * bwgt) * contrast;
      float i = ((baseSat) * bwgt + saturation) * contrast;


      float[][] mtx = { new float[]{ a, b, c, 0, 0 },
                        new float[]{ d, e, f, 0, 0 },
                        new float[]{ g, h, i, 0, 0 },
                        new float[]{ 0, 0, 0, 1, 0 },
                        new float[]{ adjBri, adjBri, adjBri, 0, 1 } };

#if DEBUG
      for (int ii = 0; ii < mtx.Length; ii++) {
        string x = "";

        switch (ii) {
          case 0: x = "R"; break;
          case 1: x = "G"; break;
          case 2: x = "B"; break;
          case 3: x = "A"; break;
          case 4: x = "-"; break;
        }

        Log.Debug("{0}: {{", x);

        for (int jj = 0; jj < mtx[ii].Length; jj++) {
          if (jj > 0) Log.Debug(", ");
          Log.Debug("{0}", mtx[ii][jj]);
        }

        Log.Debug("}\n");
      }
#endif

      iAttr.SetColorMatrix(new ColorMatrix(mtx), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
    }

    private void runApp()
    {
      if (!worker.IsBusy) {
        if (saturation != 1f || intensity != 1f || saturation != 1f) {
          setMatrix();
          Image.Attributes = iAttr;
        }

        statusText1.Text = "Samlar bilder...";

        int nimg = 0;
        Image.ImageCreated += () => {
          nimg += 1;
          this.Invoke((MethodInvoker)delegate() {
            statusText2.Text = nimg.ToString();
          });
        };

        Indexer.TargetBaseDir = new System.IO.FileInfo(btnTargetDir.Text);
        Indexer.SourceBaseDir = new System.IO.FileInfo(btnSrcDir.Text);

        int count = 1;
        Indexer.ImageProcessed += () => {
          count += 1;
          this.Invoke((MethodInvoker)delegate() {
            statusText2.Text = String.Format("Bearbetar bild {0}/{1}", count, Image.Instances);
          });
        };

        worker.RunWorkerAsync();
      }
    }

    private void reset()
    {
      statusText2.Text = "";
      statusText1.Text = "Klar";
      btnRun.Enabled = true;
      btnSrcDir.Enabled = true;
      btnTargetDir.Enabled = true;
      Indexer.Reset();
      if (iAttr != null) {
        iAttr.Dispose();
        iAttr = null;
      }
    }

    private void applyPreview()
    {
      if (!previewWorker.IsBusy) {
        if (previewImg != null) {
          statusText1.Text = "Applicerar förhandsvisning...";
          disableControls();
          setMatrix();
          previewWorker.RunWorkerAsync();
        }
      }
      else {
        Log.Debug("Preview worker busy!\n");
      }
    }

    private void trackBarSaturation_Scroll(object sender, EventArgs e)
    {
      nudSaturation.Value = Convert.ToDecimal(((TrackBar)sender).Value);
    }

    private void numSaturation_ValueChanged(object sender, EventArgs e)
    {
      var s = (NumericUpDown)sender;
      var value = s.Value * -1;
      tbSaturation.Value = Convert.ToInt32(s.Value);
      saturation = 1f - (Convert.ToInt32(value) / 100f);
    }

    private void trackBarIntensity_Scroll(object sender, EventArgs e)
    {
      nudIntensity.Value = Convert.ToDecimal(((TrackBar)sender).Value);
    }

    private void numIntensity_ValueChanged(object sender, EventArgs e)
    {
      var s = (NumericUpDown)sender;
      var value = s.Value * -1;
      tbIntensity.Value = Convert.ToInt32(s.Value);
      intensity = 1f - (Convert.ToInt32(value) / 100f);
    }

    private void trackBarContrast_Scroll(object sender, EventArgs e)
    {
      nudContrast.Value = Convert.ToDecimal(((TrackBar)sender).Value);
    }

    private void numContrast_ValueChanged(object sender, EventArgs e)
    {
      var s = (NumericUpDown)sender;
      var value = s.Value * -1;
      tbContrast.Value = Convert.ToInt32(s.Value);
      contrast = 1f - (Convert.ToInt32(value) / 100f);
    }

    private void pictureBox1_DoubleClick(object sender, EventArgs e)
    {
      openFileDialog1.Filter = "Bildfiler (*.JPG;*.JPEG;*.PNG;*.TIFF;*.BMP)|*.JPG;*.JPEG;*.PNG;*.TIFF;*.BMP|Alla filer (*.*)|*.*";

      if (!string.IsNullOrEmpty(settings.lastPreviewDir)) {
        openFileDialog1.InitialDirectory = settings.lastPreviewDir;
      }

      var res = openFileDialog1.ShowDialog();
      if (res == System.Windows.Forms.DialogResult.OK) {
        btnPreview.Enabled = false;
        BackgroundWorker bw = new BackgroundWorker();
        bw.DoWork += new DoWorkEventHandler((xsender, xe) =>
        {
          if (pictureBox1.Image != null)
            pictureBox1.Image.Dispose();

          if (pictureBox2.Image != null)
            pictureBox2.Image.Dispose();

          if (previewImg != null)
            previewImg.Dispose();

          var fi = new FileInfo(openFileDialog1.FileNames[0]);
          settings.lastPreviewDir = fi.DirectoryName;
          settings.Save();

          Log.Debug("Load file: {0}\n", openFileDialog1.FileNames[0]);
          previewPath = openFileDialog1.FileNames[0];

          Bitmap tmp = new Bitmap(previewPath);
          int[] cst = Gfx.GetConstraints(tmp.Width, tmp.Height, PREVIEW_MAX_WIDTH, PREVIEW_MAX_WIDTH);
          previewImg = Gfx.ScaleImage(tmp, cst[0], cst[1]);

          Bitmap img = new Bitmap(previewImg);
          Bitmap img2 = new Bitmap(previewImg);

          tmp.Dispose();
        
          pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
          pictureBox1.Image = (System.Drawing.Image)img;

          pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
          pictureBox2.Image = (System.Drawing.Image)img2;
        });

        bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler((xsender, xe) =>
        {
          Log.Debug("Loaded Done\n");
          btnPreview.Enabled = true;
        });

        Log.Debug("Loading image...");

        bw.RunWorkerAsync();
      }
    }

    private void do_previewTransformation(object sender, EventArgs e)
    {
      Log.Debug("Do preview transformation!\n");
      if (previewImg != null) {
        Bitmap tmp = new Bitmap(previewImg);
        Bitmap img = Gfx.ApplyAttributes(tmp, iAttr);
        tmp.Dispose();
        pictureBox1.Image.Dispose();
        pictureBox1.Image = (System.Drawing.Image)img;
        iAttr.Dispose();
        iAttr = null;
      }
    }

    private void on_previewWorkerComplete(object sender, EventArgs e)
    {
      Log.Debug("Preview worker completed!\n");
      enableControls();
      statusText1.Text = "";
    }

    private void disableControls()
    {
      btnPreview.Enabled = false;

      tbContrast.Enabled = false;
      nudContrast.Enabled = false;

      tbSaturation.Enabled = false;
      nudSaturation.Enabled = false;
      
      tbIntensity.Enabled = false;
      nudIntensity.Enabled = false;
    }

    private void enableControls()
    {
      btnPreview.Enabled = true;

      tbContrast.Enabled = true;
      nudContrast.Enabled = true;

      tbSaturation.Enabled = true;
      nudSaturation.Enabled = true;

      tbIntensity.Enabled = true;
      nudIntensity.Enabled = true;
    }

    private void btnPreview_Click(object sender, EventArgs e)
    {
      applyPreview();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      settings.winMaximzed = this.WindowState == FormWindowState.Maximized;

      if (!settings.winMaximzed) {
        settings.winWidth = this.Width;
        settings.winHeight = this.Height;
        settings.winLeft = this.Left;
        settings.winTop = this.Top;
      }
      
      settings.Save();
    }

    private void quitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      Application.Exit();
    }

    private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var win = new SettingsWindow();
      win.ShowDialog(this);
      Log.Debug("Settings window closed. Update values\n");
      updateGlobalSettings();
    }

    private void btnSavePreset_Click(object sender, EventArgs e)
    {
      var w = new SavePreset();
      var res = w.ShowDialog(this);

      Log.Debug("Res: {0}\n", res);

      if (res == System.Windows.Forms.DialogResult.OK) {
        Log.Debug("Update preset list\n");
        loadPresets();
      }
    }
  }
}
