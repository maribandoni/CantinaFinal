using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantinaC_
{
    internal class produto
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public bool isChapa { get; set; }
        public int Quantidade { get; set; }
       // public override string ToString();

        
        public produto(string nome, decimal preco, bool isChapa)
        {
           this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = 0;
            this.isChapa = isChapa;
        }

        public override string ToString()
        {
            return $"{Nome} - {Preco:C}";
        }
    }
   
}
