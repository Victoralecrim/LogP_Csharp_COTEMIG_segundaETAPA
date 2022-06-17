namespace EX01Pag35
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
            this.lblCOD = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtEXIBIR = new System.Windows.Forms.TextBox();
            this.btnEXIBIR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCOD
            // 
            this.lblCOD.AutoSize = true;
            this.lblCOD.Location = new System.Drawing.Point(47, 50);
            this.lblCOD.Name = "lblCOD";
            this.lblCOD.Size = new System.Drawing.Size(125, 13);
            this.lblCOD.TabIndex = 0;
            this.lblCOD.Text = "Digite o codigo do plano:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(191, 47);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 2;
            // 
            // txtEXIBIR
            // 
            this.txtEXIBIR.Location = new System.Drawing.Point(314, 170);
            this.txtEXIBIR.Name = "txtEXIBIR";
            this.txtEXIBIR.Size = new System.Drawing.Size(100, 20);
            this.txtEXIBIR.TabIndex = 3;
            // 
            // btnEXIBIR
            // 
            this.btnEXIBIR.Location = new System.Drawing.Point(328, 111);
            this.btnEXIBIR.Name = "btnEXIBIR";
            this.btnEXIBIR.Size = new System.Drawing.Size(75, 23);
            this.btnEXIBIR.TabIndex = 4;
            this.btnEXIBIR.Text = "EXIBIR";
            this.btnEXIBIR.UseVisualStyleBackColor = true;
            this.btnEXIBIR.Click += new System.EventHandler(this.btnEXIBIR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEXIBIR);
            this.Controls.Add(this.txtEXIBIR);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblCOD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCOD;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtEXIBIR;
        private System.Windows.Forms.Button btnEXIBIR;
        private System.Windows.Forms.Label label1;
    }
}

