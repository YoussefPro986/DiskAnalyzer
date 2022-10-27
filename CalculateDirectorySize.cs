using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DiskAnalyzer
{

    public partial class CalculateDirectorySize : Form
    {
        public CalculateDirectorySize()
        {
            InitializeComponent();
        }

        public FilterOptions filterOptions;

        public long CalculateSize(DirectoryInfo directory)
        {
            CurrentDirectory = directory.FullName;

            this.BeginInvoke(new UIDelegate(updateCurrentStatus));

            if (abortFlag) return 0;
            long Size = 0;
            try
            {
                // Add file sizes.
                foreach (FileInfo fi in directory.GetFiles())
                {
                    if (fi.Length >= filterOptions.FilterSize)
                    {
                        if((filterOptions.HasIncludeFilesSet && !filterOptions.IncludeList.Contains(fi.Extension)) 
                            || (filterOptions.HasExcludeFilesSet && filterOptions.ExcludeList.Contains(fi.Extension)))
                            continue;

                        Size += fi.Length;

                        if (DirectoryDictionary.ContainsKey(fi.Extension))
                        {
                            DirectoryDictionary[fi.Extension] += fi.Length;
                        }
                        else
                        {
                            DirectoryDictionary.Add(fi.Extension, fi.Length);
                        }

                        FileSize fsKey = new FileSize(fi.Extension, fi.Length, "");
                        if (!FileList.ContainsKey(fsKey))
                            FileList.Add(fsKey, new List<FileSize>());

                        FileList[fsKey].Add(new FileSize(fi.Name, fi.Length, fi.DirectoryName));
                    }

                }


                IEnumerable<long> iEnumSize = from di in directory.GetDirectories() select CalculateSize(di);

                // Add subdirectory sizes.
                Size += iEnumSize.Sum();
            }
            catch (UnauthorizedAccessException)
            {
                lstAuthException.Add(directory.FullName);
            }

            return Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PleaseWait_Load(object sender, EventArgs e)
        {
            tvDirectory = ((DiskSize)this.Owner).tvDirectory;
            tvSelNodeFullLen = tvDirectory.SelectedNode.FullPath.Length;

            currDirectory = tvDirectory.SelectedNode.FullPath.Remove(0, DiskSize.MY_COMPUTER.Length + 1);

            if (bwDirAnalyzer.IsBusy)
                bwDirAnalyzer.CancelAsync();

            while (bwDirAnalyzer.CancellationPending) ;

            bwDirAnalyzer.RunWorkerAsync();
        }

        private void updateCurrentStatus()
        {
            lblTopLevel.Text = TopCurrentDirectory;
            lblCurrent.Text = CurrentDirectory;
        }

        private TreeView tvDirectory;
        private int tvSelNodeFullLen;
        string currDirectory;
        public string RootScanDirectory = "";
        string TopCurrentDirectory;
        string CurrentDirectory;
        private bool abortFlag;
        public string SelectedNodeText;
        public DataTable DirectoryInformation = new DataTable();
        public Dictionary<string, long> DirectoryDictionary = new Dictionary<string, long>();
        public Dictionary<FileSize, List<FileSize>> FileList = new Dictionary<FileSize, List<FileSize>>(new FileSize("", 0, ""));
        List<string> lstAuthException = new List<string>();

        private void Init()
        {
            int count = Directory.GetDirectories(currDirectory).Count();
            pbOverall.Maximum = count;
        }

        delegate void UIDelegate();
        public void ShowDirectorySize()
        {
            //            MessageBox.Show("Pleae wait!! It might take a while depending on the files on the drive selected");
            if (tvSelNodeFullLen > DiskSize.MY_COMPUTER.Length + 1)
            {
                currDirectory = currDirectory.EndsWith(Path.PathSeparator.ToString()) ? currDirectory : currDirectory + Path.DirectorySeparatorChar;
                RootScanDirectory = currDirectory;
                this.BeginInvoke(new UIDelegate(Init));

                DirectoryInformation.Columns.Add("Folder Name");
                DirectoryInformation.Columns.Add("Total Size");
                DirectoryInformation.Columns.Add("Total Size (Bytes)", System.Type.GetType("System.Double"));
                DirectoryInformation.Columns.Add("Attributes");

                string name;
                double dirSize = 0;
                DirectoryInfo dirInfo;
                try
                {
                    foreach (String dirName in Directory.GetDirectories(currDirectory))
                    {
                        if (abortFlag) return;

                        dirInfo = new DirectoryInfo(dirName);
                        if (dirInfo.Attributes.ToString() != "Hidden, System, Directory")
                        {
                            TopCurrentDirectory = dirInfo.FullName;
                            dirSize = CalculateSize(dirInfo);
                            string SetBytes;
                            SetBytes = convertSize(dirSize);

                            name = dirName.Replace(currDirectory, "");
                            if (!lstAuthException.Contains(dirName) && !(dirSize == 0 && filterOptions.ShowNullDirectory))
                            {
                                DataRow drDirInfo = DirectoryInformation.NewRow();
                                drDirInfo.ItemArray = new Object[] { name, SetBytes, Convert.ToDouble(dirSize), dirInfo.Attributes.ToString() };

                                DirectoryInformation.Rows.Add(drDirInfo);
                            }
                            this.BeginInvoke(new UIDelegate(
                            delegate
                            {
                                pbOverall.Increment(1);
                            }));

                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    lstAuthException.Add(currDirectory);
                }
                catch (Exception)
                {
                }

                dirInfo = new DirectoryInfo(currDirectory);
                try
                {
                    foreach (FileInfo fi in dirInfo.GetFiles())
                    {
                        if (fi.Length >= filterOptions.FilterSize)
                        {
                            if ((filterOptions.HasIncludeFilesSet && !filterOptions.IncludeList.Contains(fi.Extension))
                                || (filterOptions.HasExcludeFilesSet && filterOptions.ExcludeList.Contains(fi.Extension)))
                                continue; 
                            
                            dirSize = fi.Length;
                            if (DirectoryDictionary.ContainsKey(fi.Extension))
                            {
                                DirectoryDictionary[fi.Extension] += fi.Length;
                            }
                            else
                            {
                                DirectoryDictionary.Add(fi.Extension, fi.Length);
                            }

                            FileSize fsKey = new FileSize(fi.Extension, DirectoryDictionary[fi.Extension], "");
                            if (!FileList.ContainsKey(fsKey))
                                FileList.Add(fsKey, new List<FileSize>());

                            FileList[fsKey].Add(new FileSize(fi.Name, fi.Length, fi.DirectoryName));

                            if (!lstAuthException.Contains(currDirectory)  && !(dirSize == 0 && filterOptions.ShowNullDirectory))
                            {
                                DataRow drDirInfo = DirectoryInformation.NewRow();

                                string SetBytes = convertSize(dirSize);

                                drDirInfo.ItemArray = new Object[] { fi.Name, SetBytes, Convert.ToDouble(dirSize), fi.Attributes };

                                DirectoryInformation.Rows.Add(drDirInfo);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
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

        private void bwDirAnalyzer_DoWork(object sender, DoWorkEventArgs e)
        {
            lstAuthException.Clear();
            if (SelectedNodeText != DiskSize.MY_COMPUTER)
            {
                ShowDirectorySize();
            }
            else if (SelectedNodeText == DiskSize.MY_COMPUTER)
            {
                // Dislay Drive Info
                ((DiskSize)this.Owner).InitializeDriveChart();
            }

        }

        private void displayUnAuthorizedError()
        {
            if (lstAuthException.Count > 0)
            {
                string dirNames = String.Join("\n\r", lstAuthException.ToArray(), 0, (lstAuthException.Count > 5 ? 5 : lstAuthException.Count));
                lstAuthException.Clear();

                MessageBox.Show("You do not have sufficient permissions to access following directories: \n\r"
                    + dirNames + ((lstAuthException.Count > 5) ? "\n\r and More..." : String.Empty),
                    "Un Authorized", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void CalculateDirectorySize_FormClosing(object sender, FormClosingEventArgs e)
        {
            abortFlag = true;

            if (bwDirAnalyzer.IsBusy)
                bwDirAnalyzer.CancelAsync();

            displayUnAuthorizedError();
        }

        private void bwDirAnalyzer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }
    }

    public class FileSize : IComparer<FileSize>, IEqualityComparer<FileSize>
    {
        public FileSize(string fileName, long size, string path)
        {
            FileName = fileName;
            Size = size;
            Path = path;
        }

        public string FileName;
        public long Size;
        public string Path;

        #region IComparer<FileSize> Members

        public int Compare(FileSize x, FileSize y)
        {
            return y.Size.CompareTo(x.Size);
        }

        #endregion

        #region IEqualityComparer<FileSize> Members

        public bool Equals(FileSize x, FileSize y)
        {
            return x.FileName.Equals(y.FileName);
            //throw new NotImplementedException();
        }

        public int GetHashCode(FileSize obj)
        {
            return obj.FileName.GetHashCode();
        }

        #endregion
    }

}
