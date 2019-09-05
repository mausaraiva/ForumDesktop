namespace ForumDesktop.View.Comentario
{
    partial class frmVisualizarComentario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewComentario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIncluirComentario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComentario)).BeginInit();
            this.SuspendLayout();
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(12, 25);
            this.textDescricao.Multiline = true;
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.ReadOnly = true;
            this.textDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDescricao.Size = new System.Drawing.Size(426, 53);
            this.textDescricao.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tema";
            // 
            // dataGridViewComentario
            // 
            this.dataGridViewComentario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComentario.Location = new System.Drawing.Point(12, 124);
            this.dataGridViewComentario.Name = "dataGridViewComentario";
            this.dataGridViewComentario.Size = new System.Drawing.Size(426, 136);
            this.dataGridViewComentario.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Comentários";
            // 
            // buttonIncluirComentario
            // 
            this.buttonIncluirComentario.Location = new System.Drawing.Point(319, 95);
            this.buttonIncluirComentario.Name = "buttonIncluirComentario";
            this.buttonIncluirComentario.Size = new System.Drawing.Size(119, 23);
            this.buttonIncluirComentario.TabIndex = 17;
            this.buttonIncluirComentario.Text = "Incluir comentário";
            this.buttonIncluirComentario.UseVisualStyleBackColor = true;
            this.buttonIncluirComentario.Click += new System.EventHandler(this.ButtonIncluirComentario_Click);
            // 
            // frmVisualizarComentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 270);
            this.Controls.Add(this.buttonIncluirComentario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewComentario);
            this.Name = "frmVisualizarComentario";
            this.Text = "Visualizar comentários";
            this.Activated += new System.EventHandler(this.FrmVisualizarComentario_Activated);
            this.Load += new System.EventHandler(this.FrmVisualizarComentario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComentario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewComentario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIncluirComentario;
    }
}