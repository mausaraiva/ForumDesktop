using ForumDesktop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumDesktop.Controller
{
    class TemaController
    {
        public DataTable Pesquisar(string descricao)
        {
            Tema tema = new Tema();
            tema.Tem_descricao = descricao;
            return tema.Pesquisar();
        }

        public void Incluir(string descricao, string login)
        {
            Tema tema = new Tema();
            tema.Tem_descricao = descricao;
            tema.Usu_login = login;
            tema.Incluir();
        }
    }
}
