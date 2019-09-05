using ForumDesktop.View.Tema;
using ForumDesktop.View.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForumDesktop.View.Home
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void ButtonVerTemas_Click(object sender, EventArgs e)
        {
            formPesquisarTema frmPT = new formPesquisarTema();
            frmPT.Show();
        }

        private void ButtonIncluirTema_Click(object sender, EventArgs e)
        {
            formIncluirTema frmIT = new formIncluirTema();
            frmIT.Show();
        }

        private void ButtonIncluirUsuario_Click(object sender, EventArgs e)
        {
            formIncluirUsuario frmIU = new formIncluirUsuario();
            frmIU.Show();
        }

        private void ButtonPesquisarUsuario_Click(object sender, EventArgs e)
        {
            formPesquisarUsuario frmPU = new formPesquisarUsuario();
            frmPU.Show();
        }
    }
}
