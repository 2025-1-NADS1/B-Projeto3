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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menurestrito));
            voltar = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Sair = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)voltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // voltar
            // 
            voltar.Image = (Image)resources.GetObject("voltar.Image");
            voltar.Location = new Point(662, 12);
            voltar.Name = "voltar";
            voltar.Size = new Size(116, 82);
            voltar.SizeMode = PictureBoxSizeMode.Zoom;
            voltar.TabIndex = 2;
            voltar.TabStop = false;
            voltar.Click += pictureBox1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(662, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LOGIN__59_4_x_42_cm___3_;
            pictureBox2.Location = new Point(356, -45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(722, 541);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LOGIN__59_4_x_42_cm___5_;
            pictureBox3.Location = new Point(662, 221);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 85);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Sair
            // 
            Sair.AutoSize = true;
            Sair.BackColor = Color.Transparent;
            Sair.Location = new Point(706, 97);
            Sair.Name = "Sair";
            Sair.Size = new Size(26, 15);
            Sair.TabIndex = 6;
            Sair.Text = "Sair";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(676, 203);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 7;
            label1.Text = "Gamefication";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(693, 309);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Conta";
            // 
            // menurestrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Sair);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(voltar);
            Controls.Add(pictureBox2);
            Name = "menurestrito";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)voltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox voltar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label Sair;
        private Label label1;
        private Label label2;
    }
}