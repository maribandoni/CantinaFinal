using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cantinaC_
{
    public partial class Cozinha : Form
    {
        public Cozinha()
        {
            InitializeComponent();
        }

        private void Cozinha_Load(object sender, EventArgs e)
        {
            foreach (Pedido pedido in PedidosFinalizados.pedidosFinalizados)
                if (pedido.status == Status.PREPARANDO)
                    listBox1.Items.Add(pedido);
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {

            var produtoSelecionado = (Pedido)listBox1.SelectedItem;
            produtoSelecionado.status = Status.PRONTO;
            listBox1.Items.Remove(produtoSelecionado);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
