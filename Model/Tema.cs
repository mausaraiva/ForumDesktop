using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumDesktop.Model
{
    class Tema
    {
        public int Tem_id { get; set; }
        public string Tem_descricao { get; set; }
        public DateTime Tem_momento { get; set; }
        public string Usu_login { get; set; }

        public DataTable Pesquisar()
        {
            try
            {
                StringBuilder stringSql = new StringBuilder();
                stringSql.Append("select tem_id, tem_descricao as Tema, tem_momento as Momento, usu_login as Usuario ");
                stringSql.Append("from tema ");
                stringSql.Append("where 1");

                if (Tem_id != 0)
                    stringSql.Append(" and tem_id=@tem_id");
                if (!Tem_descricao.Equals(""))
                    stringSql.Append(" and tem_descricao like @tem_descricao");

                MySqlConnection conexao = new MySqlConnection(Program.stringConexaoMySQL);
                MySqlCommand comando = new MySqlCommand(stringSql.ToString(), conexao);

                comando.Parameters.AddWithValue("@tem_id", Tem_id);
                comando.Parameters.AddWithValue("@tem_descricao", "%" + Tem_descricao + "%");

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
                comando.CommandText = "insert into tema (tem_descricao, tem_momento, usu_login) " +
                                               "values (@tem_descricao, NOW(), @usu_login)";
                conexao.Open();
                comando.Prepare();
                comando.Parameters.AddWithValue("@tem_descricao", Tem_descricao);
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
