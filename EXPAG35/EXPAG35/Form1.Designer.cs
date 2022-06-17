namespace EXPAG35
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboboxCOD_PRODUTO = new System.Windows.Forms.ComboBox();
            this.lblJuros = new System.Windows.Forms.Label();
            this.lblvalor_total = new System.Windows.Forms.Label();
            this.lblValor_parcela = new System.Windows.Forms.Label();
            this.lblCARRO = new System.Windows.Forms.Label();
            this.txtvalor_CARRO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o codigo do produto:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "EXIBIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboboxCOD_PRODUTO
            // 
            this.comboboxCOD_PRODUTO.FormattingEnabled = true;
            this.comboboxCOD_PRODUTO.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.comboboxCOD_PRODUTO.Location = new System.Drawing.Point(197, 32);
            this.comboboxCOD_PRODUTO.Name = "comboboxCOD_PRODUTO";
            this.comboboxCOD_PRODUTO.Size = new System.Drawing.Size(121, 21);
            this.comboboxCOD_PRODUTO.TabIndex = 3;
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(173, 189);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(10, 13);
            this.lblJuros.TabIndex = 4;
            this.lblJuros.Text = ".";
            // 
            // lblvalor_total
            // 
            this.lblvalor_total.AutoSize = true;
            this.lblvalor_total.Location = new System.Drawing.Point(173, 223);
            this.lblvalor_total.Name = "lblvalor_total";
            this.lblvalor_total.Size = new System.Drawing.Size(10, 13);
            this.lblvalor_total.TabIndex = 5;
            this.lblvalor_total.Text = ".";
            // 
            // lblValor_parcela
            // 
            this.lblValor_parcela.AutoSize = true;
            this.lblValor_parcela.Location = new System.Drawing.Point(170, 259);
            this.lblValor_parcela.Name = "lblValor_parcela";
            this.lblValor_parcela.Size = new System.Drawing.Size(10, 13);
            this.lblValor_parcela.TabIndex = 6;
            this.lblValor_parcela.Text = ".";
            // 
            // lblCARRO
            // 
            this.lblCARRO.AutoSize = true;
            this.lblCARRO.Location = new System.Drawing.Point(60, 85);
            this.lblCARRO.Name = "lblCARRO";
            this.lblCARRO.Size = new System.Drawing.Size(126, 13);
            this.lblCARRO.TabIndex = 7;
            this.lblCARRO.Text = "Informe o preço do carro:";
            // 
            // txtvalor_CARRO
            // 
            this.txtvalor_CARRO.Location = new System.Drawing.Point(197, 82);
            this.txtvalor_CARRO.Name = "txtvalor_CARRO";
            this.txtvalor_CARRO.Size = new System.Drawing.Size(121, 20);
            this.txtvalor_CARRO.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtvalor_CARRO);
            this.Controls.Add(this.lblCARRO);
            this.Controls.Add(this.lblValor_parcela);
            this.Controls.Add(this.lblvalor_total);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.comboboxCOD_PRODUTO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboboxCOD_PRODUTO;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.Label lblvalor_total;
        private System.Windows.Forms.Label lblValor_parcela;
        private System.Windows.Forms.Label lblCARRO;
        private System.Windows.Forms.TextBox txtvalor_CARRO;
    }
}

