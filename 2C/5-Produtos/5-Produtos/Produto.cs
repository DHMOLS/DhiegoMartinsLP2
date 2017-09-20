using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Produtos
{
    class Produto
    {
        private int idp;
        public int Idp
        {
            get { return idp; }
        }

        public string Nome { get; set; }
        public double Preço { get; set; }
   
        private int quantidade;
        public int Quantidade
        {
            get { return idp; }
        }

        public void Repor(int qtd)
        {
            quantidade += qtd;
        }

        public Produto(string nome,double preço,int idp)
        {
            this.Nome = nome;
            this.Preço = preço;
            this.idp = idp;
            this.quantidade = 0;
        }
    }
}
