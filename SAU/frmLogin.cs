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
    public partial class frmLogin : Form
    {
        public bool LoginSucesso = false; 

        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Size = new Size(350, 300);
            this.Location = new Point(360, 200);
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            pnlMudarSenha.Location = new Point(548, 24);

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            //efetuar a verificação dos campos usuário e senha
            //verificar se o campo txtusuario está preenchido

            if (txtEmailUsuario.Text == string.Empty)
            {
                MessageBox.Show("Favor informar o usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmailUsuario.Focus();
            }
            else if (mskSenha.Text == string.Empty)
            {
                MessageBox.Show("Favor digitar a senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskSenha.Focus();
            }
            else
            {
                //Instanciar as classes
                ValidarUsuario validarUsuario = new ValidarUsuario();
                UsuariosDTO dados = new UsuariosDTO();
                //popular a classe
                dados.nomeusuario = txtEmailUsuario.Text;
                dados.senhausuario = mskSenha.Text;
                //chamar o método
                validarUsuario.UsuariosConectar(dados);
                if(dados.mensagens != null)
                {
                    MessageBox.Show(dados.mensagens);
                }
                else
                {
                    switch (dados.logado)
                    {
                        case 0:
                            MessageBox.Show("Usuário ou senha incorretos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtEmailUsuario.Clear();
                            mskSenha.Clear();
                            txtEmailUsuario.Focus();
                            LoginSucesso = false;
                            break;
                        case 1:
                            LoginSucesso = true;
                            MessageBox.Show("Bem vindo ao sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtEmailUsuario.Clear();
                            mskSenha.Clear();
                            if(LoginSucesso == true)
                            {
                                Close();
                            }
                            break;
                        case 2:
                            MessageBox.Show("Usuário ja conectado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtEmailUsuario.Clear();
                            mskSenha.Clear();
                            txtEmailUsuario.Focus();
                            LoginSucesso = false;
                            break;
                        case 3:
                            MessageBox.Show("Seu primeiro acesso"+ "será necessário alterar a senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtEmailUsuario.Clear();
                            mskSenha.Clear();
                            pnlMudarSenha.Location = new Point(12,12);
                            mskSenhaAtual.Focus();
                            break;
                        case 4:
                            MessageBox.Show("Verifique o ocorrido" + "junto ao Administrador do sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
            }
        }





        private void mskSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void lblEmailUsuario_Click(object sender, EventArgs e)
        {

        }
        private void mskRepetirSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void mskNovaSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void mskSenhaAtual_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
