using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace cantinaC_
{
    public class Pedido
    {
        public string Cliente { get; set; }
        public string FormaPagamento { get; set; }
        public bool ParaViagem { get; set; }
        public List<Produto> Produtos { get; set; }
        public DateTime DataHora { get; set; }
        public Status status { get; set; }

        public Pedido(string cliente, string formaPagamento, bool paraViagem, List<Produto> produtos, Status status)
        {
            Cliente = cliente;
            FormaPagamento = formaPagamento;
            ParaViagem = paraViagem;
            Produtos = produtos;
            DataHora = DateTime.Now;
            this.status = status;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Cliente} - ");

            if (this.status == Status.PREPARANDO)
            {
                foreach (var produto in Produtos)
                {
                    if (produto.isChapa)
                    {
                        sb.Append($" {produto.Quantidade} x - {produto.Nome}  ");
                    }
                }

            }
            else
            {
                foreach (var produto in Produtos)
                    sb.Append($"{produto.Quantidade} X - {produto.Nome}");
            }
            return sb.ToString().TrimEnd(' ', '/');
                
       
        }
    }
}


