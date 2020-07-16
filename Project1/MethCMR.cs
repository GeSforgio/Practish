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
            S = Math.Round(S, 5);
            return S;
        }

  
    }
}
