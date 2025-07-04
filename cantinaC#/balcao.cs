﻿using System;
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



            Pedido pedidoSelecionado = (Pedido)listBox1.SelectedItem;

            if (listBox2.Items.Count == 5)
            {
                listBox2.Items.RemoveAt(4);
            }
            pedidoSelecionado.status = Status.ENTREGUE;
            listBox2.Items.Insert(0, pedidoSelecionado);
            listBox1.Items.Remove(pedidoSelecionado);

            nomeForm = new Chamada();
            nomeForm.chamada(pedidoSelecionado.Cliente);
            nomeForm.ShowDialog();



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um pedido");
                return;
            }
            Pedido pedidoSelecionado = (Pedido)listBox1.SelectedItem;
            listBox1.Items.Remove(pedidoSelecionado);
            PedidosFinalizados.pedidosFinalizados.Remove(pedidoSelecionado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaChamada chamadaForm = new TelaChamada();
            chamadaForm.Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

