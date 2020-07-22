using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodic
{
    public class MethGRP
    {

        public static double GRPmain(int Kpor, double Ct, double k, int u, int Re, int Xf)
        {
            double Fc;
            double Tpss = MethGRP.GRP_Tpss(Kpor, Ct, k, u, Re);
            double Td = MethGRP.GRP_Td(Tpss, Kpor, Ct, k, u, Re, Xf);
            double Pd;
            return 0;
        }

        public static double GRP_Tpss(int Kpor, double Ct, double k, int u, int Re)
        {
            double Tpss = (((0.12 * Kpor * u * (Ct / 14.7) * Math.PI * Math.Pow(Re / 0.3048, 2)) / (0.000263679 * k)) / 24);

            return Tpss;
        }


        public static double GRP_Td(double Tpss, int Kpor, double Ct, double k, int u, int Re, int Xf)
        {



            double Td = (0.0063283 * k * Tpss) / (Kpor * u * (Ct / 14.7) * Math.Pow((Xf / 0.3048), 2));

            return Td;
        }
        public static double GRP_Pd(double Td, double Fc)
        {

            return 0;
        }



    }
}
