# DiskAnalyzer

Introduction

Disk Analyzer enables you to understand how much space the files and directories on your disk have taken up, and helps you find files and folders that you no longer use. The tool analyses your disk drives and collects statistics of directory sizes and files sizes by type, which you can view as overview charts and details tables.

I am using the Pie Chart control developed by Julijan Sribar, for displaying the results. Really worth having a look. It's one of the best implementations of Pie Chart controls.

Also, I am using the tree grid view, which allows to display files by extension, implemented by Mark Rideout. You can visit his blog here.

![filetypes](https://user-images.githubusercontent.com/72635460/198359532-cfa85793-028c-4ca7-bd15-4dd7870f4580.JPG)

Also, this program allows you to set up filters for the directories and files to be analyzed. I should agree, this needs to be enhanced to allow more customizability.

![options](https://user-images.githubusercontent.com/72635460/198359993-f6caa309-544c-4bef-9e6e-4aa27f661b81.JPG)

Background

I was looking for a simple disk analyzer utility to calculate the size of the directory and to do some clean up and to help me organize my files better. I thought it would be good to write one.
Features

    Display size by directory with DataGridView and Pie Chart
    Report size by file extension, with DataGridView and Pie Chart
    Filter options by size; include and exclude file extensions; directories with zero bytes
    Export the results to Excel; this is saved in Excel XML format, using the CarlosAg ExcelXmlWriter library
    Open a file / folder and its parent directory

Using the code

Calculating the size of the directory is done by using a recursive function to calculate the size of each sub-directory, using LINQ:

public long CalculateSize(DirectoryInfo directory)
{
    CurrentDirectory = directory.FullName;
    this.BeginInvoke(new UIDelegate(updateCurrentStatus));
    if (abortFlag) return 0;
    long Size = 0;
    // Add file sizes.
    IEnumerable iEnumSize = from fi in directory.GetFiles() select fi.Lenght;
    Size += iEnumSize.Sum();
  
    // Add subdirectory sizes.
    IEnumerable<long /> iEnumSize = from di in directory.GetDirectories() 
                                       select CalculateSize(di);
    Size += iEnumSize.Sum();
    return Size;
}
Points of interest

Exporting data from DataGridView to Excel:

![excel](https://user-images.githubusercontent.com/72635460/198360777-a1926081-5dc2-48d7-91a9-f3837101c199.JPG)

Below is the section of code to export data from a DataGridView to Excel, using the CarlosAg ExcelXMLWriter library. You can find more details on the CarlosAg ExcelXMLWriter library here. This allows you to create Excel files without using COM objects.

string filename = "myExcel.xls";
                Workbook book = new Workbook();
                book.ExcelWorkbook.ActiveSheetIndex = 1;
                
book.Properties.Author = "Disk Analyzer";
                book.Properties.Title = "Disk Analyzer Report";
                book.Properties.Created = DateTime.Now;


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
  row.Cells.Add(new WorksheetCell(dataGridViewDirectory.Columns[i].Name, 
                                  "HeaderStyle"));
}

// Skip one row, and add some text
row.Index = 2;
for (int i = 0; i < dataGridViewDirectory.Rows.Count; i++)
{
  row = sheet.Table.Rows.Add();
  for (int j = 0; j < dataGridViewDirectory.Columns.Count; j++)
  {
    row.Cells.Add(dataGridViewDirectory.Rows[i].Cells[j].Value.ToString());
  }
}

History

Updated the article source with project and solution files.
