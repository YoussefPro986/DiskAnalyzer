using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Linq;
using System.Threading;
using System.IO;
using System.Reflection;
using CarlosAg.ExcelXmlWriter;
using System.Diagnostics;
using System.Management;
using System.Management.Instrumentation;

namespace DiskAnalyzer
{
    public partial class DiskSize : Form
    {
        public const string MY_COMPUTER = "My Computer";
        public string LastScanDirectory = "";

        public DiskSize()
        {
            InitializeComponent();
        }

        private void loadDirectoryTree()
        {
            this.slblCurrent.Text = "Directory tree is loading...";
            statusStrip1.Refresh();

            this.tvDirectory.PathSeparator = Path.DirectorySeparatorChar.ToString();
            TreeNode newNode = new TreeNode(MY_COMPUTER);
            newNode.ImageIndex = 0;
            this.tvDirectory.Nodes.Add(newNode);
            tvDirectory.SelectedNode = newNode;

            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                newNode = new TreeNode(di.Name.Remove(2));
                newNode.ImageIndex = 1;
                tvDirectory.Nodes[0].Nodes.Add(newNode);
                getSubDirectories(newNode);
            }

            this.slblCurrent.Text = "Completed";

        }

        private static DataTable GetDriveDataTable()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            DataTable dtDriveInfo = new DataTable();
            dtDriveInfo.Columns.Add("Drive Name");
            dtDriveInfo.Columns.Add("Total Size(GB)");
            dtDriveInfo.Columns.Add("Free Space");

            DataRow drDriveInfo;
            foreach (DriveInfo di in drives)
            {
                if (di.IsReady)
                {
                    drDriveInfo = dtDriveInfo.NewRow();
                    drDriveInfo.ItemArray = new Object[] { di.Name, Math.Round(di.TotalSize / Math.Pow(10, 9), 2), Math.Round(di.TotalFreeSpace / Math.Pow(10, 9), 2) };

                    dtDriveInfo.Rows.Add(drDriveInfo);
                }
            }

            return dtDriveInfo;
        }

        private void DirectorySize_Load(object sender, EventArgs e)
        {
            dataGridViewDirectory.Columns.Clear();
            dataGridViewDirectory.AutoGenerateColumns = true;

            loadDirectoryTree();

            loadDefaultView();
            InitPieChartControls();

            tvDirectory.Focus();


        }

        private void InitPieChartControls()
        {
            PieChartControlDirectory.SliceRelativeHeight = 0.20F;
            PieChartControlDirectory.EdgeLineWidth = 0.25F;
            PieChartControlDirectory.EdgeColorType = System.Drawing.PieChart.EdgeColorType.DarkerThanSurface;
            PieChartControlDirectory.ShadowStyle = System.Drawing.PieChart.ShadowStyle.GradualShadow;
            PieChartControlDirectory.RightMargin = 10;
            PieChartControlDirectory.LeftMargin = 10;

            pieChartControlFileTypes.SliceRelativeHeight = 0.20F;
            pieChartControlFileTypes.EdgeLineWidth = 0.25F;
            pieChartControlFileTypes.EdgeColorType = System.Drawing.PieChart.EdgeColorType.DarkerThanSurface;
            pieChartControlFileTypes.ShadowStyle = System.Drawing.PieChart.ShadowStyle.GradualShadow;
            pieChartControlFileTypes.RightMargin = 10;
            pieChartControlFileTypes.LeftMargin = 10;
        }

        private void loadDefaultView()
        {
            DataTable dtDriveInfo = GetDriveDataTable();
            InitializeChart(dtDriveInfo);
            InitializeGrid(dtDriveInfo);

            if (dataGridViewDirectory.Columns.Count > 1)
                dataGridViewDirectory.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            if (dataGridViewDirectory.Columns.Count > 2)
                dataGridViewDirectory.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }


        List<string> lstAuthException = new List<string>();
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            getSubDirectories(e.Node);
        }

        private void getSubDirectories(TreeNode parent)
        {
            DirectoryInfo directory;
            try
            {
                if (parent.Nodes.Count == 0)
                {
                    string currDirectory = parent.FullPath.Remove(0, MY_COMPUTER.Length + 1).Replace(@"\\", @"\");
                    if (!currDirectory.EndsWith(@"\"))
                        currDirectory += @"\";
                    directory = new DirectoryInfo(currDirectory);
                    foreach (DirectoryInfo dir in directory.GetDirectories())
                    {
                        TreeNode newNode = new TreeNode(dir.Name);
                        newNode.ImageIndex = 2;
                        parent.Nodes.Add(newNode);
                    }
                }

                foreach (TreeNode node in parent.Nodes)
                {
                    if (node.Nodes.Count == 0)
                    {
                        string currDirectory = node.FullPath.Remove(0, MY_COMPUTER.Length + 1).Replace(@"\\", @"\");

                        if (!currDirectory.EndsWith(@"\"))
                            currDirectory += @"\";
                        directory = new DirectoryInfo(currDirectory);
                        try
                        {
                            foreach (DirectoryInfo dir in directory.GetDirectories())
                            {
                                TreeNode newNode = new TreeNode(dir.Name);
                                newNode.ImageIndex = 2;
                                node.Nodes.Add(newNode);
                            }
                        }
                        catch (UnauthorizedAccessException)
                        {
                            lstAuthException.Add(currDirectory);
                        }
                    }
                }
            }
            catch (Exception doh)
            {
                Console.WriteLine(doh.Message);
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ExecuteDirectorySize();
        }

        private void ExecuteDirectorySize()
        {
            this.slblCurrent.Text = "Please Wait!! Analyzing...";

            CalculateDirectorySize pw = null;
            ResetPieCharts();

            if (tvDirectory.SelectedNode != null)
            {
                if (tvDirectory.SelectedNode.Text != MY_COMPUTER)
                {
                    pw = new CalculateDirectorySize();
                    pw.filterOptions = filterOptions;
                    pw.Owner = this;
                    pw.SelectedNodeText = tvDirectory.SelectedNode.Text;

                    try
                    {
                        pw.ShowDialog(this);
                    }
                    catch (TargetInvocationException tiEx)
                    {
                        MessageBox.Show(tiEx.InnerException.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LastScanDirectory = pw.RootScanDirectory;
                    InitilizeDirectoryAnalysisData(pw);
                }
                else if (tvDirectory.SelectedNode.Text == MY_COMPUTER)
                {
                    treeFileTypes.Nodes.Clear();

                    pw = new CalculateDirectorySize();
                    pw.Owner = this;
                    pw.SelectedNodeText = tvDirectory.SelectedNode.Text;
                    LastScanDirectory = "MY_COMPUTER";

                    // Dislay Drive Info
                    InitializeDriveChart();
                    tvDirectory.SelectedNode.Expand();

                    if (dataGridViewDirectory.Columns.Count > 0)
                    {
                        dataGridViewDirectory.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridViewDirectory.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }

                this.slblCurrent.Text = "Done";
            }

        }

        private void InitilizeDirectoryAnalysisData(CalculateDirectorySize pw)
        {
            InitializeChart(pw.DirectoryInformation);
            InitializeChartFileTypes(pw.DirectoryDictionary);

            InitializeGrid(pw.DirectoryInformation);
            InitializeGridFileTypes(pw.FileList, pw.DirectoryDictionary);
        }

        private void ResetPieCharts()
        {
            PieChartControlDirectory.Texts = null;
            PieChartControlDirectory.Values = null;
            PieChartControlDirectory.ToolTips = null;
            PieChartControlDirectory.SliceRelativeDisplacements = null;

            pieChartControlFileTypes.Texts = null;
            pieChartControlFileTypes.Values = null;
            pieChartControlFileTypes.ToolTips = null;
            pieChartControlFileTypes.SliceRelativeDisplacements = null;
        }

        private void InitializeGridFileTypes(
            Dictionary<FileSize, List<FileSize>> dicTypeNames,
            Dictionary<string, long> dicTypeSizes)
        {
            treeFileTypes.Nodes.Clear();

            FileSize[] arrFs = dicTypeNames.Keys.ToArray();
            Array.Sort(arrFs, new FileSize("", 0, ""));

            foreach (FileSize fsKey in arrFs)
            {

                string SetBytes = convertSize(dicTypeSizes[fsKey.FileName]);

                AdvancedDataGridView.TreeGridNode tvNode = treeFileTypes.Nodes.Add(fsKey.FileName, SetBytes, "");
                tvNode.ImageIndex = 4;
                int count = 0;
                dicTypeNames[fsKey].Sort(new FileSize("", 0, ""));

                foreach (FileSize fs in dicTypeNames[fsKey])
                {
                    SetBytes = convertSize(fs.Size);

                    AdvancedDataGridView.TreeGridNode tvChildNode
                        = tvNode.Nodes.Add(fs.FileName, SetBytes, fs.Path);
                    tvChildNode.ImageIndex = 5;

                    if (count++ >= 4) break;
                }
            }
        }

        private void InitializeChartFileTypes(Dictionary<string, long> dicFileTypes)
        {

            decimal[] Values = new decimal[dicFileTypes.Count];
            float[] Displacements = new float[dicFileTypes.Count];
            string[] Texts = new string[dicFileTypes.Count];
            string[] ToolTips = new string[dicFileTypes.Count];

            List<Color> lstColors = new List<Color>();
            lstColors.Add(Color.FromArgb(122, Color.AliceBlue));
            lstColors.Add(Color.FromArgb(122, Color.Aquamarine));
            lstColors.Add(Color.FromArgb(122, Color.Azure));
            lstColors.Add(Color.FromArgb(122, Color.Beige));
            lstColors.Add(Color.FromArgb(122, Color.Bisque));
            lstColors.Add(Color.FromArgb(122, Color.AntiqueWhite));
            lstColors.Add(Color.FromArgb(122, Color.BlanchedAlmond));
            lstColors.Add(Color.FromArgb(122, Color.BlueViolet));
            lstColors.Add(Color.FromArgb(122, Color.BurlyWood));
            lstColors.Add(Color.FromArgb(122, Color.CadetBlue));
            lstColors.Add(Color.FromArgb(122, Color.Red));
            lstColors.Add(Color.FromArgb(122, Color.Chartreuse));
            lstColors.Add(Color.FromArgb(122, Color.Chocolate));
            lstColors.Add(Color.FromArgb(122, Color.Coral));
            lstColors.Add(Color.FromArgb(122, Color.CornflowerBlue));
            lstColors.Add(Color.FromArgb(122, Color.Cornsilk));
            lstColors.Add(Color.FromArgb(122, Color.Crimson));
            lstColors.Add(Color.FromArgb(122, Color.Cyan));
            lstColors.Add(Color.FromArgb(122, Color.DarkBlue));
            lstColors.Add(Color.FromArgb(122, Color.DarkCyan));
            lstColors.Add(Color.FromArgb(122, Color.Blue));
            lstColors.Add(Color.FromArgb(122, Color.Brown));
            lstColors.Add(Color.FromArgb(122, Color.Orange));
            lstColors.Add(Color.FromArgb(122, Color.Green));
            lstColors.Add(Color.FromArgb(122, Color.Aqua));
            lstColors.Add(Color.FromArgb(122, Color.Olive));
            lstColors.Add(Color.FromArgb(122, Color.PaleGreen));
            lstColors.Add(Color.FromArgb(122, Color.Plum));
            lstColors.Add(Color.FromArgb(122, Color.RosyBrown));
            lstColors.Add(Color.FromArgb(122, Color.Salmon));

            Color[] Colors = lstColors.ToArray();

            Texts = dicFileTypes.Keys.ToArray();

            int i = 0;
            foreach (decimal dirSize in dicFileTypes.Values)
            {
                string SetBytes = "";
                if (dirSize >= 1073741824)
                {
                    SetBytes = String.Format("{0:N2} GB", ((dirSize / 1024) / 1024) / 1024);
                }
                else if (dirSize >= 1048576)
                {
                    SetBytes = String.Format("{0:N2} MB", (dirSize / 1024) / 1024);
                }
                else if (dirSize >= 1024)
                {
                    SetBytes = String.Format("{0:N2} KB", (dirSize / 1024));
                }
                else if (dirSize < 1024)
                {
                    SetBytes = dirSize.ToString() + " Bytes";
                }

                Values[i] = (decimal)dicFileTypes[Texts[i]];
                Displacements[i] = 0.05F;
                ToolTips[i] = String.Format("{0} ( {1} )", Texts[i], SetBytes);
                Texts[i++] = "";
            }

            pieChartControlFileTypes.Values = Values;
            pieChartControlFileTypes.SliceRelativeDisplacements = Displacements;
            pieChartControlFileTypes.Texts = Texts;
            pieChartControlFileTypes.Colors = Colors;
            pieChartControlFileTypes.ToolTips = ToolTips;
        }

        internal void InitializeDriveChart()
        {
            //dataGridViewDirectory.Visible = false;

            DataTable dtDriveInfo = GetDriveDataTable();
            dataGridViewDirectory.DataSource = dtDriveInfo;
            slblCurrent.Text = "Done";

            InitializeChart(dtDriveInfo);

            //dataGridViewDirectory.Visible = true;

            tvDirectory.SelectedNode.Expand();

            if (dataGridViewDirectory.Columns.Count > 0)
                dataGridViewDirectory.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            if (dataGridViewDirectory.Columns.Count > 1)
                dataGridViewDirectory.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        internal void InitializeGrid(DataTable dtDirInfo)
        {
            dataGridViewDirectory.AutoGenerateColumns = true;
            dataGridViewDirectory.DataSource = dtDirInfo;

            if (dataGridViewDirectory.Columns.Count > 0) dataGridViewDirectory.Columns[0].HeaderText = "File / Folder Name";
            if (dataGridViewDirectory.Columns.Count > 1)
            {
                dataGridViewDirectory.Columns[1].HeaderText = "Total Size";
                dataGridViewDirectory.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            }
            if (dataGridViewDirectory.Columns.Count > 2)
            {
                dataGridViewDirectory.Columns[2].HeaderText = "Total Bytes";
                dataGridViewDirectory.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            }
            if (dataGridViewDirectory.Columns.Count > 3) dataGridViewDirectory.Columns[3].HeaderText = "Type";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dtDirInfo"></param>
        internal void InitializeChart(DataTable dtDirInfo)
        {

            decimal[] Values = new decimal[dtDirInfo.Rows.Count];
            float[] Displacements = new float[dtDirInfo.Rows.Count];
            string[] Texts = new string[dtDirInfo.Rows.Count];
            string[] ToolTips = new string[dtDirInfo.Rows.Count];

            List<Color> lstColors = new List<Color>();
            lstColors.Add(Color.FromArgb(122, Color.AliceBlue));
            lstColors.Add(Color.FromArgb(122, Color.Aquamarine));
            lstColors.Add(Color.FromArgb(122, Color.Azure));
            lstColors.Add(Color.FromArgb(122, Color.Beige));
            lstColors.Add(Color.FromArgb(122, Color.Bisque));
            lstColors.Add(Color.FromArgb(122, Color.AntiqueWhite));
            lstColors.Add(Color.FromArgb(122, Color.BlanchedAlmond));
            lstColors.Add(Color.FromArgb(122, Color.BlueViolet));
            lstColors.Add(Color.FromArgb(122, Color.BurlyWood));
            lstColors.Add(Color.FromArgb(122, Color.CadetBlue));
            lstColors.Add(Color.FromArgb(122, Color.Red));
            lstColors.Add(Color.FromArgb(122, Color.Chartreuse));
            lstColors.Add(Color.FromArgb(122, Color.Chocolate));
            lstColors.Add(Color.FromArgb(122, Color.Coral));
            lstColors.Add(Color.FromArgb(122, Color.CornflowerBlue));
            lstColors.Add(Color.FromArgb(122, Color.Cornsilk));
            lstColors.Add(Color.FromArgb(122, Color.Crimson));
            lstColors.Add(Color.FromArgb(122, Color.Cyan));
            lstColors.Add(Color.FromArgb(122, Color.DarkBlue));
            lstColors.Add(Color.FromArgb(122, Color.DarkCyan));
            lstColors.Add(Color.FromArgb(122, Color.Blue));
            lstColors.Add(Color.FromArgb(122, Color.Brown));
            lstColors.Add(Color.FromArgb(122, Color.Orange));
            lstColors.Add(Color.FromArgb(122, Color.Green));
            lstColors.Add(Color.FromArgb(122, Color.Aqua));
            lstColors.Add(Color.FromArgb(122, Color.Olive));
            lstColors.Add(Color.FromArgb(122, Color.PaleGreen));
            lstColors.Add(Color.FromArgb(122, Color.Plum));
            lstColors.Add(Color.FromArgb(122, Color.RosyBrown));
            lstColors.Add(Color.FromArgb(122, Color.Salmon));

            Color[] Colors = lstColors.ToArray();

            for (int i = 0; i < dtDirInfo.Rows.Count; i++)
            {
                Values[i] = Convert.ToDecimal(dtDirInfo.Rows[i][2]);
                Displacements[i] = 0.05F;
                Texts[i] = "";
                //Texts[i] = dtDirInfo.Rows[i][0].ToString() + "(" + dtDirInfo.Rows[i][1].ToString() + ")";
                ToolTips[i] = dtDirInfo.Rows[i][0].ToString() + "(" + dtDirInfo.Rows[i][1].ToString() + ")";
                //ToolTips[i] = dtDirInfo.Rows[i][1].ToString();
            }

            SetValues(Values);
            SetPieDisplacements(Displacements);
            SetColors(Colors);
            SetTexts(Texts);
            SetToolTips(ToolTips);

        }

        private void SetValues(decimal[] Values)
        {
            PieChartControlDirectory.Values = Values;
        }

        private void SetPieDisplacements(float[] Displacements)
        {
            PieChartControlDirectory.SliceRelativeDisplacements = Displacements;
        }

        private void SetColors(Color[] Colors)
        {
            PieChartControlDirectory.Colors = Colors;
        }

        private void SetTexts(string[] Texts)
        {
            PieChartControlDirectory.Texts = Texts;
        }

        private void SetToolTips(string[] ToolTips)
        {
            PieChartControlDirectory.ToolTips = ToolTips;
        }

        private void tvDirectory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ExecuteDirectorySize();
            }
        }

        private void pieChartControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = PieChartControlDirectory.FindPieSliceUnderPoint(new PointF(e.X, e.Y));
                if (index != -1)
                {
                    Process(PieChartControlDirectory.ToolTips[index]);
                }
            }
            catch
            {
            }
        }

        private void Process(string p)
        {
            string name = p.Remove(p.LastIndexOf('('));
            string currDirectory = tvDirectory.SelectedNode.FullPath.Remove(0, MY_COMPUTER.Length + 1);
            currDirectory += tvDirectory.PathSeparator + name;

            if (Directory.Exists(currDirectory))
            {
                foreach (TreeNode tv in tvDirectory.SelectedNode.Nodes)
                {
                    if (tv.Text == name)
                    {
                        tvDirectory.SelectedNode = tv;
                        ExecuteDirectorySize();
                        break;
                    }
                }

            }

            //throw new NotImplementedException();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tvDirectory.Focus();
        }


        private static string convertSize(double dirSize)
        {
            string SetBytes = "";

            if (dirSize >= 1073741824)
            {
                SetBytes = String.Format("{0:N2} GB", ((dirSize / 1024) / 1024) / 1024);
            }
            else if (dirSize >= 1048576)
            {
                SetBytes = String.Format("{0:N2} MB", (dirSize / 1024) / 1024);
            }
            else if (dirSize >= 1024)
            {
                SetBytes = String.Format("{0:N2} KB", (dirSize / 1024));
            }
            else if (dirSize < 1024)
            {
                SetBytes = dirSize.ToString() + " Bytes";
            }
            return SetBytes;
        }

        FilterOptions filterOptions = new FilterOptions();
        private void toolStripButtonFilterOptions_Click(object sender, EventArgs e)
        {
            filterOptions.ShowDialog(this);
            this.Activate();

            if (filterOptions.DialogResult == DialogResult.OK && filterOptions.RedoDirectoryAnalyze)
                ExecuteDirectorySize();
        }

        private void toolStripButtonReload_Click(object sender, EventArgs e)
        {
            ExecuteDirectorySize();
        }

        private int contextMenuRowIndex = -1;
        private void dataGridViewDirectory_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            contextMenuRowIndex = e.RowIndex;
            e.ContextMenuStrip = contextMenuStripGrid;
        }

        private void openDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LastScanDirectory != MY_COMPUTER)
            {
                string currentDirectory = LastScanDirectory;
                if (!LastScanDirectory.EndsWith(Path.DirectorySeparatorChar.ToString()))
                    currentDirectory += Path.DirectorySeparatorChar;

                if (dataGridViewDirectory.Columns.Contains("Folder Name"))
                    currentDirectory += dataGridViewDirectory.Rows[contextMenuRowIndex].Cells["Folder Name"].Value;
                else
                    currentDirectory = dataGridViewDirectory.Rows[contextMenuRowIndex].Cells["Drive Name"].Value.ToString(); 
                System.Diagnostics.Process.Start(currentDirectory);
            }
            
        }

        private void openParentDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LastScanDirectory != MY_COMPUTER)
            {
                System.Diagnostics.Process.Start(LastScanDirectory);
            }
        }

        private void toolStripButtonToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel files | *.xls";

            DialogResult saveDialogResult = saveDialog.ShowDialog();

            if (saveDialogResult != DialogResult.Cancel)
            {
                string filename = saveDialog.FileName;
                Workbook book = new Workbook();
                book.ExcelWorkbook.ActiveSheetIndex = 1;
                // Some optional properties of the Document
                book.Properties.Author = "Disk Analyzer";
                book.Properties.Title = "Disk Analyzer Report";
                book.Properties.Created = DateTime.Now;

                // Add some styles to the Workbook
                WorksheetStyle style = book.Styles.Add("HeaderStyle");
                style.Font.FontName = "Tahoma";
                style.Font.Size = 11;
                style.Font.Bold = true;
                style.Alignment.Horizontal = StyleHorizontalAlignment.Center;
                style.Font.Color = "White";
                style.Interior.Color = "Blue";
                style.Interior.Pattern = StyleInteriorPattern.DiagCross;

                // Create the Default Style to use for everyone
                style = book.Styles.Add("Default");
                style.Font.FontName = "Tahoma";
                style.Font.Size = 10;

                // Add a Worksheet with some data
                Worksheet sheet = book.Worksheets.Add("Size Analysis");
                WorksheetRow row = sheet.Table.Rows.Add();

                // we can optionally set some column settings
                for (int i = 0; i < dataGridViewDirectory.Columns.Count; i++)
                {
                    sheet.Table.Columns.Add(new WorksheetColumn(150));

                    row.Cells.Add(new WorksheetCell(dataGridViewDirectory.Columns[i].Name, "HeaderStyle"));
                }

                //row = sheet.Table.Rows.Add();
                // Skip one row, and add some text
                row.Index = 2;

                // Generate 30 rows
                for (int i = 0; i < dataGridViewDirectory.Rows.Count; i++)
                {
                    row = sheet.Table.Rows.Add();
                    for (int j = 0; j < dataGridViewDirectory.Columns.Count; j++)
                    {
                        row.Cells.Add(dataGridViewDirectory.Rows[i].Cells[j].Value.ToString());
                    }
                }

                // Add a Worksheet with some data
                sheet = book.Worksheets.Add("File Type Analysis");
                row = sheet.Table.Rows.Add();
                // we can optionally set some column settings
                for (int i = 0; i < treeFileTypes.Columns.Count; i++)
                {
                    sheet.Table.Columns.Add(new WorksheetColumn(150));

                    row.Cells.Add(new WorksheetCell(treeFileTypes.Columns[i].Name.Replace("Column", ""), "HeaderStyle"));
                }

                row.Index = 3;

                // Generate 30 rows
                for (int i = 0; i < treeFileTypes.Rows.Count; i++)
                {
                    row = sheet.Table.Rows.Add();
                    for (int j = 0; j < treeFileTypes.Columns.Count; j++)
                    {
                        row.Cells.Add(treeFileTypes.Rows[i].Cells[j].Value.ToString());
                    }
                }
                // Save the file and open it
                book.Save(filename);

                if (filterOptions.OpenExportedFile)
                    System.Diagnostics.Process.Start(filename);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CHKDSK HardDiskRepair32 = new CHKDSK();
            HardDiskRepair32.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExecuteDirectorySize();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel files | *.xls";

            DialogResult saveDialogResult = saveDialog.ShowDialog();

            if (saveDialogResult != DialogResult.Cancel)
            {
                string filename = saveDialog.FileName;
                Workbook book = new Workbook();
                book.ExcelWorkbook.ActiveSheetIndex = 1;
                // Some optional properties of the Document
                book.Properties.Author = "Disk Analyzer";
                book.Properties.Title = "Disk Analyzer Report";
                book.Properties.Created = DateTime.Now;

                // Add some styles to the Workbook
                WorksheetStyle style = book.Styles.Add("HeaderStyle");
                style.Font.FontName = "Tahoma";
                style.Font.Size = 11;
                style.Font.Bold = true;
                style.Alignment.Horizontal = StyleHorizontalAlignment.Center;
                style.Font.Color = "White";
                style.Interior.Color = "Blue";
                style.Interior.Pattern = StyleInteriorPattern.DiagCross;

                // Create the Default Style to use for everyone
                style = book.Styles.Add("Default");
                style.Font.FontName = "Tahoma";
                style.Font.Size = 10;

                // Add a Worksheet with some data
                Worksheet sheet = book.Worksheets.Add("Size Analysis");
                WorksheetRow row = sheet.Table.Rows.Add();

                // we can optionally set some column settings
                for (int i = 0; i < dataGridViewDirectory.Columns.Count; i++)
                {
                    sheet.Table.Columns.Add(new WorksheetColumn(150));

                    row.Cells.Add(new WorksheetCell(dataGridViewDirectory.Columns[i].Name, "HeaderStyle"));
                }

                //row = sheet.Table.Rows.Add();
                // Skip one row, and add some text
                row.Index = 2;

                // Generate 30 rows
                for (int i = 0; i < dataGridViewDirectory.Rows.Count; i++)
                {
                    row = sheet.Table.Rows.Add();
                    for (int j = 0; j < dataGridViewDirectory.Columns.Count; j++)
                    {
                        row.Cells.Add(dataGridViewDirectory.Rows[i].Cells[j].Value.ToString());
                    }
                }

                // Add a Worksheet with some data
                sheet = book.Worksheets.Add("File Type Analysis");
                row = sheet.Table.Rows.Add();
                // we can optionally set some column settings
                for (int i = 0; i < treeFileTypes.Columns.Count; i++)
                {
                    sheet.Table.Columns.Add(new WorksheetColumn(150));

                    row.Cells.Add(new WorksheetCell(treeFileTypes.Columns[i].Name.Replace("Column", ""), "HeaderStyle"));
                }

                row.Index = 3;

                // Generate 30 rows
                for (int i = 0; i < treeFileTypes.Rows.Count; i++)
                {
                    row = sheet.Table.Rows.Add();
                    for (int j = 0; j < treeFileTypes.Columns.Count; j++)
                    {
                        row.Cells.Add(treeFileTypes.Rows[i].Cells[j].Value.ToString());
                    }
                }
                // Save the file and open it
                book.Save(filename);

                if (filterOptions.OpenExportedFile)
                    System.Diagnostics.Process.Start(filename);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            filterOptions.ShowDialog(this);
            this.Activate();

            if (filterOptions.DialogResult == DialogResult.OK && filterOptions.RedoDirectoryAnalyze)
                ExecuteDirectorySize();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CHKDSK HardDiskRepair32 = new CHKDSK();
            HardDiskRepair32.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            About About32 = new About();
            About32.Show();
        }
    }
    }