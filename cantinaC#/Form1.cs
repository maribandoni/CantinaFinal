using System.Diagnostics.Eventing.Reader;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Windows.Forms;
using static cantinaC_.Form1;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Text;

namespace cantinaC_
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();
        List<Produto> carrinhos = new List<Produto>();

        decimal totalCarrinho = 0;

        public Form1()
        {
            InitializeComponent();
            AdicionarProduto();
            ListarProduto();
        }

        private void AdicionarProduto()
        {
            produtos.Add(new Produto("Pão de queijo", 3.50m, false));
            produtos.Add(new Produto("Coxinha", 5.00m, false));
            produtos.Add(new Produto("Pastel de carne", 6.00m, true));
            produtos.Add(new Produto("Pastel de queijo", 5.50m, true));
            produtos.Add(new Produto("Suco natural(300ml)", 4.00m, true));
            produtos.Add(new Produto("Refrigerante lata", 4.50m, false));
            produtos.Add(new Produto("Hambúrguer simples ", 8.00m, true));
            produtos.Add(new Produto("Hambúrguer com queijo", 9.00m, true));
            produtos.Add(new Produto("X-Tudo", 12.00m, true));
            produtos.Add(new Produto("Água mineral(500ml)", 2.50m, false));


        }
        private void ListarProduto()
        {
            listBoxProduto.Items.Clear();
            foreach (var produto in produtos)
            {
                listBoxProduto.Items.Add(produto);
            }
        }

        private void ListarCarrinho()
        {
            listBoxCarrinho.Items.Clear();
            foreach (var carrinho in carrinhos)
            {
                listBoxCarrinho.Items.Add($"{carrinho.Quantidade}x {carrinho.Nome} - R$ {carrinho.Preco * carrinho.Quantidade:F2}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxProduto.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto");
                return;
            }

            var produtoSelecionado = (Produto)listBoxProduto.SelectedItem;
            int quantidade = (int)numericUpDownQuantidade.Value;

            if (quantidade <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida");
                return;
            }
            var produtoNoCarrinho = carrinhos.FirstOrDefault(p => p.Nome == produtoSelecionado.Nome);
            if (produtoNoCarrinho != null)
            {
                produtoNoCarrinho.Quantidade += quantidade;
            }
            else
            {
                var novoProduto = new Produto(produtoSelecionado.Nome, produtoSelecionado.Preco, produtoSelecionado.isChapa)
                {
                    Quantidade = quantidade
                };
                carrinhos.Add(novoProduto);
            }

            totalCarrinho = carrinhos.Sum(p => p.Preco * p.Quantidade);

            ListarCarrinho();
            total.Text = $"Total a pagar: R$ {totalCarrinho:F2}";
            numericUpDownQuantidade.Value = 1;




        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxCarrinho.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto");
                return;
            }

            int selectedIndex = listBoxCarrinho.SelectedIndex;
            int quantidadeRemover = (int)numericUpDownQuantidade.Value;
            if (selectedIndex >= 0 && selectedIndex < carrinhos.Count)
            {
                var produto = carrinhos[selectedIndex];
                if (produto.Quantidade > quantidadeRemover)
                {
                    produto.Quantidade -= quantidadeRemover;
                }
                else
                {
                    carrinhos.RemoveAt(selectedIndex);
                }

                totalCarrinho = carrinhos.Sum(p => p.Preco * p.Quantidade);
                ListarCarrinho();
                total.Text = $"Total a pagar: R$ {totalCarrinho:F2}";
            }
        }
        private void listBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void listBoxCarrinho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Digite o nome do cliente");
                return;
            }

            if (carrinhos.Count == 0)
            {
                MessageBox.Show("Carrinho vazio");
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione a Forma de Pagamento");
                return;
            }

            string metodoPagamento = comboBox1.SelectedItem?.ToString();

            decimal valorPago = 0;

            if (metodoPagamento == "Dinheiro")
            {
                string entrada = Interaction.InputBox("Informe o valor pago pelo cliente:", "Pagamento em Dinheiro");
                decimal.TryParse(entrada, out valorPago);
                decimal troco = valorPago - totalCarrinho;

                if (troco < 0)
                {
                    MessageBox.Show("Valor insuficiente!");
                    return ;
                }
                else{
                    MessageBox.Show($"Troco: {troco}");
                }
            }
            Extrato();
            bool pedidoChapa = carrinhos.Any(p => p.isChapa);
            Status statusPedido = pedidoChapa ? Status.PREPARANDO : Status.PRONTO;

            var novoPedido = new Pedido(textBox1.Text, metodoPagamento, checkBox1.Checked, new List<Produto>(carrinhos), statusPedido);
            PedidosFinalizados.pedidosFinalizados.Add(novoPedido);

            Limpar();
        }




        private void Limpar()
        {

            carrinhos.Clear();
            ListarCarrinho();
            total.Text = "Total:";
            checkBox1.Checked = false;

            textBox1.Clear();
            listBoxCarrinho.Items.Clear();
            numericUpDownQuantidade.Value = 1;
            listBoxProduto.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Método de Pagamento";

        }

        private void Extrato()
        {
            string nomeCliente = textBox1.Text;
            string metodoPagamento = comboBox1.SelectedItem?.ToString() ?? "Não informado";
            string tipoPedido = checkBox1.Checked ? "Para Viagem" : "Consumo no Local";
            string dataAtual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            if (carrinhos.Count == 0)
            {
                MessageBox.Show("Carrinho vazio.", "extrato da compra");
                return;
            }
            StringBuilder extrato = new StringBuilder();
            extrato.AppendLine($"Data: {dataAtual}");
            extrato.AppendLine($"Nome Cliente: {nomeCliente}");
            extrato.AppendLine($"Forma de Pagamento: {metodoPagamento}");
            extrato.AppendLine($"Tipo de Pedido: {tipoPedido}");
            extrato.AppendLine("\nProdutos:");

            foreach (var item in carrinhos)
            {
                extrato.AppendLine($"{item.Quantidade}x {item.Nome} - R$ {item.Preco * item.Quantidade:F2}");
            }

            extrato.AppendLine($"\nTotal: R$ {carrinhos.Sum(p => p.Preco * p.Quantidade):F2}");

            MessageBox.Show(extrato.ToString(), "Extrato da compra");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cliente = textBox1.Text;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            balcao telaBalcao = new balcao();
            telaBalcao.Show();

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }
    }
}

