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
    public partial class frmarea : Form
    {
        public frmarea()
        {
            InitializeComponent();
        }
        double atotal;

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double comp, larg, area;

            larg = Convert.ToDouble(txtlarg.Text);
            comp = Convert.ToDouble(txtcomp.Text);
            area = larg * comp;

            atotal += area;
            txtarea.Text = area.ToString();

            var result = MessageBox.Show("Deseja continuar calculando?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtarea.Clear();
                txtlarg.Clear();
                txtcomp.Clear();
                txtnome.Clear();
            }
            else
            {
                lblatotal.Visible = true;
                txtatotal.Visible = true;
                txtatotal.Text = atotal.ToString();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtarea.Clear();
            txtatotal.Clear();
            txtcomp.Clear();
            txtlarg.Clear();
            txtnome.Clear();
            lblarea.Visible = true;
            txtarea.Visible = true;
            lblatotal.Visible = false;
            txtatotal.Visible = false;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
