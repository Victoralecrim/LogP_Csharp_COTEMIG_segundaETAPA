using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX07PAG27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            int N1, N2;
            N1 = int.Parse(txtN1.Text);
            N2  = int.Parse(txtN2.Text);

            if (N1 > N2)
            {
                MessageBox.Show("N1 é maior que N2");
            }
            else
            {
                MessageBox.Show("N2´é maior que N1");
            }
        }
    }
}
