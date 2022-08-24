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
            if (MessageBox.Show("Deseja realemte sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            /*foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (String.IsNullOrEmpty(item.Text))
                    {
                        item.BackColor = Color.Yellow;
                        item.Focus();
                    }
                    else
                    {
                        item.BackColor = Color.White;
                    }
                }
            }*/
            //Definir variável para receber o nome do textbox
            TextBox textBox = new TextBox();
            //Criar uma variável de controle para indicar o textbox que irá receber o focus/msg
            bool finalizar = false;
            //Criar uma consulta LINQ
            var controle = from ctrl in this.Controls.OfType<TextBox>()
                           where ctrl.Name != "txtCodigo"
                           orderby ctrl.TabIndex
                           select ctrl;

           
            //
            foreach (var ctrlTxt in controle)
            {
                if(ctrlTxt.Text == String.Empty)
                {
                    finalizar = true;
                    textBox.Name = ctrlTxt.Name;
                    ctrlTxt.Focus();
                    break;
                }
            }

            if(txtEmail.Text != string.Empty) { 
             //Remover a máscara -formatação
                mskCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (mskCep.Text == String.Empty)
                {
                    MessageBox.Show("Favor infomar o CEP ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskCep.Focus();
                    finalizar = true;
                }
                else
                {
                    mskCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                }
            }

            

            //Apresentar a mensagem para preencher os campos
            if (finalizar == true && mskCep.Text != string.Empty)
            {
                MessageBox.Show("Favor preencher o campo " + textBox.Name.Substring(3, textBox.Name.Length - 3), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (finalizar == false)
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

                //Validar o resultado
                if (dados.codigo != 0)
                {
                    //Popular o campo código
                    txtCodigo.Text = dados.codigo.ToString();
                    MessageBox.Show("Cadastro realizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o cadastro - " + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
            }






        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmContatos_Load(object sender, EventArgs e)
        {

        }

        private void txtNumeroEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroEndereco_KeyPress(object sender, KeyPressEventArgs e)
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