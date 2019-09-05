using ForumDesktop.Controller;
using ForumDesktop.View.Comentario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForumDesktop.View.Tema
{
    public partial class formPesquisarTema : Form
    {
        public formPesquisarTema()
        {
            InitializeComponent();
        }

        private void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            try
            {
                string descricao = textDescricao.Text;
                TemaController tController = new TemaController();
                dataGridViewTema.DataSource = tController.Pesquisar(descricao);
                dataGridViewTema.Columns[0].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }
        }

        private void DataGridViewTema_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmVisualizarComentario frm = new frmVisualizarComentario();
            frm.TemaId = Int32.Parse(dataGridViewTema.Rows[e.RowIndex].Cells[0].Value.ToString());
            frm.TemaDescricao = dataGridViewTema.Rows[e.RowIndex].Cells[1].Value.ToString();
            frm.Show();
        }

        private void DataGridViewTema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
