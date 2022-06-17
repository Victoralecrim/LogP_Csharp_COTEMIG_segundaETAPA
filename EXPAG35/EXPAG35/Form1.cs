using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXPAG35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor_CARRO;
            char codigo;
            double valor_total, valor_juros, valor_parcelas;
            codigo = char.Parse(comboboxCOD_PRODUTO.Text);
            valor_CARRO = double.Parse(txtvalor_CARRO.Text);

            switch (codigo)
            {

                case 'a':
                    valor_juros = (valor_CARRO * 30 / 100);
                    valor_total = (valor_CARRO + valor_juros);
                    valor_parcelas = (valor_total / 24);
                    lblJuros.Text = "O valo dos juros é de: " + valor_juros.ToString("C");
                    lblvalor_total.Text = "O valor total é de: " + valor_total.ToString("C");
                    lblValor_parcela.Text = "O valor de cada parcela é de: " + valor_parcelas.ToString("C");
                    break;
                case 'b':
                    valor_juros = (valor_CARRO * 55 / 100);
                    valor_total = (valor_CARRO + valor_juros);
                    valor_parcelas = (valor_total / 36);
                    lblJuros.Text = "O valo dos juros é de: " + valor_juros.ToString("C");
                    lblvalor_total.Text = "O valor total é de: " + valor_total.ToString("C");
                    lblValor_parcela.Text = "O valor de cada parcela é de: " + valor_parcelas.ToString("C");
                    break;
                case 'c':
                    valor_juros = (valor_CARRO * 48 / 100);
                    valor_total = (valor_CARRO + valor_juros);
                    valor_parcelas = (valor_total / 75);
                    lblJuros.Text = "O valo dos juros é de: " + valor_juros.ToString("C");
                    lblvalor_total.Text = "O valor total é de: " + valor_total.ToString("C");
                    lblValor_parcela.Text = "O valor de cada parcela é de: " + valor_parcelas.ToString("C");
                    break;
                case 'd':
                    valor_juros = (valor_CARRO * 60 / 100);
                    valor_total = (valor_CARRO + valor_juros);
                    valor_parcelas = (valor_total / 100);
                    lblJuros.Text = "O valo dos juros é de: " + valor_juros.ToString("C");
                    lblvalor_total.Text = "O valor total é de: " + valor_total.ToString("C");
                    lblValor_parcela.Text = "O valor de cada parcela é de: " + valor_parcelas.ToString("C");
                    break;
                    default:
                    MessageBox.Show("INVALIDO !");
                    break;

                    
            }

           

            
        }
    }
}
