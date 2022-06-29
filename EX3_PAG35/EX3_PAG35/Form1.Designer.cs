namespace EX3_PAG35
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtQUANT = new System.Windows.Forms.TextBox();
            this.btnCALC = new System.Windows.Forms.Button();
            this.lblEXIBIRTOT = new System.Windows.Forms.Label();
            this.comboBoxProdutos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a quantidade do produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe o codigo do produto:";
            // 
            // txtQUANT
            // 
            this.txtQUANT.Location = new System.Drawing.Point(171, 78);
            this.txtQUANT.Name = "txtQUANT";
            this.txtQUANT.Size = new System.Drawing.Size(100, 20);
            this.txtQUANT.TabIndex = 3;
            // 
            // btnCALC
            // 
            this.btnCALC.Location = new System.Drawing.Point(263, 183);
            this.btnCALC.Name = "btnCALC";
            this.btnCALC.Size = new System.Drawing.Size(75, 23);
            this.btnCALC.TabIndex = 4;
            this.btnCALC.Text = "CALCULAR";
            this.btnCALC.UseVisualStyleBackColor = true;
            this.btnCALC.Click += new System.EventHandler(this.btnCALC_Click_1);
            // 
            // lblEXIBIRTOT
            // 
            this.lblEXIBIRTOT.AutoSize = true;
            this.lblEXIBIRTOT.Location = new System.Drawing.Point(291, 255);
            this.lblEXIBIRTOT.Name = "lblEXIBIRTOT";
            this.lblEXIBIRTOT.Size = new System.Drawing.Size(10, 13);
            this.lblEXIBIRTOT.TabIndex = 5;
            this.lblEXIBIRTOT.Text = ".";
            // 
            // comboBoxProdutos
            // 
            this.comboBoxProdutos.FormattingEnabled = true;
            this.comboBoxProdutos.Items.AddRange(new object[] {
            "AUTO",
            "MOTO",
            "BIKE",
            "KLWE",
            "WPDD"});
            this.comboBoxProdutos.Location = new System.Drawing.Point(161, 23);
            this.comboBoxProdutos.Name = "comboBoxProdutos";
            this.comboBoxProdutos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProdutos.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxProdutos);
            this.Controls.Add(this.lblEXIBIRTOT);
            this.Controls.Add(this.btnCALC);
            this.Controls.Add(this.txtQUANT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQUANT;
        private System.Windows.Forms.Button btnCALC;
        private System.Windows.Forms.Label lblEXIBIRTOT;
        private System.Windows.Forms.ComboBox comboBoxProdutos;
    }
}

