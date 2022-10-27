namespace DiskAnalyzer
{
    partial class CalculateDirectorySize
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
            this.label1 = new System.Windows.Forms.Label();
            this.pbOverall = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.bwDirAnalyzer = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTopLevel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Wait!! Reteriving Directory Information.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbOverall
            // 
            this.pbOverall.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pbOverall.Location = new System.Drawing.Point(9, 54);
            this.pbOverall.Maximum = 1;
            this.pbOverall.Name = "pbOverall";
            this.pbOverall.Size = new System.Drawing.Size(502, 25);
            this.pbOverall.Step = 1;
            this.pbOverall.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbOverall.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(439, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bwDirAnalyzer
            // 
            this.bwDirAnalyzer.WorkerSupportsCancellation = true;
            this.bwDirAnalyzer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDirAnalyzer_DoWork);
            this.bwDirAnalyzer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDirAnalyzer_RunWorkerCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Analyzing";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTopLevel
            // 
            this.lblTopLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTopLevel.Location = new System.Drawing.Point(69, 35);
            this.lblTopLevel.Name = "lblTopLevel";
            this.lblTopLevel.Size = new System.Drawing.Size(440, 18);
            this.lblTopLevel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Directory:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrent
            // 
            this.lblCurrent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCurrent.Location = new System.Drawing.Point(9, 106);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(505, 18);
            this.lblCurrent.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::DiskAnalyzer.Properties.Resources.Csearch_00;
            this.pictureBox1.Image = global::DiskAnalyzer.Properties.Resources.Csearch_00;
            this.pictureBox1.InitialImage = global::DiskAnalyzer.Properties.Resources.Csearch_00;
            this.pictureBox1.Location = new System.Drawing.Point(493, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // CalculateDirectorySize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(526, 163);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTopLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbOverall);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalculateDirectorySize";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Please Wait!!";
            this.Load += new System.EventHandler(this.PleaseWait_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalculateDirectorySize_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbOverall;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker bwDirAnalyzer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTopLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}