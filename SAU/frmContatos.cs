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
        TratamentoCampos tratamentoCampos = new TratamentoCampos();
        bool ncadastro = false;

        public frmContatos()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tratamentoCampos.Limpar(this);
            txtNome.Focus();
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
            ConsultarContatos consultarContatos = new ConsultarContatos();
            ContatosDTO dados = new ContatosDTO();

            consultarContatos.ContatosMostrar(dados);
            lstContatos.DataSource = null;
            lstContatos.Items.Clear();

            //popular o listbox
            //Apenas o nome será visível, o código não
            lstContatos.ValueMember = "codContato";
            lstContatos.DisplayMember = "nomedoContato";
            lstContatos.DataSource = consultarContatos.ContatosDataTable;

            //Tornar visível o grupo grpContatos
            grpContatos.Visible = true;

            //Habilitar os controles abaixo
            tratamentoCampos.Bloquear(this);

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
            tratamentoCampos.Desbloquear(this);
            txtCodigo.Enabled = false;

            btnSalvar.Enabled = true;
            btnListar.Enabled = true;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
            if (ncadastro == true)
            {
                tratamentoCampos.Desbloquear(this);
                tratamentoCampos.Limpar(this);
                txtCodigo.Enabled = false;
                btnSalvar.Text = "Salvar";
                ncadastro = false;
            }
            else 
            { 
            //Definir variável para receber o nome do textbox
            TextBox textBox = new TextBox();
            //Criar uma variável de controle para indicar o textbox que irá receber o focus/msg
            bool finalizar = false;
            //Criar uma consulta LINQ
            var controle = from ctrl in this.Controls.OfType<TextBox>()
                           where ctrl.Name != "txtCodigo"
                           orderby ctrl.TabIndex
                           select ctrl;

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

            if(txtUF.Text != string.Empty && txtTelefone.Text == string.Empty) {
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
            if (finalizar == true && mskCep.Text != String.Empty)
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
                    tratamentoCampos.Bloquear(this);
                    btnSalvar.Text = "Novo";
                    ncadastro = true;
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o cadastro - " + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
            }
        }

        private void lstContatos_Click(object sender, EventArgs e)
        {
            //extrair o código do contato selecionado
            DataRowView drv = (DataRowView)lstContatos.Items[lstContatos.SelectedIndex];
            //instanciar a clase consultar contatos
            ConsultarContatos consultarContatos = new ConsultarContatos();
            ContatosDTO dados = new ContatosDTO();
            consultarContatos.ContatosMostrar(dados);

            //Percorrer o datatable para localizar os dados do contato selecionado
            for (int i = 0; i < consultarContatos.ContatosDataTable.Rows.Count; i++)
            {
                if (drv["codContato"].ToString() == consultarContatos.ContatosDataTable.Rows[i]["codContato"].ToString())
                {
                    txtCodigo.Text = consultarContatos.ContatosDataTable.Rows[i]["codContato"].ToString();
                    txtNome.Text = consultarContatos.ContatosDataTable.Rows[i]["nomedoContato"].ToString();
                    txtEndereco.Text = consultarContatos.ContatosDataTable.Rows[i]["enderecoContato"].ToString();
                    txtBairro.Text = consultarContatos.ContatosDataTable.Rows[i]["bairro"].ToString();
                    txtCidade.Text = consultarContatos.ContatosDataTable.Rows[i]["cidade"].ToString();
                    txtUF.Text = consultarContatos.ContatosDataTable.Rows[i]["uf"].ToString();
                    mskCep.Text = consultarContatos.ContatosDataTable.Rows[i]["cep"].ToString();
                    txtTelefone.Text = consultarContatos.ContatosDataTable.Rows[i]["telefoneContato"].ToString();
                    txtEmail.Text = consultarContatos.ContatosDataTable.Rows[i]["emailContato"].ToString();

                    btnFechar_Click(null, null);
                }
            }
            tratamentoCampos.Bloquear(this);
            btnSalvar.Text = "Novo";
            ncadastro = true;
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