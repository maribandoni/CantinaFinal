using System.Diagnostics.Eventing.Reader;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Windows.Forms;
using static cantinaC_.Form1;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace cantinaC_
{
    public partial class Form1 : Form
    {
        List<produto> produtos = new List<produto>();
        List<produto> carrinhos = new List<produto>();

        decimal totalCarrinho = 0;

        public Form1()
        {
            InitializeComponent();
            AdicionarProduto();
            ListarProduto();
        }

        private void AdicionarProduto()
        {
            produtos.Add(new produto("Pão de queijo", 3.50m));
            produtos.Add(new produto("Coxinha", 5.00m));
            produtos.Add(new produto("Pastel de carne", 6.00m));
            produtos.Add(new produto("Pastel de queijo", 5.50m));
            produtos.Add(new produto("Suco natural(300ml)", 4.00m));
            produtos.Add(new produto("Refrigerante lata", 4.50m));
            produtos.Add(new produto("Hambúrguer simples ", 8.00m));
            produtos.Add(new produto("Hambúrguer com queijo", 9.00m));
            produtos.Add(new produto("X-Tudo", 12.00m));
            produtos.Add(new produto("Água mineral(500ml)", 2.50m));


        }
        private void ListarProduto()
        {
            listBoxProduto.Items.Clear();
            foreach (var produto in produtos)
            {
                listBoxProduto.Items.Add({produto.Nome});
            }
        }

        private void ListarCarrinho()
        {
            listBoxCarrinho.Items.Clear();
            foreach (var carrinho in carrinhos)
            {
                listBoxCarrinho.Items.Add(carrinho);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxProduto.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto");
                return;
            }

            var produtoSelecionado= (produto)listBoxProduto.SelectedItem;
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
                var novoProduto = new produto(produtoSelecionado.Nome, produtoSelecionado.Preco)
                {
                    Quantidade = quantidade
                };
                carrinhos.Add(novoProduto);
            }

            totalCarrinho += produtoSelecionado.Preco * quantidade;

            ListarCarrinho();
            total.Text = $"Total a pagar: R$ {totalCarrinho:F2}";
            numericUpDownQuantidade.Value = 1;
            totalCarrinho += produtoSelecionado.Preco * quantidade;

            

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxCarrinho.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto");
                return;
            }
            var produto = (produto)listBoxCarrinho.SelectedItem;
            carrinhos.Remove(produto);
            totalCarrinho -= produto.Preco;
            ListarCarrinho();
            total.Text = $"Total a pagar:R$ {totalCarrinho:F2}";
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
            if (checkBox1.Checked)
            {
                MessageBox.Show("Pedido Marcado como Para Viagem");
            }
            else
            {
                MessageBox.Show("Pedido Para Consumo no Local");
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
                    return;
                }
                else
                {
                    MessageBox.Show($"Troco: {troco}");
                    Limpar();
                }

                MessageBox.Show("Compra finalizada!");
                Limpar();
            }
            else
            {
                MessageBox.Show("Compra finalizada!");
                Limpar();
            }

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
    }
}

