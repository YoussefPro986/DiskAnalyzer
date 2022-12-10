using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace DiskAnalyzer
{
    public partial class FilterOptions : Form
    {
        public FilterOptions()
        {
            InitializeComponent();
        }

        private void FilterOptions_Load(object sender, EventArgs e)
        {
                comboBoxSize.SelectedIndex = 0;
            comboBoxBytes.SelectedIndex = 0;
            comboBoxOwner.Items.Clear();
            
            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject envVar in searcher.Get())
            {
                comboBoxOwner.Items.Add(envVar["Name"]);
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            excludeList.Clear();
            includeList.Clear();
            size = 0;

            if (radioButtonExclude.Checked)
            {
                List<string> tempList = new List<string>();
                if (textBoxExclude.TextLength == 0)
                    tempList.Clear();
                else
                {
                    tempList.Clear();
                    tempList.AddRange(textBoxExclude.Text.Split(','));
                }

                var strList = from extn in tempList
                              where extn.StartsWith(".")
                              select extn.Trim();

                if (strList.Count() == tempList.Count())
                    excludeList = new List<string>(strList);
                else
                    MessageBox.Show("Invalid Exclude Files list, It will not be used to filter the search.");
            }
            else
            {

                List<string> tempList = new List<string>();
                if (textBoxInclude.TextLength == 0)
                    tempList.Clear();
                else
                {
                    tempList.Clear();
                    tempList.AddRange(textBoxInclude.Text.Split(','));
                }

                var strList = from extn in tempList
                              where extn.StartsWith(".")
                              select extn.Trim();

                if (strList.Count() == tempList.Count())
                    includeList = new List<string>(strList);
                else
                {
                    MessageBox.Show("Invalid Include Files list, It will not be used to filter the search.");
                }
            }

            size = long.Parse(textBoxSize.TextLength == 0 ? "0" : textBoxSize.Text);
            switch (comboBoxBytes.Text)
            {
                case "KB":
                    size = size * 1024;
                    break;
                case "MB":
                    size = size * 1024 * 1024;
                    break;
                case "GB":
                    size = size * 1024 * 1024 * 1024;
                    break;
            }

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void FilterOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                this.Hide();
        }


        public bool OpenExportedFile
        {
            get { return checkBoxExportToExcel.Checked; }
        }

        public bool ShowNullDirectory
        {
            get { return checkBoxZeroSize.Checked; }
        }

        public bool HasIncludeFilesSet
        {
            get { return includeList.Count > 0; }
        }

        public bool HasExcludeFilesSet
        {
            get { return !HasIncludeFilesSet && excludeList.Count > 0; }
        }

        private List<string> includeList = new List<string>();
        public List<string> IncludeList
        {
            get { return includeList; }
        }

        public bool RedoDirectoryAnalyze
        {
            get { return checkBoxReAnalyze.Checked; }
        }

        private List<string> excludeList = new List<string>();
        public List<string> ExcludeList
        {
            get { return excludeList; }
        }

        private long size;
        public long FilterSize
        {
            get
            {
                return size;
            }
        }

        private void textBoxSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (Char.IsLetter((char)e.KeyValue))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }


    }
}
