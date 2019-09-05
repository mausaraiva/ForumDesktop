using ForumDesktop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumDesktop.Controller
{
    class ComentarioController
    {
        public DataTable Pesquisar(int tema)
        {
            Comentario comentario = new Comentario();
            comentario.Tem_id = tema;
            return comentario.Pesquisar();
        }

        public void Incluir(int tema, string descricao, string login)
        {
            Comentario comentario = new Comentario();
            comentario.Tem_id = tema;
            comentario.Com_descricao = descricao;
            comentario.Usu_login = login;
            comentario.Incluir();
        }
    }
}
