using System;

namespace DLL
{
    class ExcelFile
    {
        Microsoft.Office.Interop.Excel.Application app;
        Microsoft.Office.Interop.Excel._Workbook workBook;
        Microsoft.Office.Interop.Excel._Worksheet workSheet;
        Microsoft.Office.Interop.Excel.Range range;
        object missingValue = System.Reflection.Missing.Value;
        private string[,] className;
        private string[,] timeSpent;
        private string path;
        private int totalNumberOfMethods;

        public ExcelFile(int totalNumberOfMethods)
        {
            //initialize the total number of methods
            this.totalNumberOfMethods = totalNumberOfMethods;

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

            //Create an array to add multiple values 
            //For classes name           
            className = new string[totalNumberOfMethods, 1];
            //For time spent to run the chosen class
            timeSpent = new string[totalNumberOfMethods, 1];

            //initialize the path
            path = "";

            //AutoFit columns A and B
            range = workSheet.Range["A1", "B1"];
            range.EntireColumn.AutoFit();

            
        }

        /// <summary> Adding saving path for the file </summary>
        /// <param name="path">  path of file </param>
        public void AddPath (string path)
        {
            this.path = path;
        }

        /// <summary> Save the file </summary>
        /// <param name="path"> path of file </param>
        /// <param name="fileName"> name of file </param>
        public void SaveFile (string path, string fileName)
        {
            app.Visible = false;
            app.UserControl = false;
            try
            {
                workBook.SaveAs(path+fileName+".xls");
            }
            catch (Exception)
            {

            }
            workBook.Close();
        }
                
        /// <summary> Add the name class on a specific raw </summary>
        /// <param name="nameClass"> name of the class </param>
        /// /// <param name="row"> the row number you want to insert the class name on </param>
        public void AddClassName(string nameClass, int row)
        {
            className[row, 0] = nameClass;
            //Fill with the name of the class name
            workSheet.Range["A"+row].Value2 = className;
        }
        
        /// <summary> Add the time spent on a specific row </summary>
        /// <param name="duration"> time spent to run a certain class </param>
        /// /// <param name="row"> the row number you want to insert the time spent on </param>
        public void AddTime(int duration, int row)
        {
            timeSpent [row, 0] = duration.ToString();
            //Fill with the time specific for all the classes
            workSheet.Range["B"+row].Value2 = timeSpent;
        }
    }
}
