using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConversorMedidas
{
    static class Conversor
    {
        public static double KgPG(double x)
        {
            return x * 1000;
        }
        public static double GPKg(double x)
        {
            return x / 1000;
        }
        public static double KgPT(double x)
        {

            return x * 1000;
        }
        public static double TPKg(double x)
        {
            return x / 1000;
        }
        public static double KgPLb(double x)
        {
            return x * 2.2046;
        }
        public static double LbPKg(double x)
        {
            return x / 2.2046;
        }
        public static double CPF(double x)
        {
            return x * 1.8 + 32;
        }
        public static double FPC(double x)
        {
            return (x - 32) / 1.8;
        }
        public static double CPK(double x)
        {
            return x + 273;
        }
        public static double KPC(double x)
        {
            return x - 273;
        }
        public static double FPK(double x)
        {
            x = FPC(x);
            return CPK(x);
        }
        public static double KPF(double x)
        {
            x = KPC(x);
            return CPF(x);
        }
        public static double MPKm(double x)
        {
            return x / 1000;
        }
        public static double KmPM(double x)
        {
            return x * 1000;
        }
        public static double MPPes(double x)
        {
            return x * 3.2808;
        }
        public static double PesPM(double x)
        {
            return x / 3.2808;
        }
        public static double PolPPes(double x)
        {
            return x * 0.083333;
        }
        public static double PesPPol(double x)
        {
            return x * 12.000;
        }
        public static double MPPol(double x)
        {
            return x * 39.370;
        }
        public static double PolPM(double x)
        {
            return x / 39.370;
        }
        public static double MilhaPKm(double x)
        {
            return x / 0.62137;
        }
        public static double KmPMilha(double x)
        {
            return x * 0.62137;
        }

        
    }
}
