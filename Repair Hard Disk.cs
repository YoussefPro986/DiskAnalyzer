using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;
using System.Diagnostics;

namespace DiskAnalyzer
{
    public partial class CHKDSK : Form
    {
        public CHKDSK()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DiskInfo32.Text = "Serial Number of Hard Disk: " + GetHardDiskDSerialNumber("");
        }

        public string GetHardDiskDSerialNumber(string drive)

        {
            //Check to see if the user provided a drive letter
            //If not default it to "C"
            if (string.IsNullOrEmpty(drive) || drive == null)
            {
                drive = "C";
            }
            //Create our ManagementObject, passing it the drive letter to the
            //DevideID using WQL
            ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            //bind our management object
            disk.Get();
            //Return the serial number
            return disk["VolumeSerialNumber"].ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            {
                double size = 0;
                size = Math.Round(GetHDDSize("C") / 1024 / 1024 / 1024);
                //1 KB = 1024 - KiloByte
                //1 MB = 1024 ^ 2 - MegaByte
                //1 GB = 1024 ^ 3 - GigaByte
                //1 TB = 1024 ^ 4 - TeraByte
                //1 PB = 1024 ^ 5 - PetaByte
                //1 EB = 1024 ^ 6 - ExaByte
                //1 ZB = 1024 ^ 7 - ZettaByte
                //1 YB = 1024 ^ 8 - YottaByte
                //1 BB = 1024 ^ 9 - BrontoByte
                DiskInfo32.Text = "Hard Disk Size = " + size.ToString() + " GB";
            }
        }

        public double GetHDDSize(string drive)
        {
            //Check to see if the user provided a drive letter
            //If not default it to "C"
            if (string.IsNullOrEmpty(drive) || drive == null)
            {
                drive = "C";
            }
            //Create our ManagementObject, passing it the drive letter to the
            //DevideID using WQL
            ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            //Bind our management object
            disk.Get();
            //Return the HDD's initial size
            return Convert.ToDouble(disk["Size"]);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            {
                double size = 0;
                size = Math.Round(GetHDDFreeSpace("C") / 1024 / 1024 / 1024);
                //1 KB = 1024 - KiloByte
                //1 MB = 1024 ^ 2 - MegaByte
                //1 GB = 1024 ^ 3 - GigaByte
                //1 TB = 1024 ^ 4 - TeraByte
                //1 PB = 1024 ^ 5 - PetaByte
                //1 EB = 1024 ^ 6 - ExaByte
                //1 ZB = 1024 ^ 7 - ZettaByte
                //1 YB = 1024 ^ 8 - YottaByte
                //1 BB = 1024 ^ 9 - BrontoByte

                DiskInfo32.Text = "Hard Disk Free Space = " + size.ToString() + " GB";
            }
        }

        public double GetHDDFreeSpace(string drive)
        {
            //Check to see if the user provided a drive letter
            //If not default it to "C"
            if (string.IsNullOrEmpty(drive) || drive == null)
            {
                drive = "C";
            }
            //Create our ManagementObject, passing it the drive letter to the
            //DevideID using WQL
            ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            //Bind our management object
            disk.Get();
            //Return the HDD's FreeSpace
            return Convert.ToDouble(disk["FreeSpace"]);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            {
                string strDriveType = null;
                switch (GetDriveType("C"))
                {
                    case "0":
                        strDriveType = "Unknown";
                        break;
                    case "1":
                        strDriveType = "Readable";
                        break;
                    case "2":
                        strDriveType = "Writable";
                        break;
                    case "3":
                        strDriveType = "Read / Write Supported";
                        break;
                    case "4":
                        strDriveType = "Write Once";

                        break;
                }

                DiskInfo32.Text = "Hard Disk Drive Type = " + strDriveType;
            }
        }

        private string GetDriveType(string drive)
        {
            //Check to see if the user provided a drive letter
            //If not default it to "C"
            if (string.IsNullOrEmpty(drive) || drive == null)
            {
                drive = "C";
            }
            //Create our ManagementObject, passing it the drive letter to the
            //DevideID using WQL
            ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            //Bind our management object
            disk.Get();
            //Return the HDD's FreeSpace
            return disk["DriveType"].ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            DiskInfo32.Text = "Hard Disk File System = " + GetDiskFileSystem("C");
        }

        private string GetDiskFileSystem(string drive)
        {
            //Check to see if the user provided a drive letter
            //If not default it to "C"
            if (string.IsNullOrEmpty(drive) || drive == null)
            {
                drive = "C";
            }
            //Create our ManagementObject, passing it the drive letter to the
            //DevideID using WQL
            ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            //Bind our management object
            disk.Get();
            //Return the HDD's FreeSpace
            return disk["FileSystem"].ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Process.Start("dfrgui.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk A.bat");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk B.bat");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk C.bat");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk D.bat");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk E.bat");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk F.bat");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk G.bat");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk X.bat");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk H.bat");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk I.bat");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk J.bat");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk K.bat");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk L.bat");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk M.bat");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk N.bat");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk Y.bat");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk O.bat");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk P.bat");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk Q.bat");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk R.bat");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk S.bat");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk T.bat");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk U.bat");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk W.bat");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk V.bat");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk Z.bat");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\chkdsk C.bat");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Process.Start(@"Data\Scripts\sfc - Admin.lnk");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How to use this tool simply. Through this tool, you have several options to fix hard disk problems, as well as the Windows operating system, and also after additional tools through which you can provide some information that may interest you about the hard disk.,","Help Viewer 1.0",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for supporting our app. You will be redirected to the developer's page while you would like to message them about the app", "Program support", MessageBoxButtons.OK, MessageBoxIcon.Question);

            Process.Start("https://www.facebook.com/youssefpro842");

            checkBox1.Enabled = false;
        }

        private void CHKDSK_Load(object sender, EventArgs e)
        {

        }
    }
}
