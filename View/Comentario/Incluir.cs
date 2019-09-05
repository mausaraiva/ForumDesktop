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

namespace ForumDesktop.View.Comentario
{
    public partial class frmIncluirComentario : Form
    {
        public int TemaId;
        public string TemaDescricao;
        public frmIncluirComentario()
        {
            InitializeComponent();
        }

        private void ButtonIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void Incluir()
        {
            try
            {
                string descricao = textComentario.Text.ToString();
                ComentarioController cController = new ComentarioController();
                cController.Incluir(TemaId, descricao, Program.usuarioLogado);

                MessageBox.Show("Registro incluído com sucesso");
                Limpar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }
        }

        private void FrmIncluirComentario_Load(object sender, EventArgs e)
        {
            textTema.Text = TemaDescricao;
        }

        private void Limpar()
        {
            textComentario.Text = "";
        }

    }
}
