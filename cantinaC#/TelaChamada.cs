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
    public partial class TelaChamada : Form
    {
        public TelaChamada()
        {
            InitializeComponent();
        }

        private void TelaChamada_Load(object sender, EventArgs e)
        {

            foreach (Pedido pedido in PedidosFinalizados.pedidosFinalizados)
                if (pedido.status == Status.PRONTO || pedido.status == Status.PREPARANDO)
                    listBox1.Items.Add(pedido.Cliente);
                else if (pedido.status == Status.ENTREGUE)
                    listBox2.Items.Insert(0,pedido.Cliente);


        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }

}
