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

        private void btnDividir_Click(object sender, EventArgs e)
        {

            if (txtN1Divisao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("preencher o número 1 da divisão.");
                txtN1Divisao.Focus();
                txtN1Divisao.Clear();
            }
            else if (txtN2Divisao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("preencher o número 2 da divisão.");
                txtN2Divisao.Focus();
                txtN2Divisao.Clear();
            }
            else
            {
                double n1, n2, resultado;
                try
                {
                    n1 = Convert.ToDouble(txtN1Divisao.Text);
                    n2 = Convert.ToDouble(txtN2Divisao.Text);
                    resultado = n1 / n2;
                    txtRDividir.Text = Convert.ToString(resultado);
                }
                catch
                {
                    MessageBox.Show("digite os números corretamente.");
                }
            }
        }

        private void btnSubtrair_TextChanged(object sender, EventArgs e)
        {

           if (txtN1Subtracao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("preencher o número 1 da subtração.");
                txtN1Subtracao.Focus();
                txtN1Subtracao.Clear();
            }
            else if (txtN2Subtracao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("preencher o número 2 da subtração.");
                txtN2Subtracao.Focus();
                txtN2Subtracao.Clear();
            }
            else
            {
                double n1, n2, resultado;
                try
                {
                    n1 = Convert.ToDouble(txtN1Subtracao.Text);
                    n2 = Convert.ToDouble(txtN2Subtracao.Text);
                    resultado = n1 - n2;
                    txtRSubtracao.Text = Convert.ToString(resultado);
                }
                catch
                {
                    MessageBox.Show("digite os números corretamente.");
                }
            }

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

            if (txtN1Multiplicacao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("preencher o número 1 da multiplicação.");
                txtN1Multiplicacao.Focus();
                txtN1Multiplicacao.Clear();
            }
            else if (txtN2Multiplicacao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("preencher o número 2 da multiplicação.");
                txtN2Multiplicacao.Focus();
                txtN2Multiplicacao.Clear();
            }
            else
            {
                double n1, n2, resultado;
                try
                {
                    n1 = Convert.ToDouble(txtN1Multiplicacao.Text);
                    n2 = Convert.ToDouble(txtN2Multiplicacao.Text);
                    resultado = n1 * n2;
                    txtRMultiplicacao.Text = Convert.ToString(resultado);
                }
                catch
                {
                    MessageBox.Show("digite os números corretamente.");
                }
            }

        }
    }
}
