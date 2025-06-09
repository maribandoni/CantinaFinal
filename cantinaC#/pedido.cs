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
            string produtosDescricao = string.Join(", ", Produtos.Select(p => $"{p.Quantidade} x {p.Nome}")); 
            return $"{Cliente} - {produtosDescricao}  - {status}";
        }
    }
}


