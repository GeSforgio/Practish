using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodicTests
{
    class Program
    {
        private static Application oXL;
        private static Microsoft.Office.Interop.Excel._Workbook oWB;
        private static Microsoft.Office.Interop.Excel._Worksheet oSheet1;
        

        static void Main(string[] args)
        {

             exbook2();
        }




        public static void exbook2()
        {
            string pathToFile = @"C:\Users\book1.xlsx";
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(pathToFile, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
            int numCol = 2;
            Range usedColumn = ObjWorkSheet.UsedRange.Range[1,2];
            System.Array myvalues = (System.Array)usedColumn.Cells.Value2;
            string[] strArray = myvalues.OfType<object>().Select(o => o.ToString()).ToArray();
            ObjExcel.Quit();
            int i = 0;
            i = strArray.Length;
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(strArray[j]);

            }
            Console.ReadLine();
        }

        public void exbook()
        {
            oXL = new Microsoft.Office.Interop.Excel.Application();
            oXL.Visible = true;
            oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
            oSheet1 = (Microsoft.Office.Interop.Excel.Worksheet)oWB.Sheets[1];
            oSheet1.Cells[1, 1] = "First Name";
            oSheet1.Cells[1, 2] = "Last Name";
            oSheet1.Cells[1, 3] = "Full Name";
            oSheet1.Cells[1, 4] = "Salary";
            oSheet1.get_Range("A1", "D1").Font.Bold = true;
            oSheet1.get_Range("A1", "D1").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            string[,] saNames = new string[5, 2];

            saNames[0, 0] = "John";
            saNames[0, 1] = "Smith";
            saNames[1, 0] = "Tom";
            saNames[1, 1] = "Brown";
            saNames[2, 0] = "Sue";
            saNames[2, 1] = "Thomas";
            saNames[3, 0] = "Jane";
            saNames[3, 1] = "Jones";
            saNames[4, 0] = "Adam";
            saNames[4, 1] = "Johnson";
        }
           
    }
}
