using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class MethCMR
    {
        public static double CMR_Hd(int h, double Rw, double a)
        {
            double Hd = (h / Rw) * (1 / Math.Sqrt(a));
            return Hd;
        }

        public static double CMR_A(double a , double f)
        {
            double A = (180 / Math.PI) * (Math.Atan(Math.Sqrt(a) * Math.Tan(f)));
            return A;
        }


    public static double CMR_S(int h, double Rw, double a , double f)
        {
            double sHd = CMR_Hd(h, Rw, a);
            double sA = CMR_A(a, f);
            double S = -Math.Pow((sA/ 41), 2.06) - Math.Pow((sA/56),1.865) * Math.Log10(sHd/100);
            
            return S;
        }

        public static double CMR_Jd(int h, double Rw, double a, double f, int Re)
        {
            double JdS = CMR_S(h, Rw, a, f);
            double Jd = 1 / (Math.Log(Re / Rw) + JdS);
            
            return Jd;
        }

        public static double CMR_Qj(int h, double Rw, double a, double f, int Re, int Bj, int Kh, int Ppl, int Pzab, int u)
        {
            double Jd = CMR_Jd(h, Rw, a, f, Re);
            double Qj = Jd * (Kh * h * (Ppl - Pzab)) / (18.41 * u * Bj);
            
            return Qj;
        }
    }
}
