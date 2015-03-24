namespace ImgRescale
{
  partial class MainWindow
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnSrcDir = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnTargetDir = new System.Windows.Forms.Button();
      this.fbdSource = new System.Windows.Forms.FolderBrowserDialog();
      this.fbdTarget = new System.Windows.Forms.FolderBrowserDialog();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.statusText1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.statusText2 = new System.Windows.Forms.ToolStripStatusLabel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.trackBarContrast = new System.Windows.Forms.TrackBar();
      this.numIntensity = new System.Windows.Forms.NumericUpDown();
      this.trackBarIntensity = new System.Windows.Forms.TrackBar();
      this.numContrast = new System.Windows.Forms.NumericUpDown();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.trackBarHue2 = new System.Windows.Forms.TrackBar();
      this.trackBarHue = new System.Windows.Forms.TrackBar();
      this.numHue = new System.Windows.Forms.NumericUpDown();
      this.numHue2 = new System.Windows.Forms.NumericUpDown();
      this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
      this.btnRun = new System.Windows.Forms.Button();
      this.btnPreview = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.inställningarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.hjälpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numIntensity)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarIntensity)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numContrast)).BeginInit();
      this.groupBox3.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarHue2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numHue)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numHue2)).BeginInit();
      this.tableLayoutPanel5.SuspendLayout();
      this.groupBox5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.tableLayoutPanel6.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.btnSrcDir);
      this.groupBox1.Location = new System.Drawing.Point(4, 4);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox1.Size = new System.Drawing.Size(605, 65);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Källkatalog";
      // 
      // btnSrcDir
      // 
      this.btnSrcDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSrcDir.Location = new System.Drawing.Point(8, 21);
      this.btnSrcDir.Margin = new System.Windows.Forms.Padding(4);
      this.btnSrcDir.Name = "btnSrcDir";
      this.btnSrcDir.Size = new System.Drawing.Size(589, 37);
      this.btnSrcDir.TabIndex = 1;
      this.btnSrcDir.Text = "Välj...";
      this.btnSrcDir.UseVisualStyleBackColor = true;
      this.btnSrcDir.TextChanged += new System.EventHandler(this.source_dest_Change);
      this.btnSrcDir.Click += new System.EventHandler(this.btnSrcDir_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.btnTargetDir);
      this.groupBox2.Location = new System.Drawing.Point(617, 4);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox2.Size = new System.Drawing.Size(606, 65);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Målkatalog";
      // 
      // btnTargetDir
      // 
      this.btnTargetDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnTargetDir.Location = new System.Drawing.Point(8, 21);
      this.btnTargetDir.Margin = new System.Windows.Forms.Padding(4);
      this.btnTargetDir.Name = "btnTargetDir";
      this.btnTargetDir.Size = new System.Drawing.Size(590, 37);
      this.btnTargetDir.TabIndex = 2;
      this.btnTargetDir.Text = "Välj...";
      this.btnTargetDir.UseVisualStyleBackColor = true;
      this.btnTargetDir.Click += new System.EventHandler(this.button1_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText1,
            this.statusText2});
      this.statusStrip1.Location = new System.Drawing.Point(0, 861);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
      this.statusStrip1.Size = new System.Drawing.Size(1259, 22);
      this.statusStrip1.TabIndex = 2;
      // 
      // statusText1
      // 
      this.statusText1.Name = "statusText1";
      this.statusText1.Size = new System.Drawing.Size(0, 17);
      // 
      // statusText2
      // 
      this.statusText2.Name = "statusText2";
      this.statusText2.Size = new System.Drawing.Size(0, 17);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 38);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1227, 79);
      this.tableLayoutPanel1.TabIndex = 4;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.groupBox4, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 125);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(1227, 153);
      this.tableLayoutPanel2.TabIndex = 5;
      // 
      // groupBox4
      // 
      this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox4.Controls.Add(this.tableLayoutPanel4);
      this.groupBox4.Location = new System.Drawing.Point(617, 4);
      this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox4.Size = new System.Drawing.Size(606, 145);
      this.groupBox4.TabIndex = 1;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Intensitet/Kontrast";
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel4.ColumnCount = 2;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.85714F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.14286F));
      this.tableLayoutPanel4.Controls.Add(this.trackBarContrast, 0, 1);
      this.tableLayoutPanel4.Controls.Add(this.numIntensity, 1, 0);
      this.tableLayoutPanel4.Controls.Add(this.trackBarIntensity, 0, 0);
      this.tableLayoutPanel4.Controls.Add(this.numContrast, 1, 1);
      this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 25);
      this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 2;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(588, 113);
      this.tableLayoutPanel4.TabIndex = 1;
      // 
      // trackBarContrast
      // 
      this.trackBarContrast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBarContrast.Location = new System.Drawing.Point(4, 60);
      this.trackBarContrast.Margin = new System.Windows.Forms.Padding(4);
      this.trackBarContrast.Maximum = 100;
      this.trackBarContrast.Minimum = -100;
      this.trackBarContrast.Name = "trackBarContrast";
      this.trackBarContrast.Size = new System.Drawing.Size(479, 49);
      this.trackBarContrast.TabIndex = 2;
      this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
      // 
      // numIntensity
      // 
      this.numIntensity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.numIntensity.Location = new System.Drawing.Point(491, 4);
      this.numIntensity.Margin = new System.Windows.Forms.Padding(4);
      this.numIntensity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numIntensity.Name = "numIntensity";
      this.numIntensity.Size = new System.Drawing.Size(93, 22);
      this.numIntensity.TabIndex = 1;
      this.numIntensity.ValueChanged += new System.EventHandler(this.numIntensity_ValueChanged);
      // 
      // trackBarIntensity
      // 
      this.trackBarIntensity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBarIntensity.Location = new System.Drawing.Point(4, 4);
      this.trackBarIntensity.Margin = new System.Windows.Forms.Padding(4);
      this.trackBarIntensity.Maximum = 100;
      this.trackBarIntensity.Minimum = -100;
      this.trackBarIntensity.Name = "trackBarIntensity";
      this.trackBarIntensity.Size = new System.Drawing.Size(479, 48);
      this.trackBarIntensity.TabIndex = 0;
      this.trackBarIntensity.Scroll += new System.EventHandler(this.trackBarIntensity_Scroll);
      // 
      // numContrast
      // 
      this.numContrast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.numContrast.Location = new System.Drawing.Point(491, 60);
      this.numContrast.Margin = new System.Windows.Forms.Padding(4);
      this.numContrast.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numContrast.Name = "numContrast";
      this.numContrast.Size = new System.Drawing.Size(93, 22);
      this.numContrast.TabIndex = 3;
      this.numContrast.ValueChanged += new System.EventHandler(this.numContrast_ValueChanged);
      // 
      // groupBox3
      // 
      this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox3.Controls.Add(this.tableLayoutPanel3);
      this.groupBox3.Location = new System.Drawing.Point(4, 4);
      this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox3.Size = new System.Drawing.Size(605, 145);
      this.groupBox3.TabIndex = 0;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Nyans/Mättnad";
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.85714F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.14286F));
      this.tableLayoutPanel3.Controls.Add(this.trackBarHue2, 0, 1);
      this.tableLayoutPanel3.Controls.Add(this.trackBarHue, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.numHue, 1, 0);
      this.tableLayoutPanel3.Controls.Add(this.numHue2, 1, 1);
      this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 25);
      this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(588, 113);
      this.tableLayoutPanel3.TabIndex = 0;
      // 
      // trackBarHue2
      // 
      this.trackBarHue2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBarHue2.Location = new System.Drawing.Point(4, 60);
      this.trackBarHue2.Margin = new System.Windows.Forms.Padding(4);
      this.trackBarHue2.Maximum = 100;
      this.trackBarHue2.Minimum = -100;
      this.trackBarHue2.Name = "trackBarHue2";
      this.trackBarHue2.Size = new System.Drawing.Size(479, 49);
      this.trackBarHue2.TabIndex = 2;
      // 
      // trackBarHue
      // 
      this.trackBarHue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBarHue.Location = new System.Drawing.Point(4, 4);
      this.trackBarHue.Margin = new System.Windows.Forms.Padding(4);
      this.trackBarHue.Maximum = 100;
      this.trackBarHue.Minimum = -100;
      this.trackBarHue.Name = "trackBarHue";
      this.trackBarHue.Size = new System.Drawing.Size(479, 48);
      this.trackBarHue.TabIndex = 0;
      this.trackBarHue.Scroll += new System.EventHandler(this.trackBarHue_Scroll);
      // 
      // numHue
      // 
      this.numHue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.numHue.Location = new System.Drawing.Point(491, 4);
      this.numHue.Margin = new System.Windows.Forms.Padding(4);
      this.numHue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numHue.Name = "numHue";
      this.numHue.Size = new System.Drawing.Size(93, 22);
      this.numHue.TabIndex = 1;
      this.numHue.ValueChanged += new System.EventHandler(this.numHue_ValueChanged);
      // 
      // numHue2
      // 
      this.numHue2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.numHue2.Location = new System.Drawing.Point(491, 60);
      this.numHue2.Margin = new System.Windows.Forms.Padding(4);
      this.numHue2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numHue2.Name = "numHue2";
      this.numHue2.Size = new System.Drawing.Size(93, 22);
      this.numHue2.TabIndex = 3;
      // 
      // tableLayoutPanel5
      // 
      this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel5.ColumnCount = 1;
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.Controls.Add(this.groupBox5, 0, 0);
      this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
      this.tableLayoutPanel5.Location = new System.Drawing.Point(16, 286);
      this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
      this.tableLayoutPanel5.Name = "tableLayoutPanel5";
      this.tableLayoutPanel5.RowCount = 2;
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
      this.tableLayoutPanel5.Size = new System.Drawing.Size(1227, 565);
      this.tableLayoutPanel5.TabIndex = 6;
      // 
      // groupBox5
      // 
      this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox5.Controls.Add(this.splitContainer1);
      this.groupBox5.Location = new System.Drawing.Point(4, 4);
      this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox5.Size = new System.Drawing.Size(1219, 505);
      this.groupBox5.TabIndex = 1;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Förhandsgranskning";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer1.Location = new System.Drawing.Point(9, 23);
      this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.AutoScroll = true;
      this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
      this.splitContainer1.Size = new System.Drawing.Size(1200, 474);
      this.splitContainer1.SplitterDistance = 600;
      this.splitContainer1.SplitterWidth = 5;
      this.splitContainer1.TabIndex = 0;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.Location = new System.Drawing.Point(9, 4);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(580, 465);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
      // 
      // pictureBox2
      // 
      this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox2.Location = new System.Drawing.Point(9, 4);
      this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(579, 465);
      this.pictureBox2.TabIndex = 0;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
      // 
      // tableLayoutPanel6
      // 
      this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel6.ColumnCount = 3;
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
      this.tableLayoutPanel6.Controls.Add(this.btnRun, 0, 0);
      this.tableLayoutPanel6.Controls.Add(this.btnPreview, 2, 0);
      this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 517);
      this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
      this.tableLayoutPanel6.Name = "tableLayoutPanel6";
      this.tableLayoutPanel6.RowCount = 1;
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel6.Size = new System.Drawing.Size(1227, 48);
      this.tableLayoutPanel6.TabIndex = 2;
      // 
      // btnRun
      // 
      this.btnRun.Enabled = false;
      this.btnRun.Location = new System.Drawing.Point(4, 4);
      this.btnRun.Margin = new System.Windows.Forms.Padding(4);
      this.btnRun.Name = "btnRun";
      this.btnRun.Size = new System.Drawing.Size(100, 37);
      this.btnRun.TabIndex = 1;
      this.btnRun.Text = "Kör";
      this.btnRun.UseVisualStyleBackColor = true;
      this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
      // 
      // btnPreview
      // 
      this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnPreview.Enabled = false;
      this.btnPreview.Location = new System.Drawing.Point(1086, 4);
      this.btnPreview.Margin = new System.Windows.Forms.Padding(4);
      this.btnPreview.Name = "btnPreview";
      this.btnPreview.Size = new System.Drawing.Size(137, 37);
      this.btnPreview.TabIndex = 2;
      this.btnPreview.Text = "Förhandsgranska";
      this.btnPreview.UseVisualStyleBackColor = true;
      this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.inställningarToolStripMenuItem,
            this.hjälpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1259, 28);
      this.menuStrip1.TabIndex = 7;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avslutaToolStripMenuItem});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 24);
      this.toolStripMenuItem1.Text = "&Arkiv";
      // 
      // avslutaToolStripMenuItem
      // 
      this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
      this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
      this.avslutaToolStripMenuItem.Text = "Avsluta";
      this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
      // 
      // inställningarToolStripMenuItem
      // 
      this.inställningarToolStripMenuItem.Name = "inställningarToolStripMenuItem";
      this.inställningarToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
      this.inställningarToolStripMenuItem.Text = "&Inställningar";
      this.inställningarToolStripMenuItem.Click += new System.EventHandler(this.inställningarToolStripMenuItem_Click);
      // 
      // hjälpToolStripMenuItem
      // 
      this.hjälpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omToolStripMenuItem});
      this.hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
      this.hjälpToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
      this.hjälpToolStripMenuItem.Text = "Hj&älp";
      // 
      // omToolStripMenuItem
      // 
      this.omToolStripMenuItem.Name = "omToolStripMenuItem";
      this.omToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
      this.omToolStripMenuItem.Text = "Om";
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1259, 883);
      this.Controls.Add(this.tableLayoutPanel5);
      this.Controls.Add(this.tableLayoutPanel2);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "MainWindow";
      this.Text = "Simple Image Manipulator";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numIntensity)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarIntensity)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numContrast)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarHue2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numHue)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numHue2)).EndInit();
      this.tableLayoutPanel5.ResumeLayout(false);
      this.groupBox5.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.tableLayoutPanel6.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnSrcDir;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnTargetDir;
    private System.Windows.Forms.FolderBrowserDialog fbdSource;
    private System.Windows.Forms.FolderBrowserDialog fbdTarget;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel statusText1;
    private System.Windows.Forms.ToolStripStatusLabel statusText2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.TrackBar trackBarHue;
    private System.Windows.Forms.NumericUpDown numHue;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.NumericUpDown numIntensity;
    private System.Windows.Forms.TrackBar trackBarIntensity;
    private System.Windows.Forms.TrackBar trackBarHue2;
    private System.Windows.Forms.NumericUpDown numHue2;
    private System.Windows.Forms.TrackBar trackBarContrast;
    private System.Windows.Forms.NumericUpDown numContrast;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.Button btnRun;
    private System.Windows.Forms.Button btnPreview;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hjälpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem inställningarToolStripMenuItem;
  }
}

