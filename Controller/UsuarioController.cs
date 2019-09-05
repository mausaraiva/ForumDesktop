using ForumDesktop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumDesktop.Controller
{
    class UsuarioController
    {
        public DataTable Pesquisar(string login, string nome)
        {
            Usuario usuario = new Usuario();
            usuario.Usu_login = login;
            usuario.Usu_nome = nome;
            return usuario.Pesquisar();
        }

        public void Incluir(string login, string nome, string email, string senha)
        {
            Usuario usuario = new Usuario();
            usuario.Usu_login = login;
            usuario.Usu_nome = nome;
            usuario.Usu_email = email;
            usuario.Usu_senha = senha;
            usuario.Incluir();
        }

    }
}
