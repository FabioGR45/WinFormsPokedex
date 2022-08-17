namespace PokemonAPI
{
    partial class PokeVista
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageN = new System.Windows.Forms.PictureBox();
            this.Nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageN)).BeginInit();
            this.SuspendLayout();
            // 
            // imageN
            // 
            this.imageN.Location = new System.Drawing.Point(3, 3);
            this.imageN.Name = "imageN";
            this.imageN.Size = new System.Drawing.Size(144, 101);
            this.imageN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageN.TabIndex = 0;
            this.imageN.TabStop = false;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold);
            this.Nome.ForeColor = System.Drawing.SystemColors.Window;
            this.Nome.Location = new System.Drawing.Point(46, 107);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(49, 18);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "label1";
            // 
            // PokeVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.imageN);
            this.Name = "PokeVista";
            this.Load += new System.EventHandler(this.PokeVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageN;
        private System.Windows.Forms.Label Nome;
    }
}
