using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX05pag27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int N, multiplo;
            N = int.Parse(TXTN1.Text);

            multiplo = N % 3;

            if (multiplo == 0)
            {
                MessageBox.Show("É um multiplo de 3");
            }

            else 
            {
                MessageBox.Show("Não é multiplo de 3");
            }

        }
    }
}
