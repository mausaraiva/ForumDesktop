using ForumDesktop.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForumDesktop.View
{
    public partial class formPesquisarUsuario : Form
    {
        public formPesquisarUsuario()
        {
            InitializeComponent();
        }

        private void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            string login = textLogin.Text; 
            string nome = textNome.Text; ;

            UsuarioController uController = new UsuarioController();
            dataGridViewUsuario.DataSource = uController.Pesquisar(login, nome);
        }
    }
}
