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
    public partial class Chamada : Form
    {
        public Chamada()
        {
            InitializeComponent();
        }

        private void Chamada_Load(object sender, EventArgs e)
        {
            foreach (var produto in PedidosFinalizados.pedidosFinalizados)
            {
                labelNome.Text = produto.Cliente;

            }

        }
     

        private void labelNome_Click(object sender, EventArgs e)
        {

        }
    }
}
