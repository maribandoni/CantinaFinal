using System.Diagnostics.Eventing.Reader;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Windows.Forms;
using static cantinaC_.Form1;
using Microsoft.VisualBasic;

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
                listBoxProduto.Items.Add(produto);
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

            var produto = (produto)listBoxProduto.SelectedItem;
            int quantidade = (int)numericUpDownQuantidade.Value;

            if (quantidade <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida");
                return;
            }
            for (int i = 0; i < quantidade; i++)
            {
                carrinhos.Add(produto);

            }
            totalCarrinho += produto.Preco * quantidade;

            ListarCarrinho();
            TotalPagar();
            numericUpDownQuantidade.Value = 1;

        }
        private void TotalPagar()
        {
            total.Text = $"Total a pagar:R$ {totalCarrinho:F2}";
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
            TotalPagar();
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
            string metodoPagamento = comboBox1.SelectedItem?.ToString();

            if (metodoPagamento == "Dinheiro")
            {
                string entrada = Interaction.InputBox("Informe o valor pago pelo cliente:", "Pagamento em Dinheiro", $"{totalCarrinho:F2}");

                if (decimal.TryParse(entrada, out decimal valorPago))
                {
                    if (valorPago < totalCarrinho)
                    {
                        MessageBox.Show("Valor insuficiente!");
                        return;
                    }

                    decimal troco = valorPago - totalCarrinho;
                    var resultado = MessageBox.Show($"Total a pagar: R$ {totalCarrinho:F2}", "Finalizar compra", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {
                        MessageBox.Show("Compra finalizada!");
                        carrinhos.Clear();
                        totalCarrinho = 0;
                        ListarCarrinho();
                        TotalPagar();

                        textBox1.Clear();
                        lblNome.Text = "";
                        listBoxCarrinho.Items.Clear();
                        numericUpDownQuantidade.Value = 1;
                    }
                  }
               }
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
            lblNome.Text = cliente;

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
       
    }
}

