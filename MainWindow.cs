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
    string previewPath;

    private BackgroundWorker worker = new BackgroundWorker();
    private BackgroundWorker previewWorker = new BackgroundWorker();
    Properties.Settings settings = Properties.Settings.Default;

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
    }

    public Dictionary<string,object> GetSettings()
    {
      return new Dictionary<string, object>() {
        { "saturation", this.numHue.Value },
        { "contrast", this.numContrast.Value },
        { "brightness", this.numIntensity.Value },
        { "lastSourceDir", this.btnSrcDir.Text },
        { "lastTargetDir", this.btnTargetDir.Text },
        { "previewPath", this.previewPath }
      };
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      statusText1.Text = "Inväntar val av källkatalog och destinationkatalog";
      //statusText2.Text = "Logfil: " + Log.Path;
      Log.File("\n\n-------------------\nStarting application dude...\n");

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

      Image.MAX_WIDTH = defaultWidth;
      Image.MAX_HEIGHT = defaultHeight;
      Dir.recurse = defaultRecurse;
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

      Log.Debug("Got {0} images in {1} dirs\n", Image.instances, Dir.instances);

      if (Image.instances > 0) {
        statusText2.Text = Image.instances + " bilder att behandla";
        id.run();
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


      float[][] mtx = {
                        new float[]{ a, b, c, 0, 0 },
                        new float[]{ d, e, f, 0, 0 },
                        new float[]{ g, h, i, 0, 0 },
                        new float[]{ 0, 0, 0, 1, 0 },
                        new float[]{ adjBri, adjBri, adjBri, 0, 1 }
                      };

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
        Log.Debug("Saturation is: {0}\n", saturation);

        if (saturation != 1f || intensity != 1f || saturation != 1f) {
          setMatrix();
          Image.Attributes = iAttr;
        }

        statusText2.Text = "Samlar bilder...";

        Indexer.TargetBaseDir = new System.IO.FileInfo(btnTargetDir.Text);
        Indexer.SourceBaseDir = new System.IO.FileInfo(btnSrcDir.Text);

        int count = 0;
        Indexer.OnImageProcessed += () => {
          count += 1;
          statusText2.Text = String.Format("Bearbetar bild {0}/{1}", count, Image.instances);
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
        if (previewPath != null) {
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

    private void trackBarHue_Scroll(object sender, EventArgs e)
    {
      var s = (TrackBar)sender;
      saturation = 1f - (s.Value / 100f);

      Log.Debug("Saturation: {0}\n", saturation);

      numHue.Value = Convert.ToDecimal(s.Value);
    }

    private void numHue_ValueChanged(object sender, EventArgs e)
    {
      var s = (NumericUpDown)sender;
      var value = s.Value;

      trackBarHue.Value = Convert.ToInt32(value);

      saturation = 1f - (Convert.ToInt32(value) / 100f);
    }

    private void trackBarIntensity_Scroll(object sender, EventArgs e)
    {
      var s = (TrackBar)sender;
      intensity = 1f - (s.Value / 100f);

      Log.Debug("Intensity: {0}\n", intensity);

      numIntensity.Value = Convert.ToDecimal(s.Value);
    }

    private void numIntensity_ValueChanged(object sender, EventArgs e)
    {
      var s = (NumericUpDown)sender;
      var value = s.Value;
      trackBarIntensity.Value = Convert.ToInt32(value);
      intensity = 1f - (Convert.ToInt32(value) / 100f);
    }

    private void trackBarContrast_Scroll(object sender, EventArgs e)
    {
      var s = (TrackBar)sender;
      contrast = 1f - (s.Value / 100f);

      Log.Debug("Contrast: {0}\n", contrast);

      numContrast.Value = Convert.ToDecimal(s.Value);
    }

    private void numContrast_ValueChanged(object sender, EventArgs e)
    {
      var s = (NumericUpDown)sender;
      var value = s.Value;
      trackBarContrast.Value = Convert.ToInt32(value);
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
        if (pictureBox1.Image != null)
          pictureBox1.Image.Dispose();

        if (pictureBox2.Image != null)
          pictureBox2.Image.Dispose();

        var fi = new FileInfo(openFileDialog1.FileNames[0]);
        settings.lastPreviewDir = fi.DirectoryName;
        settings.Save();

        Log.Debug("Load file: {0}\n", openFileDialog1.FileNames[0]);
        previewPath = openFileDialog1.FileNames[0];

        Bitmap img = new Bitmap(openFileDialog1.FileNames[0]);
        Bitmap img2 = new Bitmap(openFileDialog1.FileNames[0]);
        
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.Image = (System.Drawing.Image)img;

        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.Image = (System.Drawing.Image)img2;

        btnPreview.Enabled = true;
      }
    }

    private void do_previewTransformation(object sender, EventArgs e)
    {
      Log.Debug("Do preview transformation!\n");
      Bitmap tmp = new Bitmap(previewPath);
      Bitmap img = Gfx.ApplyAttributes(tmp, iAttr);
      tmp.Dispose();
      pictureBox1.Image.Dispose();
      pictureBox1.Image = (System.Drawing.Image)img;
      iAttr.Dispose();
      iAttr = null;
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
      trackBarContrast.Enabled = false;
      numContrast.Enabled = false;

      trackBarHue.Enabled = false;
      numHue.Enabled = false;
      
      trackBarHue2.Enabled = false;
      numHue2.Enabled = false;
      
      trackBarIntensity.Enabled = false;
      numIntensity.Enabled = false;
    }

    private void enableControls()
    {
      btnPreview.Enabled = true;

      trackBarContrast.Enabled = true;
      numContrast.Enabled = true;

      trackBarHue.Enabled = true;
      numHue.Enabled = true;

      trackBarHue2.Enabled = true;
      numHue2.Enabled = true;

      trackBarIntensity.Enabled = true;
      numIntensity.Enabled = true;
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

    private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      Application.Exit();
    }

    private void inställningarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var win = new SettingsWindow();
      win.ShowDialog(this);
    }
  }
}
