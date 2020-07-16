using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    [TestFixture]
    class Test_MethVDV
    {
        double Rw = 0.1;
        int h = 18;
        double f = 0.5235987756;
        int Re = 300; 
        int Bj = 1;
        int Kh = 1000;
        int Ppl = 150;
        int Pzab = 50;
        int u = 100;
        [Test]
        public void Test_VDV_S()
        {
            double checkS = -0.36087936442088;
            checkS = Math.Round(checkS, 4);
            double resultS = MethVDV.VDV_S(Rw,h,f);

            Assert.AreEqual(checkS, resultS);
        }

        [Test]
        public void Test_VDV_Jd()
        {
            double checkJd = 0.124925086772432;
            checkJd = Math.Round(checkJd, 4);
            double resultJd = MethVDV.VDV_Jd(h, Rw,f,Re);
            Assert.AreEqual(checkJd, resultJd);
        }

        [Test]
        public void Test_VDV_Qj()
        {
            double checkQj = 127.8831997;
            checkQj = Math.Round(checkQj, 1);
            double resultQj = MethVDV.VDV_Qj(h, Rw, f, Re, Bj, Kh,Ppl,Pzab,u );

            Assert.AreEqual(checkQj, resultQj);
        }

    }
}
