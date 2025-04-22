namespace CasaInteligentePI
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.tabelaSensores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaSensores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelaSensores
            // 
            this.tabelaSensores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaSensores.Location = new System.Drawing.Point(12, 12);
            this.tabelaSensores.Name = "tabelaSensores";
            this.tabelaSensores.Size = new System.Drawing.Size(776, 400);
            this.tabelaSensores.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabelaSensores);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabelaSensores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaSensores_CellClick);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaSensores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelaSensores;
    }
}

