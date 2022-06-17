using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_PAGINA33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string opcao;
                opcao = (comboBox1.Text);

                switch (opcao.ToUpper())
                {
                    case "A": MessageBox.Show("Opçao A escolhida");break;
                    case "B": MessageBox.Show("Opçao A escolhida"); break;
                    case "C": MessageBox.Show("Opçao A escolhida"); break;
                    default:
                        MessageBox.Show("opção invalida ! ");
                        break;
            }  
        }
    }
}
