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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Stylus BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = SystemColors.ActiveCaptionText;
            btnAdicionar.Location = new Point(361, 204);
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
            listBoxProduto.Location = new Point(36, 137);
            listBoxProduto.Name = "listBoxProduto";
            listBoxProduto.Size = new Size(230, 251);
            listBoxProduto.TabIndex = 1;
            listBoxProduto.SelectedIndexChanged += listBoxProduto_SelectedIndexChanged;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Stylus BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(361, 253);
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
            listBoxCarrinho.Location = new Point(576, 137);
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
            total.Location = new Point(576, 266);
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
            label2.Location = new Point(576, 308);
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
            pictureBox2.Location = new Point(689, -28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000106437_removebg_preview__1_;
            pictureBox1.Location = new Point(-18, -28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1218, 732);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(886, 558);
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
    }
}
