namespace cantinaC_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdicionar = new Button();
            listBoxProduto = new ListBox();
            btnRemover = new Button();
            listBoxCarrinho = new ListBox();
            total = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            numericUpDownQuantidade = new NumericUpDown();
            textBox1 = new TextBox();
            lblCliente = new Label();
            label1 = new Label();
            lblNome = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Stylus BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = SystemColors.ActiveCaptionText;
            btnAdicionar.Location = new Point(264, 145);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(157, 23);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button1_Click;
            // 
            // listBoxProduto
            // 
            listBoxProduto.Font = new Font("Stylus BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxProduto.FormattingEnabled = true;
            listBoxProduto.ItemHeight = 19;
            listBoxProduto.Items.AddRange(new object[] { "Coxinha - R$ 5,00", "Pastel -  R$ 6,00", "Refrigerante - R$ 4,50", "Suco - R$ 3,00", "Brigadeiro - R$ 2,00" });
            listBoxProduto.Location = new Point(12, 145);
            listBoxProduto.Name = "listBoxProduto";
            listBoxProduto.Size = new Size(230, 251);
            listBoxProduto.TabIndex = 1;
            listBoxProduto.SelectedIndexChanged += listBoxProduto_SelectedIndexChanged;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Stylus BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(264, 243);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(157, 23);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // listBoxCarrinho
            // 
            listBoxCarrinho.FormattingEnabled = true;
            listBoxCarrinho.ItemHeight = 15;
            listBoxCarrinho.Location = new Point(638, 167);
            listBoxCarrinho.Name = "listBoxCarrinho";
            listBoxCarrinho.Size = new Size(195, 109);
            listBoxCarrinho.TabIndex = 3;
            listBoxCarrinho.SelectedIndexChanged += listBoxCarrinho_SelectedIndexChanged;
            // 
            // total
            // 
            total.AutoSize = true;
            total.BackColor = SystemColors.Control;
            total.Font = new Font("Stylus BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total.Location = new Point(639, 279);
            total.Name = "total";
            total.Size = new Size(48, 19);
            total.TabIndex = 4;
            total.Text = "Total:";
            total.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Stylus BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(639, 350);
            label2.Name = "label2";
            label2.Size = new Size(108, 18);
            label2.TabIndex = 5;
            label2.Text = "Finalizar pedido";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(202, 196, 183);
            pictureBox2.Image = Properties.Resources.ChatGPT_Image_16_de_mai__de_2025__08_21_28;
            pictureBox2.Location = new Point(713, -45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000106437_removebg_preview__1_;
            pictureBox1.Location = new Point(-35, -23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(909, 569);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ChatGPT_Image_19_de_mai__de_2025__09_35_32;
            pictureBox3.Location = new Point(335, 383);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(260, 177);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(281, 174);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(120, 23);
            numericUpDownQuantidade.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(699, 167);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(0, 15);
            lblCliente.TabIndex = 13;
            lblCliente.Click += label1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(639, 145);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 14;
            label1.Text = "Cliente:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(692, 145);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(10, 15);
            lblNome.TabIndex = 15;
            lblNome.Text = " ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pix", "Cartão de Débito", "Cartão de Crédito", "Dinheiro" });
            comboBox1.Location = new Point(638, 312);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 23);
            comboBox1.TabIndex = 17;
            comboBox1.Text = "Método de Pagamento";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(886, 558);
            Controls.Add(comboBox1);
            Controls.Add(lblNome);
            Controls.Add(label1);
            Controls.Add(lblCliente);
            Controls.Add(textBox1);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(total);
            Controls.Add(listBoxCarrinho);
            Controls.Add(btnRemover);
            Controls.Add(listBoxProduto);
            Controls.Add(btnAdicionar);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private ListBox listBoxProduto;
        private Button btnRemover;
        private ListBox listBoxCarrinho;
        private Label total;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private NumericUpDown numericUpDownQuantidade;
        private TextBox textBox1;
        private Label lblCliente;
        private Label label1;
        private Label lblNome;
        private ComboBox comboBox1;
    }
}
