namespace Pi
{
    partial class gamefication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gamefication));
            pictureBox1 = new PictureBox();
            txtNota1 = new TextBox();
            lblResultado = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(698, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(180, 148);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(438, 23);
            txtNota1.TabIndex = 1;
            txtNota1.TextChanged += textBox1_TextChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(370, 239);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(84, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "A sua média é:";
            lblResultado.Click += lblResultado_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LOGIN__59_4_x_42_cm___8_;
            pictureBox2.Location = new Point(0, -77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(805, 376);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LOGIN__59_4_x_42_cm___9_;
            pictureBox3.Location = new Point(253, 148);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(318, 139);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // gamefication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(txtNota1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "gamefication";
            Text = "gamefication";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtNota1;
        private Label lblResultado;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}