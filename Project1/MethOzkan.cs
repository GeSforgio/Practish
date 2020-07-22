using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodic
{
    public class MethOzkan
    {
        public static double Ozkan_S(double Rw, int h, double a, int L, int Zw)
        {
            double S = -Math.Log(L / (4 * Rw)) - (h/(L*Math.Sqrt(a))) * Math.Log( (4*Math.Sin(Math.PI/h*(Zw+((Rw*Math.Sqrt(a))/2))) * (Math.Sin( (Math.PI/h) * ((Rw*Math.Sqrt(a))/2))))) ;
            
            return S;
        }

        public static double Ozkan_Jd(double Rw, int h, double a, int L, int Zw, int Re)
        {
            double S = Ozkan_S(Rw,h,a,L,Zw);
            double Jd = 1 / (Math.Log(Re / Rw) + S);
           
            return Jd;
        }


        public static double Ozkan_Qj(double Rw, int h, double a, int L, int Zw, int Re, int Bj, int Kh, int Ppl, int Pzab, int u)
        {
            double Jd = Ozkan_Jd(Rw, h, a, L, Zw,Re);
            double Qj = Jd * (Kh * h * (Ppl - Pzab)) / (18.41 * u * Bj);
            
            return Qj;
        }
    }
}
