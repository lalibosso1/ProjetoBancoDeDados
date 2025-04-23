using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_BancoDados_TurmaB_1Sem.Model_DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_BancoDados_TurmaB_1Sem.Controller_DAO
{
    class DAO_Usuario
    {
        ConexaoMySQL conexao = new ConexaoMySQL();

        #region Método de Login do aplicativo

        public DTO_Usuario Login (DTO_Usuario usu)
        {
            MySqlConnection cn = conexao.String_Conexao();
            try
            {
                string comando = "select * from tb_usuario " + 
                    "where email_usu=@email and senha_usu=@senha";

                MySqlCommand cmd = new MySqlCommand(comando, cn);
                cmd.Parameters.AddWithValue("@email", usu.Email_usu);
                cmd.Parameters.AddWithValue("@senha", usu.Senha_usu);
                cn.Open();
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                foreach (DataRow linha in dt.Rows)
                {
                    usu.Id_usu = Convert.ToInt32(linha["id_usu"]);
                    usu.Email_usu = linha["email_usu"].ToString();
                    usu.Nome_usu = linha["nome_usu"].ToString();
                    usu.Senha_usu = linha["senha_usu"].ToString();

                }

                return usu;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }

        #endregion
    }
}
