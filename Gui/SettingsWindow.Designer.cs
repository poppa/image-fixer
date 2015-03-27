namespace ImgRescale
{
  partial class SettingsWindow
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
      this.components = new System.ComponentModel.Container();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.cbPresets = new System.Windows.Forms.ComboBox();
      this.btnEditPreset = new System.Windows.Forms.Button();
      this.btnDeletePreset = new System.Windows.Forms.Button();
      this.btnOk = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.nudJpegQuality = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.nudMaxHeight = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.nudMaxWidth = new System.Windows.Forms.NumericUpDown();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.cbPresetsBinding = new System.Windows.Forms.BindingSource(this.components);
      this.groupBox1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudJpegQuality)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxWidth)).BeginInit();
      this.flowLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cbPresetsBinding)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tableLayoutPanel1);
      this.groupBox1.Location = new System.Drawing.Point(2, 2);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
      this.groupBox1.Size = new System.Drawing.Size(480, 51);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Förinställningar";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.Controls.Add(this.cbPresets, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnEditPreset, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnDeletePreset, 2, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 18);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(471, 27);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // cbPresets
      // 
      this.cbPresets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.cbPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbPresets.FormattingEnabled = true;
      this.cbPresets.ItemHeight = 13;
      this.cbPresets.Location = new System.Drawing.Point(2, 3);
      this.cbPresets.Margin = new System.Windows.Forms.Padding(2);
      this.cbPresets.Name = "cbPresets";
      this.cbPresets.Size = new System.Drawing.Size(278, 21);
      this.cbPresets.TabIndex = 0;
      this.cbPresets.SelectedIndexChanged += new System.EventHandler(this.cbPresets_SelectedIndexChanged);
      // 
      // btnEditPreset
      // 
      this.btnEditPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.btnEditPreset.Enabled = false;
      this.btnEditPreset.Location = new System.Drawing.Point(284, 2);
      this.btnEditPreset.Margin = new System.Windows.Forms.Padding(2);
      this.btnEditPreset.Name = "btnEditPreset";
      this.btnEditPreset.Size = new System.Drawing.Size(90, 23);
      this.btnEditPreset.TabIndex = 1;
      this.btnEditPreset.Text = "Redigera";
      this.btnEditPreset.UseVisualStyleBackColor = true;
      this.btnEditPreset.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnDeletePreset
      // 
      this.btnDeletePreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDeletePreset.Enabled = false;
      this.btnDeletePreset.Location = new System.Drawing.Point(378, 2);
      this.btnDeletePreset.Margin = new System.Windows.Forms.Padding(2);
      this.btnDeletePreset.Name = "btnDeletePreset";
      this.btnDeletePreset.Size = new System.Drawing.Size(91, 23);
      this.btnDeletePreset.TabIndex = 2;
      this.btnDeletePreset.Text = "Ta bort";
      this.btnDeletePreset.UseVisualStyleBackColor = true;
      // 
      // btnOk
      // 
      this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnOk.Location = new System.Drawing.Point(328, 3);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(75, 33);
      this.btnOk.TabIndex = 2;
      this.btnOk.Text = "Ok";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(409, 3);
      this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 33);
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Avbryt";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 1;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 2);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 7);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 3;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.89655F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.10345F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(484, 273);
      this.tableLayoutPanel2.TabIndex = 4;
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.nudJpegQuality);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.richTextBox1);
      this.groupBox2.Controls.Add(this.nudMaxHeight);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Controls.Add(this.nudMaxWidth);
      this.groupBox2.Location = new System.Drawing.Point(3, 78);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(478, 154);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Globala inställningar";
      // 
      // nudJpegQuality
      // 
      this.nudJpegQuality.Location = new System.Drawing.Point(108, 82);
      this.nudJpegQuality.Margin = new System.Windows.Forms.Padding(2);
      this.nudJpegQuality.Name = "nudJpegQuality";
      this.nudJpegQuality.Size = new System.Drawing.Size(120, 20);
      this.nudJpegQuality.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 84);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(74, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "JPEG-kvalitet:";
      // 
      // richTextBox1
      // 
      this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
      this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.richTextBox1.Enabled = false;
      this.richTextBox1.Location = new System.Drawing.Point(249, 29);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(229, 46);
      this.richTextBox1.TabIndex = 4;
      this.richTextBox1.Text = "Dessa värden bestämmer maxbredd och -höjd på genererade bilder. Om värdena är 0 k" +
    "ommer bilderna behålla sina originalstorlekar.";
      // 
      // nudMaxHeight
      // 
      this.nudMaxHeight.Location = new System.Drawing.Point(108, 55);
      this.nudMaxHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.nudMaxHeight.Name = "nudMaxHeight";
      this.nudMaxHeight.Size = new System.Drawing.Size(120, 20);
      this.nudMaxHeight.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(7, 58);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(84, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Maxhöjd på bild:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(91, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Maxbredd på bild:";
      // 
      // nudMaxWidth
      // 
      this.nudMaxWidth.Location = new System.Drawing.Point(108, 29);
      this.nudMaxWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.nudMaxWidth.Name = "nudMaxWidth";
      this.nudMaxWidth.Size = new System.Drawing.Size(120, 20);
      this.nudMaxWidth.TabIndex = 0;
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Controls.Add(this.btnCancel);
      this.flowLayoutPanel1.Controls.Add(this.btnOk);
      this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 235);
      this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(484, 37);
      this.flowLayoutPanel1.TabIndex = 3;
      // 
      // SettingsWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(502, 293);
      this.Controls.Add(this.tableLayoutPanel2);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(518, 331);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(518, 331);
      this.Name = "SettingsWindow";
      this.ShowIcon = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Inställningar";
      this.TopMost = true;
      this.Shown += new System.EventHandler(this.SettingsWindow_Shown);
      this.groupBox1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudJpegQuality)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxWidth)).EndInit();
      this.flowLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cbPresetsBinding)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.ComboBox cbPresets;
    private System.Windows.Forms.Button btnEditPreset;
    private System.Windows.Forms.Button btnDeletePreset;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.NumericUpDown nudMaxHeight;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown nudMaxWidth;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.NumericUpDown nudJpegQuality;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.BindingSource cbPresetsBinding;
  }
}