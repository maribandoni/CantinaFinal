namespace cantinaC_
{
    public class pedido
    {
        public string Cliente { get; set; }
        public string FormaPagamento { get; set; }
        public bool ParaViagem { get; set; }
        public List<produto> Itens { get; set; }
        public DateTime DataHora { get; set; }

        public pedido(string cliente, string formaPagamento, bool paraViagem, List<produto> itens)
        {
            Cliente = cliente;
            FormaPagamento = formaPagamento;
            ParaViagem = paraViagem;
            Itens = itens;
            DataHora = DateTime.Now;
        }
    }
}


