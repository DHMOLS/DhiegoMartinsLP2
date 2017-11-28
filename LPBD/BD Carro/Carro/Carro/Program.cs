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
            int opçao = 10;
            Console.WriteLine("Checar BD - 0");
            Console.WriteLine("Opção 1 - Cadastrar");
            Console.WriteLine("Opção 2 - Remover");
            Console.WriteLine("Opção 3 - Sair");
            opçao = int.Parse(Console.ReadLine());

            SqlConnection conexao = new SqlConnection("Data Source=EN2LIC_02;Initial Catalog=BDCARRO;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;

            if (opçao == 0)
            {
                try
                {
                    cmd.Connection.Open();
                    cmd.CommandText = string.Format("SELECT Id, Marca, Modelo, Cor, Placa, Potencia,FROM CARRO;");
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int Id = reader.GetInt32(0);
                            string Marca = reader.GetString(1);
                            string Modelo = reader.GetString(2);
                            string Cor = reader.GetString(3);
                            string Placa = reader.GetString(4);
                            int Potencia = reader.GetInt32(5);
                            Console.WriteLine("Id {0} Nome {1} Modelo {2}  Marca {3} Cor {4} Placa {5} Potencia {6}", Id, Marca, Modelo, Cor, Placa, Potencia);

                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("NÃO HÁ MAIS NENHUMA TABELA A SER LISTADA\n");
                    cmd.Connection.Close();
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Chamar o corpo de bombeiros");
                }
            }


             else if (opçao == 1)
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

                 cmd.CommandText = String.Format("INSERT INTO Carro (Marca, Modelo, Cor, Placa, Potencia) VALUES ('{0}', '{1}', '{2}', '{3}', {4});", Marca, Modelo, Placa, Cor, potencia);


                 conexao.Open();
                 cmd.ExecuteNonQuery();
                 conexao.Close();


                 Console.WriteLine("Adicionado com sucesso");
                 Console.ReadKey();
             }

             else if (opçao == 2)
             {
                 Console.WriteLine("1-Remover por ID");
                 Console.WriteLine("2-Remover por Potência Máxima");
                 Console.WriteLine("3-Remover por Modelo e Cor");
                 opçao = int.Parse(Console.ReadLine());

                 if (opçao == 1)
                 {
                     Console.WriteLine("Informe o ID");
                     int deleteid = int.Parse(Console.ReadLine());

                     cmd.CommandText = String.Format("DELETE FROM Carro WHERE Id = {0};", deleteid);


                     conexao.Open();
                     cmd.ExecuteNonQuery();
                     conexao.Close();


                     Console.WriteLine("Removido com sucesso por ID");
                     Console.ReadKey();
                 }
                 else if (opçao == 2)
                 {
                     Console.WriteLine("Informe a Potência máxima");

                     int deletepoten = int.Parse(Console.ReadLine());

                     cmd.CommandText = String.Format("DELETE FROM Carro WHERE Potencia < {0};", deletepoten);


                     conexao.Open();
                     cmd.ExecuteNonQuery();
                     conexao.Close();


                     Console.WriteLine("Removido com sucesso por Potência áxima");
                     Console.ReadKey();
                 }

                 else if (opçao == 3)
                 {
                     Console.WriteLine("Informe o Modelo e a Cor");

                     string deletemodel = Console.ReadLine();
                     string deletecor = Console.ReadLine();

                     cmd.CommandText = String.Format("DELETE FROM Carro WHERE Modelo '{0}' AND Cor '{1}';", deletemodel, deletecor);


                     conexao.Open();
                     cmd.ExecuteNonQuery();
                     conexao.Close();


                     Console.WriteLine("Removido com sucesso por Modelo e Cor");
                     Console.ReadKey();
                 }

             }
            else if (opçao == 4)
                 {
                     Console.WriteLine("Finalizado com sucesso");
                     Console.ReadKey();
                 }
             else
             {
                 Console.WriteLine("Opção Inválida");
                 Console.ReadKey();
             }

             /*cmd.CommandText = String.Format("DELETE FROM Carro (Marca, Modelo, Cor, Placa, Potencia) VALUES ('{0}', '{1}', '{2}', '{3}', {4});", Marca, Modelo, Placa, Cor, potencia);
             conexao.Open();


             cmd.ExecuteNonQuery();
             conexao.Close();

             Console.WriteLine("Ok");
             Console.ReadKey();*/
        }
    }
}