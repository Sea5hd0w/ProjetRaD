namespace ProjetRaD
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.WebCamView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WebCamView)).BeginInit();
            this.SuspendLayout();
            // 
            // WebCamView
            // 
            this.WebCamView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebCamView.Location = new System.Drawing.Point(0, 0);
            this.WebCamView.Name = "WebCamView";
            this.WebCamView.Size = new System.Drawing.Size(800, 450);
            this.WebCamView.TabIndex = 0;
            this.WebCamView.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WebCamView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WebCamView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox WebCamView;
    }
}

