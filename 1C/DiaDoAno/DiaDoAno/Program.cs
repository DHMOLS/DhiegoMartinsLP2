using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, diadomes, dia;
            string nomedomes, data, mes;
            i = 0;
            Console.WriteLine("Informe a data");
            data = (Console.ReadLine());

            dia = int.Parse(data.Substring(0, 2));


            if (dia < 10)
            {
                mes = data.Substring(5, 4);
            }
            else
            {
                mes = data.Substring(6, 4);
            }


            diadomes = dia;
            mes = mes.ToUpper();

            if (mes == "JANE")
            {
                nomedomes = "Janeiro";
                i = i + 0;
                i = i + dia;

            }

            else if (mes == "FEVE")
            {
                nomedomes = "Fevereiro";
                i = i + 31;
                i = i + dia;

            }
            else if (mes == "MARÇ")
            {
                nomedomes = "Março";
                i = i + 31 + 28;
                i = i + dia;

            }

            else if (mes == "ABRI")
            {
                nomedomes = "Abri";
                i = i + 31 + 28 + 31;
                i = i + dia;
            }

            else if (mes == "MAIO")
            {
                nomedomes = "Maio";
                i = i + 31 + 28 + 31 + 30;
                i = i + dia;
            }

            else if (mes == "JUNH")
            {
                nomedomes = "Junho";
                i = i + 31 + 28 + 31 + 30 + 31;
                i = i + dia;
            }


            else if (mes == "JULH")
            {
                nomedomes = "Julho";
                i = i + 31 + 28 + 31 + 30 + 31 + 30;
                i = i + dia;
            }

            else if (mes == "AGOS")
            {
                nomedomes = "Agosto";
                i = i + 31 + 28 + 31 + 30 + 31 + 30 + 31;
                i = i + dia;
            }

            else if (mes == "SETE")
            {
                nomedomes = "Setembro";
                i = i + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
                i = i + dia;
            }

            else if (mes == "OUTU")
            {
                nomedomes = "Outubro";
                i = i + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
                i = i + dia;
            }

            else if (mes == "NOVE")
            {
                nomedomes = "Novembro";
                i = i + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
                i = i + dia;
            }

            else
            {
                nomedomes = "Dezembro";
                i = i + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30;
                i = i + dia;
            }

            Console.WriteLine(i + "º dia do ano");
        }
    }
}
