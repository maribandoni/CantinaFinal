using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantinaC_
{
    internal class produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public int Quantidade { get; set; }
        
        public produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        public override string ToString()
        {
            return $"{Nome} - {Preco:C}";
        }
    }
   
}
