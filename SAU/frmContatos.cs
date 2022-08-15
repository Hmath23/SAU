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
            txtNome.Clear();
            txtEndereco.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
    
        }
    }
}
