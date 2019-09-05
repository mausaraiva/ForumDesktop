namespace ForumDesktop.View.Tema
{
    partial class formPesquisarTema
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
            this.dataGridViewTema = new System.Windows.Forms.DataGridView();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTema)).BeginInit();
            this.SuspendLayout();
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(57, 18);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(300, 20);
            this.textDescricao.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tema";
            // 
            // dataGridViewTema
            // 
            this.dataGridViewTema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTema.Location = new System.Drawing.Point(12, 45);
            this.dataGridViewTema.Name = "dataGridViewTema";
            this.dataGridViewTema.Size = new System.Drawing.Size(426, 208);
            this.dataGridViewTema.TabIndex = 7;
            this.dataGridViewTema.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTema_CellContentClick);
            this.dataGridViewTema.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTema_CellContentDoubleClick);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(363, 16);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 6;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.ButtonPesquisar_Click);
            // 
            // formPesquisarTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 262);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewTema);
            this.Controls.Add(this.buttonPesquisar);
            this.Name = "formPesquisarTema";
            this.Text = "Pesquisar tema";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewTema;
        private System.Windows.Forms.Button buttonPesquisar;
    }
}