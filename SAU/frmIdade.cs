using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAU
{
    public partial class frmIdade : Form
    {

        public frmIdade()
        {
            InitializeComponent();
        }

 

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Declarar variáveis
            string nomeUsuario;
            int idadeUsuario;

            //Verificar se os campos foram preenchidos
            /*if ((txtNome.Text != string.Empty) && (txtIdade.Text != string.Empty)) { 
                //Atribuição de Variáveis
                nomeUsuario = txtNome.Text;
                idadeUsuario = Convert.ToInt32(txtIdade.Text); 

                MessageBox.Show("Nome: " + nomeUsuario.ToString() + " e idade " + idadeUsuario.ToString());
            }
           
            else
            {
                if((txtNome.Text != string.Empty && txtIdade.Text == string.Empty)) { 
                    MessageBox.Show("Favor preencher o campo de idade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdade.Focus();
                }
                else if ((txtNome.Text == string.Empty && txtIdade.Text != string.Empty))
                {
                    MessageBox.Show("Favor preencher o campo de Nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Favor preencher os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
                }
            }*/

            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Favor preencher o campo de nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
            }
            else if (txtIdade.Text != string.Empty)
            {
                MessageBox.Show("Favor preencher o campo de Idade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdade.Focus();
            }
            else
            {
                nomeUsuario = txtNome.Text;
                idadeUsuario = Convert.ToInt32(txtIdade.Text);

                MessageBox.Show("Nome: " + nomeUsuario.ToString() + " e idade " + idadeUsuario.ToString());
            }
        
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();

            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja realemte sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void txtIdade_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
    }
}
