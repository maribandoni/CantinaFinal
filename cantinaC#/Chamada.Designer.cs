namespace cantinaC_
{
    partial class Chamada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNome = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.FromArgb(230, 255, 0);
            labelNome.Font = new Font("Agrandir Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(290, 190);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(99, 43);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            labelNome.Click += labelNome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000106593_removebg_preview__3_2;
            pictureBox1.Location = new Point(-15, -26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(815, 487);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bolt;
            pictureBox2.Location = new Point(193, -17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(372, 207);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(230, 255, 0);
            label1.Font = new Font("Agrandir Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 162);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 32;
            label1.Text = "Pedido Pronto!";
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.bolt;
            pictureBox3.Location = new Point(571, -3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(229, 152);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // Chamada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(labelNome);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Chamada";
            Text = "Chamada";
            Load += Chamada_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
    }
}