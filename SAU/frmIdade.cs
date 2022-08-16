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

            string nomeUsuario;
            int idadeUsuario;

            nomeUsuario = txtNome.Text;
            idadeUsuario = Convert.ToInt32(txtIdade.Text); 

            MessageBox.Show("Nome: " + nomeUsuario.ToString() + " e idade " + idadeUsuario.ToString());
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
    }
}
