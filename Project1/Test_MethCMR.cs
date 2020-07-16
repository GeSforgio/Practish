using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project1
{
    [TestFixture]
    class Test_MethCMR
    {
        double a = 0.001;
        int H = 18;
        double Rw = 0.1;
        double F = 0.5235987756;
        int Re = 300;
        int Bj = 1;
        int Kh = 1000;
        int Ppl = 150;
        int Pzab = 50;
        int u = 100;

        
        [Test]
        public void Test_CMR_Hd()
        {
            double checkHd = 5692.0998;
            
            double resultHd = MethCMR.CMR_Hd(H,Rw,a);
            resultHd = Math.Round(resultHd, 4);

            Assert.AreEqual(checkHd,resultHd);
        }

        [Test]
        public void Test_CMR_A()
        {
            double checkA = 1.04595682254258;
            checkA = Math.Round(checkA, 5);

            double resultA = MethCMR.CMR_A( a ,F);
            resultA = Math.Round(resultA, 5);

            Assert.AreEqual(checkA,resultA);


        }

        [Test]
        public void Test_CMR_S()
        {
            double checkS = -0.001570246023;
            checkS = Math.Round(checkS, 5);
            double resultS = MethCMR.CMR_S(H, Rw, a, F);

            Assert.AreEqual(checkS, resultS);

        }

        [Test]
        public void Test_CMR_Jd()
        {
            double checkJd = 0.124925086772432;
            checkJd = Math.Round(checkJd, 5);
            double resultJd = MethCMR.CMR_Jd(H, Rw, a, F, Re);
            Assert.AreEqual(checkJd, resultJd);
        }

        [Test]
        public void Test_CMR_Qj()
        {
            double checkQj = 122.142941982823;
            checkQj = Math.Round(checkQj, 4);
            
            double resultQj = MethCMR.CMR_Qj(H, Rw, a, F, Re, Bj, Kh, Ppl, Pzab, u);

            Assert.AreEqual(checkQj, resultQj);

        }

    }
}
