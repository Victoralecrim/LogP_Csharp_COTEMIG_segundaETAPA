using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX03pag27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCALCULAR_Click(object sender, EventArgs e)
        {
            int N1, N2, resultado;

            N1 = int.Parse(TXTN1.Text);
            N2 = int.Parse(TXTN2.Text);

            resultado = N1 + N2;
            

            if (resultado > 20)
            {
                resultado = resultado + 8;
            }

            else if(resultado <= 20)
            {
                resultado = resultado - 5;
            }

            txtExibir.Text = resultado.ToString();
        }
    }
}
