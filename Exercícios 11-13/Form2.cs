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
    public partial class frmtabuada : Form
    {
        public frmtabuada()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtresult_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresultado.Clear();
            txtnum.Focus();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
          
            double N, i, resultado;

            N = Convert.ToDouble(txtnum.Text);
            i = 1;
            while (i <= 10)
            {

                resultado = N * i;
                
                txtresultado.Text = String.Concat(txtresultado.Text + "\r\n" + N.ToString() + "x" + i.ToString() + "=" + resultado.ToString() );
                i++;
            }
            txtresultado.Visible = true;
            lblresult.Visible = true;



        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            double N, i, resultado;

            i = 1;
            do
            {
                N = Convert.ToDouble(txtnum.Text);
                resultado = N * i;
                txtresultado.Text = String.Concat(txtresultado.Text + "\r\n" + N.ToString() + "x" + i.ToString() + "=" + resultado.ToString());
                i++;
            } while (i <= 10);
            txtresultado.Visible = true;
            lblresult.Visible = true;



        }

        private void btnate_Click(object sender, EventArgs e)
        {
            double N, i, resultado;
            for ( i = 1; i <= 10; i++)
            {
                N = Convert.ToDouble(txtnum.Text);
                resultado = N * i;
                txtresultado.Text = String.Concat(txtresultado.Text + "\r\n" + N.ToString() + "x" + i.ToString() + "=" + resultado.ToString());
            }
            txtresultado.Visible = true;
            lblresult.Visible = true;

        }
    }
    
}
