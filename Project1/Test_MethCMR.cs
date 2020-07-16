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
        double ta = 0.001;
        int tH = 18;
        double tRw = 0.1;
        double tF = 0.5235987756;
        int tRe = 300;
        int tBj = 1;
        int tKh = 1000;
        int tPpl = 150;
        int tPzab = 50;
        int tu = 100;

        
        [Test]
        public void Test_CMR_Hd()
        {
            double checkHd = 5692.0998;
            
            double resultHd = MethCMR.CMR_Hd(tH,tRw,ta);
            resultHd = Math.Round(resultHd, 4);

            Assert.AreEqual(checkHd,resultHd);
        }

        [Test]
        public void Test_CMR_A()
        {
            double checkA = 1.04595682254258;
            checkA = Math.Round(checkA, 5);

            double resultA = MethCMR.CMR_A( ta ,tF);
            resultA = Math.Round(resultA, 5);

            Assert.AreEqual(checkA,resultA);


        }

        [Test]
        public void Test_CMR_S()
        {
            double checkS = -0.001570246023;
            checkS = Math.Round(checkS, 5);
            double resultS = MethCMR.CMR_S(tH, tRw, ta, tF);

            Assert.AreEqual(checkS, resultS);

        }

        [Test]
        public void Test_CMR_Jd()
        {
            double checkJd = 0.124925086772432;
            checkJd = Math.Round(checkJd, 5);
            double resultJd = MethCMR.CMR_Jd(tH, tRw, ta, tF, tRe);
            Assert.AreEqual(checkJd, resultJd);
        }

        [Test]
        public void Test_CMR_Qj()
        {
            double checkQj = 122.142941982823;
            checkQj = Math.Round(checkQj, 4);
            
            double resultQj = MethCMR.CMR_Qj(tH, tRw, ta, tF, tRe, tBj, tKh, tPpl, tPzab, tu);

            Assert.AreEqual(checkQj, resultQj);

        }

    }
}
