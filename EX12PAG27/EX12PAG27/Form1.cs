using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX12PAG27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNexibir_Click(object sender, EventArgs e)
        {
            int QT_LITROS;
            QT_LITROS = int.Parse(txtlitros.Text);

            if (QT_LITROS <= 10)
            {
                MessageBox.Show("Você ganhou um chaveiro");
            }

            else if(QT_LITROS > 10 && QT_LITROS <= 30)
            {
                MessageBox.Show("Você ganhara uma ducha no carro");
            }

            if (QT_LITROS > 30 && QT_LITROS <= 40)
            {
                MessageBox.Show("Ganhara uma troca de óleo");
            }
            else if(QT_LITROS > 40)
            {
                MessageBox.Show("Ganhou uma ducha e uma troca de óleo");
            }
        }
    }
}
