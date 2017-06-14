using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corrida
{
    class Competidor
    {
        public string name;
        public double tp1, tp2, tp3;
        public double calte()
        {
            double[] tempos = new double[3] { tp1, tp2, tp3 };
            Array.Sort(tempos);
            double calc = tempos[0] + tempos[1];

            return calc;

        }
    }
}
