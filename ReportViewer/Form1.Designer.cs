namespace ReportViewer {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.openReport001 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openReport001
            // 
            this.openReport001.Location = new System.Drawing.Point(12, 12);
            this.openReport001.Name = "openReport001";
            this.openReport001.Size = new System.Drawing.Size(130, 40);
            this.openReport001.TabIndex = 0;
            this.openReport001.Text = "Abrir Relatório";
            this.openReport001.UseVisualStyleBackColor = true;
            this.openReport001.Click += new System.EventHandler(this.openReport001_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 458);
            this.Controls.Add(this.openReport001);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openReport001;
    }
}

