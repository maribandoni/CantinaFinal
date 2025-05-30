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
        public balcao()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ListarPedidosEmAndamento(List<pedido> pedidos)
        {
            listBox1.Items.Clear();
            foreach (var p in pedidos.Where(x => x.isChapa))
            {
                listBox2.Items.Add($"#{p.id} - {p.nome} - R$ {p.preço}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarPedidosEmAndamento(pedido);
        }
    }
}
