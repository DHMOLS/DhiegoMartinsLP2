using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corrida
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr;

            Console.WriteLine("Informe o número de competidores?");
            nr = int.Parse(Console.ReadLine());

            double menorTempo = double.MaxValue;
            string vencedor = "";

            Competidor[] competidores = new Competidor[nr];

            for (int i = 0; i < nr; i++)
            {
                competidores[i] = new Competidor();

                Console.WriteLine("\nInsira o nome do competidor {0}", i + 1);
                competidores[i].name = Console.ReadLine();
            }

            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine("\nInsira o 1º tempo do competidor {0}", competidores[i].name);
                competidores[i].t1 = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine("\nInsira o 2º tempo do competidor {0}", competidores[i].name);
                competidores[i].t2 = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine("\nInsira o 3º tempo do competidor {0}", competidores[i].name);
                competidores[i].t3 = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nr; i++)
            {
                if (competidores[i].calte() < menorTempo)
                {
                    menorTempo = competidores[i].calte();

                    vencedor = competidores[i].name;
                }
            }

            Console.WriteLine("\n{0}", vencedor);

        }
    }
}
