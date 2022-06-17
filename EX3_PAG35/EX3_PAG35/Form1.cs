using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3_PAG35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class CalcPrecoProd
        {
            public double CalcPrecoTOT(double precoTOT, double preco, int quantidade)
            {
                double precoTotal;
                precoTotal = (quantidade * preco);
                return precoTotal;
            }

            internal double CalcPrecoTOT(double preco, int quantidade)
            {
                throw new NotImplementedException();
            }
        }
          

            private void btnCALC_Click(object sender, EventArgs e)
            {
            CalcPrecoProd obj = new CalcPrecoProd();
                string codigo;
                int quantidade;
                double precoTotal, preco;

                //Entrada de dados:

                 quantidade = int.Parse(txtQUANT.Text);
                 codigo = comboBoxProdutos.Text;

                //Processamento:

                precoTotal = obj.CalcPrecoTOT(preco, quantidade);

                switch (codigo)
                {
                    case "AUTO": preco = 325.00; break;
                    case "MOTO": preco = 102.00; break;
                    case "BIKE": preco = 76.00; break;
                    case "KLWE": preco = 176.00; break;
                    case "WPDD": preco = 456.00; break;
                default:
                    preco = 0.00;
                    MessageBox.Show("Codigo do produto invalido!");
                    break;
            }

             lblEXIBIRTOT.Text = 
            }
        }

    }

