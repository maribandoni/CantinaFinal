namespace cantinaC_
{
    partial class TelaChamada
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
            pictureBox3 = new PictureBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000106593_removebg_preview__3_2;
            pictureBox1.Location = new Point(-8, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(659, 378);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ChatGPT_Image_19_de_mai__de_2025__09_35_32;
            pictureBox3.Location = new Point(553, 284);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(260, 177);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(230, 255, 0);
            listBox1.Font = new Font("Agrandir Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(44, 120);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(225, 235);
            listBox1.TabIndex = 27;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(230, 255, 0);
            listBox2.Font = new Font("Agrandir Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.ForeColor = Color.Black;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 21;
            listBox2.Location = new Point(303, 120);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(244, 235);
            listBox2.TabIndex = 28;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bolt_logo1;
            pictureBox2.Location = new Point(553, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 165);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(243, 241, 238);
            label1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 94);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 30;
            label1.Text = "PREPARANDO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(243, 241, 238);
            label2.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(303, 94);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 31;
            label2.Text = "PRONTO:";
            // 
            // TelaChamada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Name = "TelaChamada";
            Text = "TelaChamada";
            Load += TelaChamada_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private ListBox listBox1;
        private ListBox listBox2;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}