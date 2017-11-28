using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=EN2LIC_02;Initial Catalog=DADOS;Integrated Security=SSPI"),
                CommandText = @"SELECT Id, Nome, Preço, Marca
                                FROM CARRO;"
            };

            try
            {
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        int Id = reader.GetInt32(0);
                        string Nome = reader.GetString(1);
                        int Preco = reader.GetInt32(2);
                        string marca = reader.GetString(3);
                        Console.WriteLine("Id {0} Nome {1}Preço {2}  Marca {3}", Id, Nome, Preco, marca);

                    }
                }
                Console.WriteLine("");
                Console.WriteLine("NÃO HÁ MAIS NENHUMA TABELA A SER LISTADA");
                cmd.Connection.Close();
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Chamar o corpo de bombeiros");
            }
        }
    }
}
