using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantinaC_
{
    public class Produto
    {
      
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public bool isChapa { get; set; }
        public int Quantidade { get; set; }
      


        public Produto(string nome, decimal preco, bool isChapa)
        {
           
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
            this.isChapa = isChapa;
        }

        public override string ToString()
        {
            return $"{Nome} - {Preco:C}";
        }
    }
  

}
