using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    [TestFixture]
    class Test_MethOzkan
    {
        double Rw = 0.1;
        int h = 18;
        double a = 0.001;
        double f = 0.5235987756;
        int Re = 300;
        int Bj = 1;
        int Kh = 1000;
        int Ppl = 150;
        int Pzab = 50;
        int u = 100;
        int L = 600;
        int Zw = 9;

        [Test]
        public void Test_Ozkan_S()
        {
            double checkS = -0.8536761537;
            checkS = Math.Round(checkS, 4);
            double resultS = MethOzkan.Ozkan_S(Rw, h, a, L, Zw);

            Assert.AreEqual(checkS, resultS);

        }

        [Test]
        public void Test_Ozkan_Jd()
        {
            double checkJd = 0.1398075133;
            checkJd = Math.Round(checkJd, 5);
            double resultJd = MethOzkan.Ozkan_Jd(Rw, h, a, L, Zw, Re);

            Assert.AreEqual(checkJd, resultJd);
        }

        [Test]
        public void Test_Ozkan_Qj()
        {
            double checkQj = 136.6939294;
            checkQj = Math.Round(checkQj, 1);
            double resultQj = MethOzkan.Ozkan_Qj(Rw, h, a, L, Zw, Re,Bj,Kh,Ppl,Pzab,u);

            Assert.AreEqual(checkQj, resultQj);
        }
    }
}
