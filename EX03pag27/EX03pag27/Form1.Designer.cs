namespace EX03pag27
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
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.TXTN1 = new System.Windows.Forms.TextBox();
            this.TXTN2 = new System.Windows.Forms.TextBox();
            this.BtnCALCULAR = new System.Windows.Forms.Button();
            this.txtExibir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(71, 54);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(92, 13);
            this.lblN1.TabIndex = 0;
            this.lblN1.Text = "Digite um numero:";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(61, 124);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(102, 13);
            this.lblN2.TabIndex = 1;
            this.lblN2.Text = "Digite outro numero:";
            // 
            // TXTN1
            // 
            this.TXTN1.Location = new System.Drawing.Point(177, 54);
            this.TXTN1.Name = "TXTN1";
            this.TXTN1.Size = new System.Drawing.Size(100, 20);
            this.TXTN1.TabIndex = 2;
            // 
            // TXTN2
            // 
            this.TXTN2.Location = new System.Drawing.Point(177, 121);
            this.TXTN2.Name = "TXTN2";
            this.TXTN2.Size = new System.Drawing.Size(100, 20);
            this.TXTN2.TabIndex = 3;
            // 
            // BtnCALCULAR
            // 
            this.BtnCALCULAR.Location = new System.Drawing.Point(313, 182);
            this.BtnCALCULAR.Name = "BtnCALCULAR";
            this.BtnCALCULAR.Size = new System.Drawing.Size(90, 27);
            this.BtnCALCULAR.TabIndex = 4;
            this.BtnCALCULAR.Text = "CALCULAR";
            this.BtnCALCULAR.UseVisualStyleBackColor = true;
            this.BtnCALCULAR.Click += new System.EventHandler(this.BtnCALCULAR_Click);
            // 
            // txtExibir
            // 
            this.txtExibir.Location = new System.Drawing.Point(313, 238);
            this.txtExibir.Name = "txtExibir";
            this.txtExibir.Size = new System.Drawing.Size(100, 20);
            this.txtExibir.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtExibir);
            this.Controls.Add(this.BtnCALCULAR);
            this.Controls.Add(this.TXTN2);
            this.Controls.Add(this.TXTN1);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.TextBox TXTN1;
        private System.Windows.Forms.TextBox TXTN2;
        private System.Windows.Forms.Button BtnCALCULAR;
        private System.Windows.Forms.TextBox txtExibir;
    }
}

