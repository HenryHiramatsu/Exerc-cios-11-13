using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios_11_13
{
    public partial class frmtemperatura : Form
    {
        public frmtemperatura()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcelcius.Clear();
            txtresultado.Clear();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double C, i, resultado;

            C = Convert.ToDouble(txtcelcius.Text);
            
            i = 1;
            while (i <= 11)
            {
                resultado = C * 1.8 + 32 + (i * 10);
               
                txtresultado.Text = String.Concat(txtresultado.Text + "\r\n" + resultado.ToString() + "Fº");
                i++;
            }

            
        }

        private void btnrepita_Click(object sender, EventArgs e)
        {
            double C, i, resultado;

            i = 1;
            do
            {
                C = Convert.ToDouble(txtcelcius.Text);
                resultado = C * 1.8 + 32 + (i * 10);
                txtresultado.Text = String.Concat(txtresultado.Text + "\r\n" + resultado.ToString() + "Fº");
                i++;
            } while (i <= 11);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double C, i, resultado;
            for (i = 1; i<= 11; i++)
            {
                C = Convert.ToDouble(txtcelcius.Text);
                resultado = C * 1.8 + 32 + (i * 10);
                txtresultado.Text = String.Concat(txtresultado.Text + "\r\n" + resultado.ToString() + "Fº");
            }


        }
    }
}
