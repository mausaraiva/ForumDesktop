namespace ForumDesktop.View.Home
{
    partial class frmHome
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
            this.buttonVerTemas = new System.Windows.Forms.Button();
            this.buttonIncluirTema = new System.Windows.Forms.Button();
            this.buttonIncluirUsuario = new System.Windows.Forms.Button();
            this.buttonPesquisarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVerTemas
            // 
            this.buttonVerTemas.Location = new System.Drawing.Point(150, 12);
            this.buttonVerTemas.Name = "buttonVerTemas";
            this.buttonVerTemas.Size = new System.Drawing.Size(151, 47);
            this.buttonVerTemas.TabIndex = 0;
            this.buttonVerTemas.Text = "Pesquisar temas";
            this.buttonVerTemas.UseVisualStyleBackColor = true;
            this.buttonVerTemas.Click += new System.EventHandler(this.ButtonVerTemas_Click);
            // 
            // buttonIncluirTema
            // 
            this.buttonIncluirTema.Location = new System.Drawing.Point(150, 65);
            this.buttonIncluirTema.Name = "buttonIncluirTema";
            this.buttonIncluirTema.Size = new System.Drawing.Size(151, 47);
            this.buttonIncluirTema.TabIndex = 1;
            this.buttonIncluirTema.Text = "Incluir tema";
            this.buttonIncluirTema.UseVisualStyleBackColor = true;
            this.buttonIncluirTema.Click += new System.EventHandler(this.ButtonIncluirTema_Click);
            // 
            // buttonIncluirUsuario
            // 
            this.buttonIncluirUsuario.Location = new System.Drawing.Point(150, 171);
            this.buttonIncluirUsuario.Name = "buttonIncluirUsuario";
            this.buttonIncluirUsuario.Size = new System.Drawing.Size(151, 47);
            this.buttonIncluirUsuario.TabIndex = 2;
            this.buttonIncluirUsuario.Text = "Incluir usuário";
            this.buttonIncluirUsuario.UseVisualStyleBackColor = true;
            this.buttonIncluirUsuario.Click += new System.EventHandler(this.ButtonIncluirUsuario_Click);
            // 
            // buttonPesquisarUsuario
            // 
            this.buttonPesquisarUsuario.Location = new System.Drawing.Point(150, 118);
            this.buttonPesquisarUsuario.Name = "buttonPesquisarUsuario";
            this.buttonPesquisarUsuario.Size = new System.Drawing.Size(151, 47);
            this.buttonPesquisarUsuario.TabIndex = 3;
            this.buttonPesquisarUsuario.Text = "Pesquisar usuário";
            this.buttonPesquisarUsuario.UseVisualStyleBackColor = true;
            this.buttonPesquisarUsuario.Click += new System.EventHandler(this.ButtonPesquisarUsuario_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 234);
            this.Controls.Add(this.buttonPesquisarUsuario);
            this.Controls.Add(this.buttonIncluirUsuario);
            this.Controls.Add(this.buttonIncluirTema);
            this.Controls.Add(this.buttonVerTemas);
            this.Name = "frmHome";
            this.Text = "Fórum de discussão";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVerTemas;
        private System.Windows.Forms.Button buttonIncluirTema;
        private System.Windows.Forms.Button buttonIncluirUsuario;
        private System.Windows.Forms.Button buttonPesquisarUsuario;
    }
}