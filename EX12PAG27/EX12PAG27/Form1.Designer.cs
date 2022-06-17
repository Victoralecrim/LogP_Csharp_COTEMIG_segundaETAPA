namespace EX12PAG27
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtlitros = new System.Windows.Forms.TextBox();
            this.BTNexibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a quantidade de litros:";
            // 
            // txtlitros
            // 
            this.txtlitros.Location = new System.Drawing.Point(246, 111);
            this.txtlitros.Name = "txtlitros";
            this.txtlitros.Size = new System.Drawing.Size(100, 20);
            this.txtlitros.TabIndex = 2;
            // 
            // BTNexibir
            // 
            this.BTNexibir.Location = new System.Drawing.Point(307, 195);
            this.BTNexibir.Name = "BTNexibir";
            this.BTNexibir.Size = new System.Drawing.Size(75, 23);
            this.BTNexibir.TabIndex = 4;
            this.BTNexibir.Text = "EXIBIR";
            this.BTNexibir.UseVisualStyleBackColor = true;
            this.BTNexibir.Click += new System.EventHandler(this.BTNexibir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNexibir);
            this.Controls.Add(this.txtlitros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlitros;
        private System.Windows.Forms.Button BTNexibir;
    }
}

