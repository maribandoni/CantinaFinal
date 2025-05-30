namespace cantinaC_
{
    partial class balcao
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            listBox2 = new ListBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000106593_removebg_preview__3_2;
            pictureBox1.Location = new Point(-9, -15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(659, 378);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(193, 23);
            label1.TabIndex = 25;
            label1.Text = "Pedidos em andamento:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 76);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(475, 229);
            listBox1.TabIndex = 26;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 328);
            label2.Name = "label2";
            label2.Size = new Size(166, 23);
            label2.TabIndex = 27;
            label2.Text = "Pedidos Concluídos:";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(12, 383);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(475, 124);
            listBox2.TabIndex = 28;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bolt;
            pictureBox2.Location = new Point(681, -24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(182, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(849, 530);
            Controls.Add(pictureBox2);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "balcao";
            Text = "balcao";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private ListBox listBox2;
        private PictureBox pictureBox2;
    }
}