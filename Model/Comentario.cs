using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumDesktop.Model
{
    class Comentario
    {
        public int Com_id { get; set; }
        public int Tem_id { get; set; }
        public string Com_descricao { get; set; }
        public DateTime Com_momento { get; set; }
        public string Usu_login { get; set; }

        public DataTable Pesquisar()
        {
            try
            {
                StringBuilder stringSql = new StringBuilder();
                stringSql.Append("select com_id, tem_id, com_descricao as Comentario, com_momento as Momento, usu_login as Usuario ");
                stringSql.Append("from comentario ");
                stringSql.Append("where tem_id=@tem_id");

                MySqlConnection conexao = new MySqlConnection(Program.stringConexaoMySQL);
                MySqlCommand comando = new MySqlCommand(stringSql.ToString(), conexao);

                comando.Parameters.AddWithValue("@tem_id", Tem_id);

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
                comando.CommandText = "insert into comentario (tem_id, com_descricao, com_momento, usu_login) " +
                                                     "values (@tem_id, @com_descricao, NOW(), @usu_login)";
                conexao.Open();
                comando.Prepare();
                comando.Parameters.AddWithValue("@tem_id", Tem_id);
                comando.Parameters.AddWithValue("@com_descricao", Com_descricao);
                comando.Parameters.AddWithValue("@usu_login", Usu_login);
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
