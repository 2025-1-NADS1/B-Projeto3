namespace Pi
{
    partial class menurestrito
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
            button2 = new Button();
            voltar = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)voltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(711, 208);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Contas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // voltar
            // 
            voltar.Image = Properties.Resources.LOGIN__59_4_x_42_cm___1_;
            voltar.Location = new Point(686, 12);
            voltar.Name = "voltar";
            voltar.Size = new Size(100, 50);
            voltar.SizeMode = PictureBoxSizeMode.Zoom;
            voltar.TabIndex = 2;
            voltar.TabStop = false;
            voltar.Click += pictureBox1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGIN__59_4_x_42_cm___2_;
            pictureBox1.Location = new Point(686, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // menurestrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(voltar);
            Controls.Add(button2);
            Name = "menurestrito";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)voltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private PictureBox voltar;
        private PictureBox pictureBox1;
    }
}