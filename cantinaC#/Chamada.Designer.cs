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
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.FromArgb(202, 196, 183);
            labelNome.Font = new Font("Agrandir Narrow", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(364, 209);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(73, 32);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            labelNome.Click += labelNome_Click;
            // 
            // Chamada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelNome);
            Name = "Chamada";
            Text = "Chamada";
            Load += Chamada_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
    }
}