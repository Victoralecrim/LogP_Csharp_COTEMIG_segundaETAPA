using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX01Pag35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEXIBIR_Click(object sender, EventArgs e)
        {
            int valor;
            valor = int.Parse(txtValor.Text);
            float juros, valor_total, parcela;
            char[]ch = txtEXIBIR.Text.ToCharArray();

            switch (ch[0])
            {
                case 'a': juros = valor * 0.3f; valor_total = valor + juros; parcela = valor_total / 24; break;
                case 'b': juros = valor * 0.55f; valor_total = valor + juros; parcela = valor_total / 36; break;
                case 'c': juros = valor * 0.75f; valor_total = valor + juros; parcela = valor_total / 48; break;
                case 'd': juros = valor * 1f; valor_total = valor + juros; parcela = valor_total / 60; break;
            }
            lblJuros.Text = "O valor do juros é de: " + juros.ToString();
            lblValorTotal.Text = "O valor total é de: " + valor_total.ToString();
            lblValorParcela.Text = "O valor de cada parcela é de: " + parcela.ToString();
        }
    }
}
          

