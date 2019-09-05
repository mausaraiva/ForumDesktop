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
    public partial class frmVisualizarComentario : Form
    {
        public int TemaId;
        public string TemaDescricao;
        public frmVisualizarComentario()
        {
            InitializeComponent();
        }

        private void ButtonPesquisar_Click(object sender, EventArgs e)
        {
        }
        private void Pesquisar()
        {
            try
            {
                ComentarioController cController = new ComentarioController();
                dataGridViewComentario.DataSource = cController.Pesquisar(TemaId);
                dataGridViewComentario.Columns[0].Visible = false;
                dataGridViewComentario.Columns[1].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }
        }

        private void FrmVisualizarComentario_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        private void ButtonIncluirComentario_Click(object sender, EventArgs e)
        {
            frmIncluirComentario frm = new frmIncluirComentario();
            frm.TemaId = TemaId;
            frm.TemaDescricao = TemaDescricao;
            frm.Show();
        }

        private void FrmVisualizarComentario_Activated(object sender, EventArgs e)
        {
            Carregar();
        }

        private void Carregar()
        {
            Pesquisar();
            textDescricao.Text = TemaDescricao;
        }
    }
}
