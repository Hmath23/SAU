using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransferenciaDados;

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
            mskCep.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();

            //Posicionar o cursor
            txtCodigo.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Rotina para sair do form;
            //Enviar mensagem
            if(MessageBox.Show("Deseja realemte sair?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //Tornar visível o grupo grpContatos
            grpContatos.Visible = true;

            //Habilitar os controles abaixo
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumeroEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUF.Enabled = false;
            mskCep.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;

            btnSalvar.Enabled = false;
            btnListar.Enabled = false;
            btnLimpar.Enabled = false;
            btnSair.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Tornar invisível o grupo grpContatos
            grpContatos.Visible = false;

            //Desabilitar os controles abaixo
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumeroEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;
            mskCep.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;

            btnSalvar.Enabled = true;
            btnListar.Enabled = true;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instanciar as Classes
            SalvarContatos salvarContatos = new SalvarContatos();
            ContatosDTO dados = new ContatosDTO();

            //Popular a classe
            dados.nome = txtNome.Text;
            dados.endereco = txtEndereco.Text;
            dados.numero = Convert.ToInt32(txtNumeroEndereco.Text);
            dados.bairro = txtBairro.Text;
            dados.cidade = txtCidade.Text;
            dados.uf = txtUF.Text;
            dados.cep = mskCep.Text;
            dados.telefone = txtTelefone.Text;
            dados.email = txtEmail.Text;

            //chamar o método
            salvarContatos.ContatosIncuir(dados);
        }







        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmContatos_Load(object sender, EventArgs e)
        {

        }

        
    }
}