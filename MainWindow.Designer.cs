﻿namespace ImgRescale
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
      this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
      this.tbSaturation = new System.Windows.Forms.TrackBar();
      this.tbContrast = new System.Windows.Forms.TrackBar();
      this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
      this.label2 = new System.Windows.Forms.Label();
      this.nudIntensity = new System.Windows.Forms.NumericUpDown();
      this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.nudSaturation = new System.Windows.Forms.NumericUpDown();
      this.tbIntensity = new System.Windows.Forms.TrackBar();
      this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
      this.label3 = new System.Windows.Forms.Label();
      this.nudContrast = new System.Windows.Forms.NumericUpDown();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel5.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.tableLayoutPanel6.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.tableLayoutPanel7.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).BeginInit();
      this.tableLayoutPanel9.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).BeginInit();
      this.tableLayoutPanel8.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudSaturation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbIntensity)).BeginInit();
      this.tableLayoutPanel10.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudContrast)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.btnSrcDir);
      this.groupBox1.Location = new System.Drawing.Point(0, 4);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox1.Size = new System.Drawing.Size(609, 65);
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
      this.btnSrcDir.Size = new System.Drawing.Size(593, 37);
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
      this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox2.Size = new System.Drawing.Size(610, 65);
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
      this.btnTargetDir.Size = new System.Drawing.Size(594, 37);
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
      this.statusStrip1.Location = new System.Drawing.Point(0, 860);
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
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1227, 79);
      this.tableLayoutPanel1.TabIndex = 4;
      // 
      // tableLayoutPanel5
      // 
      this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel5.ColumnCount = 1;
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.Controls.Add(this.groupBox3, 0, 0);
      this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
      this.tableLayoutPanel5.Location = new System.Drawing.Point(16, 261);
      this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0, 4, 0, 10);
      this.tableLayoutPanel5.Name = "tableLayoutPanel5";
      this.tableLayoutPanel5.RowCount = 2;
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
      this.tableLayoutPanel5.Size = new System.Drawing.Size(1227, 590);
      this.tableLayoutPanel5.TabIndex = 6;
      // 
      // groupBox3
      // 
      this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox3.Controls.Add(this.tableLayoutPanel2);
      this.groupBox3.Location = new System.Drawing.Point(0, 3);
      this.groupBox3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
      this.groupBox3.MinimumSize = new System.Drawing.Size(0, 300);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(1227, 532);
      this.groupBox3.TabIndex = 4;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Förhandsgranskning";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 21);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(1221, 505);
      this.tableLayoutPanel2.TabIndex = 4;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox2.Location = new System.Drawing.Point(614, 4);
      this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(603, 497);
      this.pictureBox2.TabIndex = 2;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.Location = new System.Drawing.Point(4, 4);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(602, 497);
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
      // 
      // tableLayoutPanel6
      // 
      this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel6.ColumnCount = 3;
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
      this.tableLayoutPanel6.Controls.Add(this.btnRun, 0, 0);
      this.tableLayoutPanel6.Controls.Add(this.btnPreview, 2, 0);
      this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 542);
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
      this.btnRun.Location = new System.Drawing.Point(0, 4);
      this.btnRun.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
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
      this.btnPreview.Location = new System.Drawing.Point(967, 4);
      this.btnPreview.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
      this.btnPreview.Name = "btnPreview";
      this.btnPreview.Size = new System.Drawing.Size(260, 37);
      this.btnPreview.TabIndex = 2;
      this.btnPreview.Text = "Förhandsgranska inställningarna";
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
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
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
      this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
      // 
      // inställningarToolStripMenuItem
      // 
      this.inställningarToolStripMenuItem.Name = "inställningarToolStripMenuItem";
      this.inställningarToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
      this.inställningarToolStripMenuItem.Text = "&Inställningar";
      this.inställningarToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
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
      // groupBox6
      // 
      this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox6.Controls.Add(this.tableLayoutPanel7);
      this.groupBox6.Location = new System.Drawing.Point(16, 124);
      this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox6.Size = new System.Drawing.Size(1227, 129);
      this.groupBox6.TabIndex = 8;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Inställningar";
      // 
      // tableLayoutPanel7
      // 
      this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel7.ColumnCount = 3;
      this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel7.Controls.Add(this.tbSaturation, 0, 1);
      this.tableLayoutPanel7.Controls.Add(this.tbContrast, 0, 1);
      this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 1, 0);
      this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
      this.tableLayoutPanel7.Controls.Add(this.tbIntensity, 0, 1);
      this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel10, 2, 0);
      this.tableLayoutPanel7.Location = new System.Drawing.Point(12, 25);
      this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
      this.tableLayoutPanel7.Name = "tableLayoutPanel7";
      this.tableLayoutPanel7.RowCount = 2;
      this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
      this.tableLayoutPanel7.Size = new System.Drawing.Size(1211, 96);
      this.tableLayoutPanel7.TabIndex = 0;
      // 
      // tbSaturation
      // 
      this.tbSaturation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbSaturation.Location = new System.Drawing.Point(4, 42);
      this.tbSaturation.Margin = new System.Windows.Forms.Padding(4);
      this.tbSaturation.Maximum = 100;
      this.tbSaturation.Minimum = -100;
      this.tbSaturation.Name = "tbSaturation";
      this.tbSaturation.Size = new System.Drawing.Size(395, 50);
      this.tbSaturation.TabIndex = 5;
      this.tbSaturation.TickFrequency = 10;
      this.tbSaturation.Scroll += new System.EventHandler(this.trackBarSaturation_Scroll);
      // 
      // tbContrast
      // 
      this.tbContrast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbContrast.Location = new System.Drawing.Point(810, 42);
      this.tbContrast.Margin = new System.Windows.Forms.Padding(4);
      this.tbContrast.Maximum = 100;
      this.tbContrast.Minimum = -100;
      this.tbContrast.Name = "tbContrast";
      this.tbContrast.Size = new System.Drawing.Size(397, 50);
      this.tbContrast.TabIndex = 3;
      this.tbContrast.TickFrequency = 10;
      this.tbContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
      // 
      // tableLayoutPanel9
      // 
      this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel9.ColumnCount = 2;
      this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel9.Controls.Add(this.label2, 0, 0);
      this.tableLayoutPanel9.Controls.Add(this.nudIntensity, 1, 0);
      this.tableLayoutPanel9.Location = new System.Drawing.Point(407, 4);
      this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(4);
      this.tableLayoutPanel9.Name = "tableLayoutPanel9";
      this.tableLayoutPanel9.RowCount = 1;
      this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel9.Size = new System.Drawing.Size(395, 30);
      this.tableLayoutPanel9.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(4, 6);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(65, 17);
      this.label2.TabIndex = 0;
      this.label2.Text = "Intensitet";
      // 
      // nudIntensity
      // 
      this.nudIntensity.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.nudIntensity.Location = new System.Drawing.Point(315, 4);
      this.nudIntensity.Margin = new System.Windows.Forms.Padding(4, 4, 12, 4);
      this.nudIntensity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.nudIntensity.Name = "nudIntensity";
      this.nudIntensity.Size = new System.Drawing.Size(68, 22);
      this.nudIntensity.TabIndex = 1;
      this.nudIntensity.ValueChanged += new System.EventHandler(this.numIntensity_ValueChanged);
      // 
      // tableLayoutPanel8
      // 
      this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel8.ColumnCount = 2;
      this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel8.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel8.Controls.Add(this.nudSaturation, 1, 0);
      this.tableLayoutPanel8.Location = new System.Drawing.Point(4, 4);
      this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
      this.tableLayoutPanel8.Name = "tableLayoutPanel8";
      this.tableLayoutPanel8.RowCount = 1;
      this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel8.Size = new System.Drawing.Size(395, 30);
      this.tableLayoutPanel8.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(4, 6);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Mättnad";
      // 
      // nudSaturation
      // 
      this.nudSaturation.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.nudSaturation.Location = new System.Drawing.Point(315, 4);
      this.nudSaturation.Margin = new System.Windows.Forms.Padding(4, 4, 12, 4);
      this.nudSaturation.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.nudSaturation.Name = "nudSaturation";
      this.nudSaturation.Size = new System.Drawing.Size(68, 22);
      this.nudSaturation.TabIndex = 1;
      this.nudSaturation.ValueChanged += new System.EventHandler(this.numSaturation_ValueChanged);
      // 
      // tbIntensity
      // 
      this.tbIntensity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbIntensity.Location = new System.Drawing.Point(407, 42);
      this.tbIntensity.Margin = new System.Windows.Forms.Padding(4);
      this.tbIntensity.Maximum = 100;
      this.tbIntensity.Minimum = -100;
      this.tbIntensity.Name = "tbIntensity";
      this.tbIntensity.Size = new System.Drawing.Size(395, 50);
      this.tbIntensity.TabIndex = 1;
      this.tbIntensity.TickFrequency = 10;
      this.tbIntensity.Scroll += new System.EventHandler(this.trackBarIntensity_Scroll);
      // 
      // tableLayoutPanel10
      // 
      this.tableLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel10.ColumnCount = 2;
      this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel10.Controls.Add(this.label3, 0, 0);
      this.tableLayoutPanel10.Controls.Add(this.nudContrast, 1, 0);
      this.tableLayoutPanel10.Location = new System.Drawing.Point(810, 4);
      this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(4);
      this.tableLayoutPanel10.Name = "tableLayoutPanel10";
      this.tableLayoutPanel10.RowCount = 1;
      this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel10.Size = new System.Drawing.Size(397, 30);
      this.tableLayoutPanel10.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(4, 6);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(61, 17);
      this.label3.TabIndex = 0;
      this.label3.Text = "Kontrast";
      // 
      // nudContrast
      // 
      this.nudContrast.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.nudContrast.Location = new System.Drawing.Point(317, 4);
      this.nudContrast.Margin = new System.Windows.Forms.Padding(4, 4, 12, 4);
      this.nudContrast.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.nudContrast.Name = "nudContrast";
      this.nudContrast.Size = new System.Drawing.Size(68, 22);
      this.nudContrast.TabIndex = 1;
      this.nudContrast.ValueChanged += new System.EventHandler(this.numContrast_ValueChanged);
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.ClientSize = new System.Drawing.Size(1259, 882);
      this.Controls.Add(this.groupBox6);
      this.Controls.Add(this.tableLayoutPanel5);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MinimumSize = new System.Drawing.Size(600, 400);
      this.Name = "MainWindow";
      this.Text = "Simple Image Manipulator";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel5.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.tableLayoutPanel6.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.tableLayoutPanel7.ResumeLayout(false);
      this.tableLayoutPanel7.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).EndInit();
      this.tableLayoutPanel9.ResumeLayout(false);
      this.tableLayoutPanel9.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).EndInit();
      this.tableLayoutPanel8.ResumeLayout(false);
      this.tableLayoutPanel8.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudSaturation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbIntensity)).EndInit();
      this.tableLayoutPanel10.ResumeLayout(false);
      this.tableLayoutPanel10.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudContrast)).EndInit();
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
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.Button btnRun;
    private System.Windows.Forms.Button btnPreview;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hjälpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem inställningarToolStripMenuItem;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown nudSaturation;
    private System.Windows.Forms.TrackBar tbIntensity;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown nudIntensity;
    private System.Windows.Forms.TrackBar tbSaturation;
    private System.Windows.Forms.TrackBar tbContrast;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown nudContrast;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

