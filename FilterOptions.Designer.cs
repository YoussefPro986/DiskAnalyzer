namespace DiskAnalyzer
{
    partial class FilterOptions
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterOptions));
            this.textBoxExclude = new System.Windows.Forms.TextBox();
            this.textBoxInclude = new System.Windows.Forms.TextBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.comboBoxOwner = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBytes = new System.Windows.Forms.ComboBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonExclude = new System.Windows.Forms.RadioButton();
            this.radioButtonInclude = new System.Windows.Forms.RadioButton();
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkBoxZeroSize = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.checkBoxReAnalyze = new System.Windows.Forms.CheckBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.checkBoxExportToExcel = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxExclude
            // 
            this.textBoxExclude.Location = new System.Drawing.Point(71, 45);
            this.textBoxExclude.Name = "textBoxExclude";
            this.textBoxExclude.Size = new System.Drawing.Size(349, 20);
            this.textBoxExclude.TabIndex = 1;
            // 
            // textBoxInclude
            // 
            this.textBoxInclude.Location = new System.Drawing.Point(71, 19);
            this.textBoxInclude.Name = "textBoxInclude";
            this.textBoxInclude.Size = new System.Drawing.Size(349, 20);
            this.textBoxInclude.TabIndex = 3;
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.Enabled = false;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "Greater Than Equla To",
            "Less Than Equal To",
            "Greater Than",
            "Less Than",
            "Equal To",
            "Not Equal To",
            "",
            "",
            ""});
            this.comboBoxSize.Location = new System.Drawing.Point(83, 12);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSize.TabIndex = 5;
            // 
            // comboBoxOwner
            // 
            this.comboBoxOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOwner.Enabled = false;
            this.comboBoxOwner.FormattingEnabled = true;
            this.comboBoxOwner.Items.AddRange(new object[] {
            "All"});
            this.comboBoxOwner.Location = new System.Drawing.Point(85, 145);
            this.comboBoxOwner.Name = "comboBoxOwner";
            this.comboBoxOwner.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOwner.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(41, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Owner:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Include and Exclude Files are comma seperate list of file exenstion. Example: .ex" +
                "e, .avi";
            // 
            // comboBoxBytes
            // 
            this.comboBoxBytes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBytes.FormattingEnabled = true;
            this.comboBoxBytes.Items.AddRange(new object[] {
            "By",
            "KB",
            "MB",
            "GB"});
            this.comboBoxBytes.Location = new System.Drawing.Point(383, 12);
            this.comboBoxBytes.Name = "comboBoxBytes";
            this.comboBoxBytes.Size = new System.Drawing.Size(56, 21);
            this.comboBoxBytes.TabIndex = 12;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(213, 12);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(164, 20);
            this.textBoxSize.TabIndex = 13;
            this.textBoxSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSize_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonExclude);
            this.groupBox1.Controls.Add(this.radioButtonInclude);
            this.groupBox1.Controls.Add(this.textBoxInclude);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxExclude);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // radioButtonExclude
            // 
            this.radioButtonExclude.AutoSize = true;
            this.radioButtonExclude.Location = new System.Drawing.Point(6, 46);
            this.radioButtonExclude.Name = "radioButtonExclude";
            this.radioButtonExclude.Size = new System.Drawing.Size(63, 17);
            this.radioButtonExclude.TabIndex = 4;
            this.radioButtonExclude.Text = "Exclude";
            this.radioButtonExclude.UseVisualStyleBackColor = true;
            // 
            // radioButtonInclude
            // 
            this.radioButtonInclude.AutoSize = true;
            this.radioButtonInclude.Checked = true;
            this.radioButtonInclude.Location = new System.Drawing.Point(6, 19);
            this.radioButtonInclude.Name = "radioButtonInclude";
            this.radioButtonInclude.Size = new System.Drawing.Size(60, 17);
            this.radioButtonInclude.TabIndex = 0;
            this.radioButtonInclude.TabStop = true;
            this.radioButtonInclude.Text = "Include";
            this.radioButtonInclude.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(360, 252);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(56, 23);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear All";
            this.buttonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // checkBoxZeroSize
            // 
            this.checkBoxZeroSize.AutoSize = true;
            this.checkBoxZeroSize.Location = new System.Drawing.Point(83, 175);
            this.checkBoxZeroSize.Name = "checkBoxZeroSize";
            this.checkBoxZeroSize.Size = new System.Drawing.Size(221, 17);
            this.checkBoxZeroSize.TabIndex = 16;
            this.checkBoxZeroSize.Text = "Show Directories and Files of size 0 bytes";
            this.checkBoxZeroSize.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 232);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.checkBoxZeroSize);
            this.tabPage1.Controls.Add(this.comboBoxSize);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.comboBoxOwner);
            this.tabPage1.Controls.Add(this.textBoxSize);
            this.tabPage1.Controls.Add(this.comboBoxBytes);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(460, 205);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filter Options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Size:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxExportToExcel);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(460, 205);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Others";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Filter2HS.png");
            this.imageList1.Images.SetKeyName(1, "OptionsHS.png");
            // 
            // checkBoxReAnalyze
            // 
            this.checkBoxReAnalyze.AutoSize = true;
            this.checkBoxReAnalyze.Checked = true;
            this.checkBoxReAnalyze.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxReAnalyze.Location = new System.Drawing.Point(12, 256);
            this.checkBoxReAnalyze.Name = "checkBoxReAnalyze";
            this.checkBoxReAnalyze.Size = new System.Drawing.Size(189, 17);
            this.checkBoxReAnalyze.TabIndex = 18;
            this.checkBoxReAnalyze.Text = "Re-analyze on save of the Options";
            this.checkBoxReAnalyze.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Image = global::DiskAnalyzer.Properties.Resources.saveHS;
            this.buttonApply.Location = new System.Drawing.Point(422, 252);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(56, 23);
            this.buttonApply.TabIndex = 9;
            this.buttonApply.Text = "Save";
            this.buttonApply.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // checkBoxExportToExcel
            // 
            this.checkBoxExportToExcel.AutoSize = true;
            this.checkBoxExportToExcel.Checked = true;
            this.checkBoxExportToExcel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExportToExcel.Location = new System.Drawing.Point(18, 18);
            this.checkBoxExportToExcel.Name = "checkBoxExportToExcel";
            this.checkBoxExportToExcel.Size = new System.Drawing.Size(260, 17);
            this.checkBoxExportToExcel.TabIndex = 19;
            this.checkBoxExportToExcel.Text = "Open Excel file after Export to Excel is completed.";
            this.checkBoxExportToExcel.UseVisualStyleBackColor = true;
            // 
            // FilterOptions
            // 
            this.AcceptButton = this.buttonApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 287);
            this.Controls.Add(this.checkBoxReAnalyze);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterOptions";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FilterOptions_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilterOptions_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxExclude;
        private System.Windows.Forms.TextBox textBoxInclude;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.ComboBox comboBoxOwner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxBytes;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonExclude;
        private System.Windows.Forms.RadioButton radioButtonInclude;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox checkBoxZeroSize;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxReAnalyze;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox checkBoxExportToExcel;
    }
}