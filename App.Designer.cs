namespace CRUD_Relatorios
{
    partial class App
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgVer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgVer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVer
            // 
            this.dgVer.AllowUserToAddRows = false;
            this.dgVer.AllowUserToDeleteRows = false;
            this.dgVer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVer.Location = new System.Drawing.Point(12, 39);
            this.dgVer.Name = "dgVer";
            this.dgVer.ReadOnly = true;
            this.dgVer.Size = new System.Drawing.Size(718, 361);
            this.dgVer.TabIndex = 0;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 412);
            this.Controls.Add(this.dgVer);
            this.Name = "App";
            this.Text = "CRUD com Geração de Relatorios";
            this.Load += new System.EventHandler(this.App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVer;
    }
}

