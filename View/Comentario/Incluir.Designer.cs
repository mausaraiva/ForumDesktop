namespace ForumDesktop.View.Comentario
{
    partial class frmIncluirComentario
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
            this.buttonIncluir = new System.Windows.Forms.Button();
            this.textComentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textTema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIncluir
            // 
            this.buttonIncluir.Location = new System.Drawing.Point(187, 221);
            this.buttonIncluir.Name = "buttonIncluir";
            this.buttonIncluir.Size = new System.Drawing.Size(75, 23);
            this.buttonIncluir.TabIndex = 6;
            this.buttonIncluir.Text = "Incluir";
            this.buttonIncluir.UseVisualStyleBackColor = true;
            this.buttonIncluir.Click += new System.EventHandler(this.ButtonIncluir_Click);
            // 
            // textComentario
            // 
            this.textComentario.Location = new System.Drawing.Point(12, 119);
            this.textComentario.Multiline = true;
            this.textComentario.Name = "textComentario";
            this.textComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textComentario.Size = new System.Drawing.Size(423, 85);
            this.textComentario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comentário";
            // 
            // textTema
            // 
            this.textTema.Location = new System.Drawing.Point(12, 30);
            this.textTema.Multiline = true;
            this.textTema.Name = "textTema";
            this.textTema.ReadOnly = true;
            this.textTema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textTema.Size = new System.Drawing.Size(423, 51);
            this.textTema.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tema";
            // 
            // frmIncluirComentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 263);
            this.Controls.Add(this.textTema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonIncluir);
            this.Controls.Add(this.textComentario);
            this.Controls.Add(this.label1);
            this.Name = "frmIncluirComentario";
            this.Text = "Incluir comentário";
            this.Load += new System.EventHandler(this.FrmIncluirComentario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonIncluir;
        private System.Windows.Forms.TextBox textComentario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTema;
        private System.Windows.Forms.Label label2;
    }
}