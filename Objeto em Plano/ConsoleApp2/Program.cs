using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int H = 600, W = 800;

            Obj2D objt = new Obj2D();

            Console.Write("Digite X inicial: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Digite Y inicial: ");
            int y = int.Parse(Console.ReadLine());


            objt.x = x;
            objt.y = y;


            Console.Write("Aperte Tecla ");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                if (direcao == ConsoleKey.RightArrow)
                    obj.AndDir();

                Console.WriteLine(obj.Coordenadas());
            }
        }
    }
}