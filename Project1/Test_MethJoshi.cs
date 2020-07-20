using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    [TestFixture]
    class Test_MethJoshi
    {
        double Rw = 0.1;
        int h = 18;
        int Re = 300;
        int L = 600;
        int Zw = 9;
        int Bj = 1;
        int Kh = 1000;
        int Ppl = 150;
        int Pzab = 50;
        int u = 100;
        [Test]
        public void Test_Joshi_a()
        {
            double checkA = 381.605894854221;
            
            double resultA = MethJoshi.Joshi_a(Re,L);
            Assert.AreEqual(checkA, resultA, 0.001);

        }
        [Test]
        public void Test_Joshi_S()
        {
            double checkS = -0.8842863611;

            double resultS = MethJoshi.Joshi_S(Rw,h,Re,L,Zw);
            
            Assert.AreEqual(checkS, resultS, 0.001);

        }

        [Test]
        public void Test_Joshi_Jd()
        {
            double checkJd = 0.1404083962;

            double resultJd = MethJoshi.Joshi_Jd(Rw, h, Re, L, Zw);

            Assert.AreEqual(checkJd, resultJd, 0.0001);
        }

        [Test]
        public void Test_Joshi_Qj()
        {
            double checkQj = 137.2814303;

            double resultQj = MethJoshi.Joshi_Qj(Rw, h, Re, L, Zw, Bj, Kh, Ppl, Pzab, u);

            Assert.AreEqual(checkQj, resultQj, 0.01);
        }
    }
}
