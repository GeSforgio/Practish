using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class MethJoshi
    {
        public static double Joshi_a(int Re, int L)
        {
            double a = (L/(2* Math.Sqrt(2)) * Math.Sqrt(1 + Math.Sqrt(1+(64*Math.Pow(((double)Re/L),4)))));
           
            return a;
        }

        public static double Joshi_S(double Rw, int h, int Re, int L, int Zw)
        {
            
            double a = Joshi_a(Re, L);
            double x1 = -Math.Log((double)Re / Rw);
            double x2 = 2 * a + Math.Sqrt(4 * Math.Pow(a, 2) - Math.Pow(L, 2));
            double x3 = Math.Log(x2 / L);
            double x4 = 1 / Math.Sqrt(a);
            double x5 = (double)h / L;
            double x6 = Math.Pow(h, 2) + 4 * Math.Pow((h / 2 - Zw), 2);
            double x7 = h * Rw * (x4 + 1);
            double x8 = Math.Log(x4 * x6 / x7);
            double S = x1 + x3 + x4 * x5 * x8;
            
            return S;
        }

        public static double Joshi_Jd(double Rw, int h, int Re, int L, int Zw)
        {
            double JdS = Joshi_S(Rw,h,Re,L,Zw);
            double Jd = 1 / (Math.Log(Re / Rw) + JdS);

            return Jd;
        }

        public static double Joshi_Qj(double Rw, int h, int Re, int L, int Zw , int Bj, int Kh, int Ppl, int Pzab, int u)
        {
            double Jd = Joshi_Jd(Rw,h,Re,L,Zw);
            double Qj = Jd * (Kh * h * (Ppl - Pzab)) / (18.41 * u * Bj);

            return Qj;
        }

    }
}
