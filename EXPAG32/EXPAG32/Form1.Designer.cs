namespace EXPAG32
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
            this.lblN = new System.Windows.Forms.Label();
            this.BTNEXIBIR = new System.Windows.Forms.Button();
            this.comboNumbers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(125, 52);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(134, 13);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "Digite um numero de 1 a 5:";
            // 
            // BTNEXIBIR
            // 
            this.BTNEXIBIR.Location = new System.Drawing.Point(213, 137);
            this.BTNEXIBIR.Name = "BTNEXIBIR";
            this.BTNEXIBIR.Size = new System.Drawing.Size(75, 23);
            this.BTNEXIBIR.TabIndex = 2;
            this.BTNEXIBIR.Text = "EXIBIR";
            this.BTNEXIBIR.UseVisualStyleBackColor = true;
            this.BTNEXIBIR.Click += new System.EventHandler(this.BTNEXIBIR_Click);
            // 
            // comboNumbers
            // 
            this.comboNumbers.FormattingEnabled = true;
            this.comboNumbers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboNumbers.Location = new System.Drawing.Point(282, 44);
            this.comboNumbers.Name = "comboNumbers";
            this.comboNumbers.Size = new System.Drawing.Size(121, 21);
            this.comboNumbers.TabIndex = 3;
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboNumbers);
            this.Controls.Add(this.BTNEXIBIR);
            this.Controls.Add(this.lblN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Button BTNEXIBIR;
        private System.Windows.Forms.ComboBox comboNumbers;
    }
}

