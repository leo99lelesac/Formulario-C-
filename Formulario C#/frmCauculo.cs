using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_C_
{
    public partial class frmCauculo : Form
    {
        public frmCauculo()
        {
            InitializeComponent();
        }

        private void txtN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (txtN1.Text.Trim() == string.Empty)
            { 
                MessageBox.Show("preencher o numero 1 da soma ");
                txtN1.Focus();
                txtN1.Clear();
            }

            else if (txtN2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("preencher o numero 2 da soma ");
                txtN2.Focus();
                txtN2.Clear();
            }
            else
            {
                double n1, n2, resultado;
                try
                {
                    n1 = Convert.ToDouble(txtN1.Text);
                    n2 = Convert.ToDouble(txtN2.Text);
                    resultado = n1 + n2;
                    txtResultado.Text = Convert.ToString(resultado);
                }
                catch 
                {
                    MessageBox.Show("digite os números corretamente.");
                }
            }
        }
    }
}
