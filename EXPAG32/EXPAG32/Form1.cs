using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXPAG32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNEXIBIR_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(comboNumbers.Text);
            switch (a)
            {
                case 0: MessageBox.Show("Zero");break;
                case 1: MessageBox.Show("um"); break;
                case 2: MessageBox.Show("um"); break;
                case 3: MessageBox.Show("um"); break;
                case 4: MessageBox.Show("um"); break;
                case 5: MessageBox.Show("um"); break;

                default:
                    MessageBox.Show("Fora do intervalo definido");
                    break;
            }
        }

       
    }
}
