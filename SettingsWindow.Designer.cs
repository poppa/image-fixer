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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.cbConfig = new System.Windows.Forms.ComboBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.nudMaxWidth = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.nudMaxHeight = new System.Windows.Forms.NumericUpDown();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.btnOk = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxWidth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxHeight)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tableLayoutPanel1);
      this.groupBox1.Location = new System.Drawing.Point(10, 11);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
      this.groupBox1.Size = new System.Drawing.Size(484, 51);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Aktuella inställningar";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.Controls.Add(this.cbConfig, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 18);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(475, 27);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // cbConfig
      // 
      this.cbConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.cbConfig.FormattingEnabled = true;
      this.cbConfig.ItemHeight = 13;
      this.cbConfig.Location = new System.Drawing.Point(2, 3);
      this.cbConfig.Margin = new System.Windows.Forms.Padding(2);
      this.cbConfig.Name = "cbConfig";
      this.cbConfig.Size = new System.Drawing.Size(281, 21);
      this.cbConfig.TabIndex = 0;
      this.cbConfig.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      this.cbConfig.SelectedValueChanged += new System.EventHandler(this.cbConfig_SelectedValueChanged);
      this.cbConfig.TextChanged += new System.EventHandler(this.cbConfig_TextChanged);
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSave.Enabled = false;
      this.btnSave.Location = new System.Drawing.Point(287, 2);
      this.btnSave.Margin = new System.Windows.Forms.Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(91, 23);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Spara";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDelete.Enabled = false;
      this.btnDelete.Location = new System.Drawing.Point(382, 2);
      this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(91, 23);
      this.btnDelete.TabIndex = 2;
      this.btnDelete.Text = "Ta bort";
      this.btnDelete.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.richTextBox1);
      this.groupBox2.Controls.Add(this.nudMaxHeight);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Controls.Add(this.nudMaxWidth);
      this.groupBox2.Location = new System.Drawing.Point(10, 68);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(484, 181);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Globala inställningar";
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
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(91, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Maxbredd på bild:";
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
      // btnOk
      // 
      this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnOk.Location = new System.Drawing.Point(338, 256);
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
      this.btnCancel.Location = new System.Drawing.Point(419, 256);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 33);
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Avbryt";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // SettingsWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(503, 295);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOk);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(519, 333);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(519, 333);
      this.Name = "SettingsWindow";
      this.ShowIcon = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Inställningar";
      this.TopMost = true;
      this.Shown += new System.EventHandler(this.SettingsWindow_Shown);
      this.groupBox1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxWidth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxHeight)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.ComboBox cbConfig;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown nudMaxWidth;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown nudMaxHeight;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Button btnCancel;
  }
}