using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumDesktop.Model
{
    class Usuario
    {
        public string Usu_login { get; set; }
        public string Usu_nome { get; set; }
        public string Usu_email { get; set; }
        public string Usu_senha { get; set; }

        public DataTable Pesquisar()
        {
            try
            {
                StringBuilder stringSql = new StringBuilder();
                stringSql.Append("select usu_login as Login, usu_nome as Nome, usu_email as email ");
                stringSql.Append("from usuario ");
                stringSql.Append("where 1");

                if (!Usu_login.Equals(""))
                    stringSql.Append(" and usu_login like @login");
                if (!Usu_nome.Equals(""))
                    stringSql.Append(" and usu_nome like @nome");

                MySqlConnection conexao = new MySqlConnection(Program.stringConexaoMySQL);
                MySqlCommand comando = new MySqlCommand(stringSql.ToString(), conexao);

                comando.Parameters.AddWithValue("@login", "%" + Usu_login + "%");
                comando.Parameters.AddWithValue("@nome", "%" + Usu_nome + "%");

                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = comando;

                DataTable dados = new DataTable();
                adaptador.Fill(dados);
                return dados;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Incluir()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(Program.stringConexaoMySQL);
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "insert into usuario (usu_login, usu_nome, usu_email, usu_senha) " +
                                                  "values (@usu_login,@usu_nome,@usu_email,@usu_senha)";
                conexao.Open();
                comando.Prepare();
                comando.Parameters.AddWithValue("@usu_login", Usu_login);
                comando.Parameters.AddWithValue("@usu_nome", Usu_nome);
                comando.Parameters.AddWithValue("@usu_email", Usu_email);
                comando.Parameters.AddWithValue("@usu_senha", Usu_senha);
                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
