using NUnit.Framework;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Methodic;

using Excel = Microsoft.Office.Interop.Excel;
namespace MethodicTests
{
    [TestFixture]
    class Test_MethGRP
    {
        int Kpor = 16;
        double Ct = 0.0002;
        double k = 1.5;
        int Xf = 104;
        double Fcd = 1.03;
        double Wf = 2.75;
        int Kpropp = 292942;
        int Nfrac = 3;
        int Hnet = 15;
        double u0 = 0.7;
        double uw = 0.55;
        double bw = 1.42;
        int u = 100;
        int Re = 300;

        [Test]
        public void Test_GRP_Tpss()
        {
            double checkTPSS = 837526.0089;
            double resultTPSS = MethGRP.GRP_Tpss(Kpor, Ct, k, u, Re);
            Assert.AreEqual(checkTPSS, resultTPSS, 0.0001);
        }

        [Test]
        public void Test_GRP_Td()
        {
            double Tpss = 837526.0089;
            double checkTd = 3.13694731;
            double resultTd = MethGRP.GRP_Td(Tpss, Kpor, Ct, k, u, Re, Xf);
            Assert.AreEqual(checkTd, resultTd, 0.0001);
            Assert.AreEqual(checkTd, resultTd, 0.0001);
        }

        private static Application oXL;
        private static Excel._Workbook oWB;
        private static Excel._Worksheet oSheet1;
        private object _ObjWorkSheet;

        [Test]
        public void Test_GRP_Pd()
        {
            string pathToFile = @"C:\Users\book2.xlsx";
            Excel.Application ObjExcel = new Excel.Application();
            Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(pathToFile, 0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Excel.Worksheet ObjWorkSheet;
            ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[1];
         

            int lengthcolumn = 8;
            int lengthstr = 46;
            for (int i = 2; i < lengthcolumn; i++)
            {
                for (int j = 2; j < lengthstr; j++)
                {
                    int k = i - 2;
                    double td = (ObjWorkSheet.Cells[j,1 ] as Excel.Range).Value;
                    Console.WriteLine(td);
                    double fc = (ObjWorkSheet.Cells[1, i] as Excel.Range).Value;
                    Console.WriteLine(fc);
                    double pd = (ObjWorkSheet.Cells[j, i] as Excel.Range).Value;

                    Console.WriteLine(pd);

                }
            }
            
            ObjWorkBook.Close(false, Type.Missing, Type.Missing);
            ObjExcel.Quit();
        }

    }
}
