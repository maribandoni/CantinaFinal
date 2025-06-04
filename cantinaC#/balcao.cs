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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void balcao_Load(object sender, EventArgs e)
        {
            foreach(Pedido pedido in PedidosFinalizados.pedidosFinalizados)
                if(pedido.status == Status.PRONTO)
                    listBox1.Items.Add(pedido);
                else
                {
                    listBox2.Items.Add(pedido);
                }
        }
    }
}
