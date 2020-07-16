using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class MethVDV
    {
        public static double VDV_S(double Rw, double h, double f)
        {
            double S = -Math.Log((h / (4 * Rw * Math.Cos(f))) * Math.Pow((0.454 * Math.Sin(2 * Math.PI * Rw / h)), Math.Cos(f)));
            S = Math.Round(S, 4);
            return S;
        }


        public static double VDV_Jd(int h, double Rw, double f, int Re)
        {
            double S = VDV_S(Rw, h, f);
            double Jd = 1 / (Math.Log(Re / Rw) + S);
            Jd = Math.Round(Jd, 5); 
            return Jd;
        }

        public static double VDV_Qj(int h, double Rw,  double f, int Re, int Bj, int Kh, int Ppl, int Pzab, int u)
        {
            double Jd = VDV_Jd(h, Rw, f, Re);
            double Qj = Jd * (Kh * h * (Ppl - Pzab)) / (18.41 * u * Bj);
            Qj = Math.Round(Qj, 1);
            return Qj;
        }
    }
}
