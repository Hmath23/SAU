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
    public partial class frmAcesso : Form
    {
        public frmAcesso()
        {
            InitializeComponent();
        }

        private void frmAcesso_Load(object sender, EventArgs e)
        {

        }

        private void btnTeste_Click(object sender, EventArgs e)
        {  
            //Instanciar a classe
            TestarDTO testarConexao = new TestarDTO();
            //Chamar o método
            testarConexao.Verificar();
            //Determinar o tamanho máximo na label
            lblResult.MaximumSize = new Size(700, 0);
            //Qual o retorno??
            if (testarConexao.conectar == null)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text ="Falhou!!!";
                MessageBox.Show(testarConexao.mensagem, "Aviso");
            }
            else
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text ="OK";
            }
        }
    }
}