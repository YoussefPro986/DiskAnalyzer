using System.Drawing.Drawing2D;

namespace DiskAnalyzer
{
    partial class DiskSize
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiskSize));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tvDirectory = new System.Windows.Forms.TreeView();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDiskSize = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.PieChartControlDirectory = new System.Drawing.PieChart.PieChartControl();
            this.dataGridViewDirectory = new System.Windows.Forms.DataGridView();
            this.FolderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSizeMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpFileTypes = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.pieChartControlFileTypes = new System.Drawing.PieChart.PieChartControl();
            this.treeFileTypes = new AdvancedDataGridView.TreeGridView();
            this.ColumnName = new AdvancedDataGridView.TreeGridColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.slblCurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openParentDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonToExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOptons = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFilterOptions = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpDiskSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirectory)).BeginInit();
            this.tpFileTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeFileTypes)).BeginInit();
            this.contextMenuStripGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(951, 567);
            this.splitContainer1.SplitterDistance = 26;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButtonToExcel,
            this.toolStripButtonOptons,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(951, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer2.Size = new System.Drawing.Size(951, 540);
            this.splitContainer2.SplitterDistance = 514;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tvDirectory);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer3.Size = new System.Drawing.Size(951, 514);
            this.splitContainer3.SplitterDistance = 319;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 0;
            // 
            // tvDirectory
            // 
            this.tvDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvDirectory.ImageIndex = 2;
            this.tvDirectory.ImageList = this.imageListMain;
            this.tvDirectory.Location = new System.Drawing.Point(0, 0);
            this.tvDirectory.Name = "tvDirectory";
            this.tvDirectory.PathSeparator = "";
            this.tvDirectory.SelectedImageIndex = 3;
            this.tvDirectory.Size = new System.Drawing.Size(319, 514);
            this.tvDirectory.TabIndex = 4;
            this.tvDirectory.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.tvDirectory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.tvDirectory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tvDirectory_KeyPress);
            // 
            // imageListMain
            // 
            this.imageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMain.ImageStream")));
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMain.Images.SetKeyName(0, "mycomputer1.jpg");
            this.imageListMain.Images.SetKeyName(1, "disk1.jpg");
            this.imageListMain.Images.SetKeyName(2, "folder.jpg");
            this.imageListMain.Images.SetKeyName(3, "PieChart3DHS.png");
            this.imageListMain.Images.SetKeyName(4, "Files");
            this.imageListMain.Images.SetKeyName(5, "pageNumberHS.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDiskSize);
            this.tabControl1.Controls.Add(this.tpFileTypes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageListMain;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 514);
            this.tabControl1.TabIndex = 2;
            // 
            // tpDiskSize
            // 
            this.tpDiskSize.Controls.Add(this.splitContainer4);
            this.tpDiskSize.ImageIndex = 3;
            this.tpDiskSize.Location = new System.Drawing.Point(4, 23);
            this.tpDiskSize.Name = "tpDiskSize";
            this.tpDiskSize.Padding = new System.Windows.Forms.Padding(3);
            this.tpDiskSize.Size = new System.Drawing.Size(621, 487);
            this.tpDiskSize.TabIndex = 0;
            this.tpDiskSize.Text = "Size Analysis";
            this.tpDiskSize.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.PieChartControlDirectory);
            this.splitContainer4.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dataGridViewDirectory);
            this.splitContainer4.Size = new System.Drawing.Size(615, 481);
            this.splitContainer4.SplitterDistance = 239;
            this.splitContainer4.TabIndex = 7;
            // 
            // PieChartControlDirectory
            // 
            this.PieChartControlDirectory.AutoScroll = true;
            this.PieChartControlDirectory.BackColor = System.Drawing.Color.White;
            this.PieChartControlDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PieChartControlDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PieChartControlDirectory.Location = new System.Drawing.Point(3, 3);
            this.PieChartControlDirectory.Margin = new System.Windows.Forms.Padding(10);
            this.PieChartControlDirectory.Name = "PieChartControlDirectory";
            this.PieChartControlDirectory.Padding = new System.Windows.Forms.Padding(10);
            this.PieChartControlDirectory.Size = new System.Drawing.Size(607, 231);
            this.PieChartControlDirectory.TabIndex = 0;
            this.PieChartControlDirectory.Texts = null;
            this.PieChartControlDirectory.ToolTips = null;
            this.PieChartControlDirectory.Values = null;
            this.PieChartControlDirectory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pieChartControl1_MouseDoubleClick);
            // 
            // dataGridViewDirectory
            // 
            this.dataGridViewDirectory.AllowUserToAddRows = false;
            this.dataGridViewDirectory.AllowUserToDeleteRows = false;
            this.dataGridViewDirectory.AllowUserToOrderColumns = true;
            this.dataGridViewDirectory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewDirectory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDirectory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FolderName,
            this.TotalSizeMB,
            this.Type});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDirectory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDirectory.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridViewDirectory.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDirectory.MultiSelect = false;
            this.dataGridViewDirectory.Name = "dataGridViewDirectory";
            this.dataGridViewDirectory.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDirectory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDirectory.RowHeadersWidth = 25;
            this.dataGridViewDirectory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDirectory.Size = new System.Drawing.Size(613, 236);
            this.dataGridViewDirectory.StandardTab = true;
            this.dataGridViewDirectory.TabIndex = 6;
            this.dataGridViewDirectory.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dataGridViewDirectory_RowContextMenuStripNeeded);
            // 
            // FolderName
            // 
            this.FolderName.DataPropertyName = "FolderName";
            this.FolderName.HeaderText = "Folder Name";
            this.FolderName.Name = "FolderName";
            this.FolderName.ReadOnly = true;
            this.FolderName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FolderName.Width = 99;
            // 
            // TotalSizeMB
            // 
            this.TotalSizeMB.DataPropertyName = "TotalSize(MB)";
            this.TotalSizeMB.HeaderText = "Total Size (MB)";
            this.TotalSizeMB.Name = "TotalSizeMB";
            this.TotalSizeMB.ReadOnly = true;
            this.TotalSizeMB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TotalSizeMB.Width = 110;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Type.DefaultCellStyle = dataGridViewCellStyle2;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.Width = 54;
            // 
            // tpFileTypes
            // 
            this.tpFileTypes.Controls.Add(this.splitContainer5);
            this.tpFileTypes.ImageIndex = 4;
            this.tpFileTypes.Location = new System.Drawing.Point(4, 23);
            this.tpFileTypes.Name = "tpFileTypes";
            this.tpFileTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tpFileTypes.Size = new System.Drawing.Size(621, 487);
            this.tpFileTypes.TabIndex = 1;
            this.tpFileTypes.Text = "File Types";
            this.tpFileTypes.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.pieChartControlFileTypes);
            this.splitContainer5.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.treeFileTypes);
            this.splitContainer5.Size = new System.Drawing.Size(615, 481);
            this.splitContainer5.SplitterDistance = 239;
            this.splitContainer5.TabIndex = 2;
            // 
            // pieChartControlFileTypes
            // 
            this.pieChartControlFileTypes.AutoScroll = true;
            this.pieChartControlFileTypes.BackColor = System.Drawing.Color.White;
            this.pieChartControlFileTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartControlFileTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieChartControlFileTypes.Location = new System.Drawing.Point(3, 3);
            this.pieChartControlFileTypes.Margin = new System.Windows.Forms.Padding(10);
            this.pieChartControlFileTypes.Name = "pieChartControlFileTypes";
            this.pieChartControlFileTypes.Padding = new System.Windows.Forms.Padding(10);
            this.pieChartControlFileTypes.Size = new System.Drawing.Size(607, 231);
            this.pieChartControlFileTypes.TabIndex = 0;
            this.pieChartControlFileTypes.Texts = null;
            this.pieChartControlFileTypes.ToolTips = null;
            this.pieChartControlFileTypes.Values = null;
            // 
            // treeFileTypes
            // 
            this.treeFileTypes.AllowUserToAddRows = false;
            this.treeFileTypes.AllowUserToDeleteRows = false;
            this.treeFileTypes.BackgroundColor = System.Drawing.Color.White;
            this.treeFileTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.treeFileTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.treeFileTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnSize,
            this.ColumnPath});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.treeFileTypes.DefaultCellStyle = dataGridViewCellStyle6;
            this.treeFileTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFileTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.treeFileTypes.ImageList = this.imageListMain;
            this.treeFileTypes.Location = new System.Drawing.Point(0, 0);
            this.treeFileTypes.Name = "treeFileTypes";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.treeFileTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.treeFileTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.treeFileTypes.Size = new System.Drawing.Size(613, 236);
            this.treeFileTypes.TabIndex = 1;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnName.DefaultNodeImage = null;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnName.Width = 41;
            // 
            // ColumnSize
            // 
            this.ColumnSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSize.HeaderText = "Size";
            this.ColumnSize.Name = "ColumnSize";
            this.ColumnSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnSize.Width = 33;
            // 
            // ColumnPath
            // 
            this.ColumnPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnPath.HeaderText = "Path";
            this.ColumnPath.Name = "ColumnPath";
            this.ColumnPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnPath.Width = 35;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(951, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // slblCurrent
            // 
            this.slblCurrent.Name = "slblCurrent";
            this.slblCurrent.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FolderName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Folder Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 99;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TotalSize(MB)";
            this.dataGridViewTextBoxColumn2.HeaderText = "Total Size (MB)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Type";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 54;
            // 
            // contextMenuStripGrid
            // 
            this.contextMenuStripGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDirectoryToolStripMenuItem,
            this.openParentDirectoryToolStripMenuItem});
            this.contextMenuStripGrid.Name = "contextMenuStripGrid";
            this.contextMenuStripGrid.Size = new System.Drawing.Size(192, 48);
            // 
            // openDirectoryToolStripMenuItem
            // 
            this.openDirectoryToolStripMenuItem.Name = "openDirectoryToolStripMenuItem";
            this.openDirectoryToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.openDirectoryToolStripMenuItem.Text = "Open";
            this.openDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openDirectoryToolStripMenuItem_Click);
            // 
            // openParentDirectoryToolStripMenuItem
            // 
            this.openParentDirectoryToolStripMenuItem.Name = "openParentDirectoryToolStripMenuItem";
            this.openParentDirectoryToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.openParentDirectoryToolStripMenuItem.Text = "Open Parent Directory";
            this.openParentDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openParentDirectoryToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Reload";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButtonReload_Click);
            // 
            // toolStripButtonToExcel
            // 
            this.toolStripButtonToExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonToExcel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonToExcel.Image")));
            this.toolStripButtonToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonToExcel.Name = "toolStripButtonToExcel";
            this.toolStripButtonToExcel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonToExcel.Text = "Export to Excel";
            this.toolStripButtonToExcel.Click += new System.EventHandler(this.toolStripButtonToExcel_Click);
            // 
            // toolStripButtonOptons
            // 
            this.toolStripButtonOptons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOptons.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOptons.Image")));
            this.toolStripButtonOptons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOptons.Name = "toolStripButtonOptons";
            this.toolStripButtonOptons.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOptons.Text = "Filter Options";
            this.toolStripButtonOptons.Click += new System.EventHandler(this.toolStripButtonFilterOptions_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Check and Repair Hard Disk Problems";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Directory Tree";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonReload
            // 
            this.toolStripButtonReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReload.Image = global::DiskAnalyzer.Properties.Resources.RepeatHS;
            this.toolStripButtonReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReload.Name = "toolStripButtonReload";
            this.toolStripButtonReload.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReload.Text = "Reload";
            this.toolStripButtonReload.Click += new System.EventHandler(this.toolStripButtonReload_Click);
            // 
            // toolStripButtonFilterOptions
            // 
            this.toolStripButtonFilterOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFilterOptions.Image = global::DiskAnalyzer.Properties.Resources.otheroptions;
            this.toolStripButtonFilterOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFilterOptions.Name = "toolStripButtonFilterOptions";
            this.toolStripButtonFilterOptions.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFilterOptions.Text = "Filter Options";
            this.toolStripButtonFilterOptions.Click += new System.EventHandler(this.toolStripButtonFilterOptions_Click);
            // 
            // toolStripButtonHelp
            // 
            this.toolStripButtonHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHelp.Image = global::DiskAnalyzer.Properties.Resources.help;
            this.toolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHelp.Name = "toolStripButtonHelp";
            this.toolStripButtonHelp.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonHelp.Text = "toolStripButton2";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "About";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // DiskSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(951, 567);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiskSize";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disk Analyzer V1.7";
            this.Load += new System.EventHandler(this.DirectorySize_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpDiskSize.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirectory)).EndInit();
            this.tpFileTypes.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeFileTypes)).EndInit();
            this.contextMenuStripGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slblCurrent;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ImageList imageListMain;
        public System.Windows.Forms.TreeView tvDirectory;
        internal System.Windows.Forms.DataGridView dataGridViewDirectory;
        private System.Drawing.PieChart.PieChartControl PieChartControlDirectory;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDiskSize;
        private System.Windows.Forms.TabPage tpFileTypes;
        private System.Drawing.PieChart.PieChartControl pieChartControlFileTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private AdvancedDataGridView.TreeGridView treeFileTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSizeMB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private AdvancedDataGridView.TreeGridColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
        private System.Windows.Forms.ToolStripButton toolStripButtonFilterOptions;
        private System.Windows.Forms.ToolStripButton toolStripButtonReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGrid;
        private System.Windows.Forms.ToolStripMenuItem openDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openParentDirectoryToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonToExcel;
        private System.Windows.Forms.ToolStripButton toolStripButtonOptons;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}