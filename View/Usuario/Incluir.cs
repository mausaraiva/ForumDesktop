using ForumDesktop.Controller;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForumDesktop.View.Usuario
{
    public partial class formIncluirUsuario : Form
    {
        public formIncluirUsuario()
        {
            InitializeComponent();
        }

        private void ButtonIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void Incluir()
        {
            string login = textLogin.Text; 
            string nome = textNome.Text; 
            string email= textEmail.Text;
            string senha = textSenha.Text; 

            try
            {
                UsuarioController uController = new UsuarioController();
                uController.Incluir(login, nome, email, senha);

                MessageBox.Show("Registro incluído com sucesso.");
                Limpar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }
        }

        private void Limpar()
        {
            textLogin.Text = "";
            textNome.Text = "";
            textEmail.Text = "";
            textSenha.Text = "";
        }


    }
}
