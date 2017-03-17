using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace DLL
{
    class ExcelFile
    {
        Microsoft.Office.Interop.Excel.Application app;
        Microsoft.Office.Interop.Excel._Workbook workBook;
        Microsoft.Office.Interop.Excel._Worksheet workSheet;
        Microsoft.Office.Interop.Excel.Range range;        
        object missingValue = System.Reflection.Missing.Value;

        public ExcelFile()
        {
            Console.WriteLine("I'm doing something!");
            //Start Excel and get Application object
            app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;

            //Get a new workbook
            workBook = app.Workbooks.Add("");
            workSheet = workBook.ActiveSheet;

            //Add table headers going cell by cell
            workSheet.Cells[1, 1] = "Class name";
            workSheet.Cells[1, 2] = "Time";

            //Format A1 and B1 as bold, vertical alignment = center.
            workSheet.Range["A1", "B1"].Font.Bold = true;
            workSheet.Range["A1", "B1"].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Create an array to multiple values at once
            string[,] className = new string[10, 1];
            className[0, 0] = "Smart Bubble Sort";
            className[1, 0] = "Bubble Sort";

            string[,] timeSpent = new string[10,1];
            timeSpent[0, 0] = "0.12";

            //Fill with the name of the class name
            workSheet.Range["A2", "A10"].Value2 = className;

            //Fill with the time specific for all the classes
            workSheet.Range["B2", "B10"].Value2= timeSpent;

            //AutoFit columns A and B
            range = workSheet.Range["A1", "B1"];
            range.EntireColumn.AutoFit();

            app.Visible = false;
            app.UserControl = false;
            try
            {
                workBook.SaveAs("C:\\Users\\codru\\Desktop\\ExcelData.xls");
            }
            catch (Exception)
            {

            }
            workBook.Close();
        }


    }
}
