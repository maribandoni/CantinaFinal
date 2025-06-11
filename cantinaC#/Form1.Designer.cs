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
            pictureBox3 = new PictureBox();
            numericUpDownQuantidade = new NumericUpDown();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            pictureBox2 = new PictureBox();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(243, 241, 238);
            btnAdicionar.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.Black;
            btnAdicionar.Location = new Point(264, 165);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(157, 29);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += button1_Click;
            // 
            // listBoxProduto
            // 
            listBoxProduto.BackColor = Color.FromArgb(230, 255, 0);
            listBoxProduto.Font = new Font("Agrandir Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxProduto.FormattingEnabled = true;
            listBoxProduto.ItemHeight = 21;
            listBoxProduto.Location = new Point(12, 163);
            listBoxProduto.Name = "listBoxProduto";
            listBoxProduto.Size = new Size(230, 235);
            listBoxProduto.TabIndex = 1;
            listBoxProduto.SelectedIndexChanged += listBoxProduto_SelectedIndexChanged;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(243, 241, 238);
            btnRemover.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(264, 227);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(157, 27);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // listBoxCarrinho
            // 
            listBoxCarrinho.BackColor = Color.FromArgb(230, 255, 0);
            listBoxCarrinho.Font = new Font("Agrandir Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxCarrinho.FormattingEnabled = true;
            listBoxCarrinho.ItemHeight = 21;
            listBoxCarrinho.Location = new Point(476, 163);
            listBoxCarrinho.Name = "listBoxCarrinho";
            listBoxCarrinho.Size = new Size(195, 214);
            listBoxCarrinho.TabIndex = 3;
            listBoxCarrinho.SelectedIndexChanged += listBoxCarrinho_SelectedIndexChanged;
            // 
            // total
            // 
            total.AutoSize = true;
            total.BackColor = Color.FromArgb(243, 241, 238);
            total.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total.Location = new Point(705, 165);
            total.Name = "total";
            total.Size = new Size(49, 22);
            total.TabIndex = 4;
            total.Text = "Total:";
            total.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(243, 241, 238);
            label2.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(705, 355);
            label2.Name = "label2";
            label2.Size = new Size(123, 22);
            label2.TabIndex = 5;
            label2.Text = "Finalizar pedido";
            label2.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ChatGPT_Image_19_de_mai__de_2025__09_35_32;
            pictureBox3.Location = new Point(627, 388);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(260, 177);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.BackColor = Color.FromArgb(243, 241, 238);
            numericUpDownQuantidade.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownQuantidade.Location = new Point(287, 195);
            numericUpDownQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(120, 26);
            numericUpDownQuantidade.TabIndex = 10;
            numericUpDownQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantidade.ValueChanged += numericUpDownQuantidade_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(243, 241, 238);
            textBox1.Location = new Point(82, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(243, 241, 238);
            label1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 139);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 14;
            label1.Text = "Cliente:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(243, 241, 238);
            comboBox1.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pix", "Cartão de Débito", "Cartão de Crédito", "Dinheiro" });
            comboBox1.Location = new Point(705, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 25);
            comboBox1.TabIndex = 17;
            comboBox1.Text = "Método de Pagamento";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bolt;
            pictureBox2.Location = new Point(705, -26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(182, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.FromArgb(243, 241, 238);
            checkBox1.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(705, 227);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 21);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "Para Viagem";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(15, 420);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(84, 23);
            dateTimePicker1.TabIndex = 21;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(24, 449);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "Balcão";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000106593_removebg_preview__3_2;
            pictureBox1.Location = new Point(-7, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(659, 378);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_3;
            // 
            // button2
            // 
            button2.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(24, 478);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 24;
            button2.Text = "Cozinha";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(886, 558);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(pictureBox3);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox3;
        private NumericUpDown numericUpDownQuantidade;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}
