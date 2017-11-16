using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a marca");
            string Marca = Console.ReadLine();
            Console.WriteLine("Informe o modelo");  
            string Modelo = Console.ReadLine();
            Console.WriteLine("Informe a cor");
            string Cor = Console.ReadLine();
            Console.WriteLine("Informe a placa");
            string Placa = Console.ReadLine();
            Console.WriteLine("Informe a potência");
            int potencia = int.Parse(Console.ReadLine());


            SqlConnection conexao = new SqlConnection("Data Source=EN2LIC_11;Initial Catalog=AULA_LP2;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;


            cmd.CommandText = String.Format("INSERT INTO Carro (Marca, Modelo, Cor, Placa, Potencia) VALUES ('{0}', '{1}', '{2}', '{3}', {4});", Marca, Modelo, Placa, Cor, potencia);
            conexao.Open();


            cmd.ExecuteNonQuery();
            conexao.Close();

            Console.WriteLine("Ok");
            Console.ReadKey();
        }
    }
}