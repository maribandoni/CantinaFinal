using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cantinaC_
{
    public partial class balcao : Form
    {

        List<Pedido> pedidos = new List<Pedido>();
        private TelaChamada chamadaForm;
        private Chamada nomeForm;
        public balcao()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void balcao_Load(object sender, EventArgs e)
        {
            foreach (Pedido pedido in PedidosFinalizados.pedidosFinalizados)
                if (pedido.status == Status.PRONTO)
                    listBox1.Items.Add(pedido);
                else if (pedido.status == Status.ENTREGUE)
                    listBox2.Items.Add(pedido);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrega_Click(object sender, EventArgs e)


        {


            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um pedido");
                return;
            }
            nomeForm = new Chamada();
            nomeForm.ShowDialog();

            var pedidoSelecionado = listBox1.SelectedItem as Pedido;

            if (listBox2.Items.Count == 5)
            {
                listBox2.Items.RemoveAt(4);
            }
            pedidoSelecionado.status = Status.ENTREGUE;
            listBox2.Items.Insert(0, pedidoSelecionado);
            listBox1.Items.Remove(pedidoSelecionado);


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um pedido");
                return;
            }
            var pedidoSelecionado = listBox1.SelectedItem as Pedido;
            listBox1.Items.Remove(pedidoSelecionado);
            PedidosFinalizados.pedidosFinalizados.Remove(pedidoSelecionado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaChamada chamadaForm = new TelaChamada();
            chamadaForm.Show();
        }
    }
}

