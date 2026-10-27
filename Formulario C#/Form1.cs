using System;
using System.Windows.Forms;

namespace Formulario_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("preencher o campo nome");
                txtNome.Focus();
                txtNome.Clear();
            }

            else if (txtRua.Text.Trim() == string.Empty)
            {
                MessageBox.Show("preemchjer o campo rua");
                txtRua.Focus();
                txtRua.Clear();
            }

            else if (txtBairro.Text.Trim() == string.Empty)
            {
                MessageBox.Show("preencher o campo bairro");
                txtBairro.Focus();
                txtBairro.Clear();
            }


            else
            { 
                string nome, bairro, rua;

                nome = txtNome.Text;
                rua = txtRua.Text;
                bairro = txtBairro.Text;

                MessageBox.Show("O nome digitado é: " + nome + "\nA rua digitada é: " + rua + "\nO bairro digitado é: " + bairro);
            }




        }

       
    }
}
