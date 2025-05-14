using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static cantinaC_.Form1;

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
            produtos.Add(new produto("Coxinha", 5.00m));
            produtos.Add(new produto("Pastel", 6.000m));
            produtos.Add(new produto("Refrigerante", 4.50m));
            produtos.Add(new produto("Suco", 3.00m));
            produtos.Add(new produto("Brigadeiro", 2.00m));

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
            carrinhos.Add(produto);
            totalCarrinho += produto.Preco;

            ListarCarrinho();
            TotalPagar();
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
            if (carrinhos.Count == 0)
            {
                MessageBox.Show("Carrinho vazio");
                return;
            }

            var resultado = MessageBox.Show($"Total a pagar: R$ {totalCarrinho:F2}", "Finalizar compra", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Compra finalizada!");
                carrinhos.Clear();
                totalCarrinho = 0;
                ListarCarrinho();
                TotalPagar();
            }
        }
    }
    }

