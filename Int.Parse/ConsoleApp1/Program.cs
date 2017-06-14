using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuIntParse
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(2 * MeuIntParse(Console.ReadLine()));
        }

        public static int MeuIntParse(string numerostring)
        {
            int conta = 1, x = 0; ;
            for (int i = numerostring.Length - 1; i >= 0; i--)
            {
                x += (numerostring[i] - '0') * conta;
                conta*= 10;
            }
            return x;
        }
    }
}