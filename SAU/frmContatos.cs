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
    public partial class frmContatos : Form
    {
        public frmContatos()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Rotina para limpar os controles
            txtCodigo.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtNumeroEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            txtCep.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();


            //Posicionar o cursor
            txtCodigo.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Rotina para sair do form;
            //Enviar mensagem
            MessageBox.Show("Deseja realemte sair?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }


    }
}