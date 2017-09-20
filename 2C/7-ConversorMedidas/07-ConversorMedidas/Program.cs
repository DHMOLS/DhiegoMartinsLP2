using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConversorMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt = 42;




            while (opt != 0)
            {
                Console.WriteLine("1-Kilometros para Milhas");
                Console.WriteLine("2-Milhas para Kilometros");
                Console.WriteLine("3-Celsius para Fahrenheit");
                Console.WriteLine("4-Fahrenheit para Celsius");
                Console.WriteLine("5-Kilogramas para Libras");
                Console.WriteLine("6-Libras para Kilogramas");
                Console.WriteLine("0-Sair");
                opt = int.Parse(Console.ReadLine());

                if (opt == 1)
                    Console.WriteLine(Conversor.KmPMilha(double.Parse(Console.ReadLine())));

                else if (opt == 2)
                    Console.WriteLine(Conversor.MilhaPKm(double.Parse(Console.ReadLine())));

                else if (opt == 3)
                    Console.WriteLine(Conversor.CPF(double.Parse(Console.ReadLine())));

                else if (opt == 4)
                    Console.WriteLine(Conversor.FPC(double.Parse(Console.ReadLine())));

                else if (opt == 5)
                    Console.WriteLine(Conversor.KgPLb(double.Parse(Console.ReadLine())));

                else if (opt == 6)
                    Console.WriteLine(Conversor.LbPKg(double.Parse(Console.ReadLine())));                   
            }

        }
    }
}
