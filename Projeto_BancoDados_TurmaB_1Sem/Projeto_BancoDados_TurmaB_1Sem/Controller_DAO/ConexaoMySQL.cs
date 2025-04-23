using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_BancoDados_TurmaB_1Sem.Controller_DAO
{
    class ConexaoMySQL
    {
        public MySqlConnection String_Conexao()
        {
            return new MySqlConnection("user id=root;password=root;server=localhost;database=bd_login;SslMode=none");
        }
    }
}
