using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {



        public static double CMR_Jd(int h, double Rw, double a, double f, int Re)
        {
            double JdS = MethCMR.CMR_S(h, Rw, a, f);
            double Jd = 1 / (Math.Log(Re / Rw) + JdS);
            Jd = Math.Round(Jd, 5);
            return Jd;
        }

        public static double CMR_Qj(int h, double Rw, double a, double f, int Re, int Bj, int Kh, int Ppl, int Pzab, int u)
        {
            double Jd = CMR_Jd(h, Rw, a, f, Re);
            double Qj = Jd * (Kh * h * (Ppl - Pzab)) / (18.41 * u * Bj);
            Qj = Math.Round(Qj, 4);
            return Qj;
        }


        static void Main(string[] args)
        {
          
        }
    }
}
