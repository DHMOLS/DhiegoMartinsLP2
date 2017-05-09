using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemVogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            int ctd = 0;

            Console.WriteLine("Escreva um texto");
            texto = Console.ReadLine();

            for (int i = 0;  i < texto.Length; i++)
            {
                if (texto[i] == 'A' || texto[i] == 'a')
                ctd = ctd + 1;

                else if (texto[i] == 'E' || texto[i] == 'e')
                    ctd = ctd + 1;

                else if (texto[i] == 'I' || texto[i] == 'i')
                    ctd = ctd + 1;

                else if (texto[i] == 'O' || texto[i] == 'o')
                    ctd = ctd + 1;

                else if (texto[i] == 'U' || texto[i] == 'u')
                    ctd = ctd + 1;

            }

            Console.WriteLine("O número de vogais é {0}", ctd);
            Console.ReadKey();
        }
    }
}
