using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;
using AcessoBanco;

namespace TransferenciaDados
{
    public class TestarDTO
    {
        //receberá o retorno do método obterConexão();
        public MySqlConnection conectar = null;
        //receberá o retorno das exceções;
        public string mensagem = string.Empty;

        //Método
        public void Verificar()
        {
            conectar = Conexao.obterConexao();
            mensagem = Conexao.mensagem;
        }


    }
}
