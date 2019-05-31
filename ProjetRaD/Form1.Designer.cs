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
            this.webcam_stream = new System.Windows.Forms.PictureBox();
            this.start_webcam = new System.Windows.Forms.Button();
            this.webcam_img = new System.Windows.Forms.PictureBox();
            this.capture_image = new System.Windows.Forms.Button();
            this.start_analyse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WebCamView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcam_stream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcam_img)).BeginInit();
            this.SuspendLayout();
            // 
            // WebCamView
            // 
            this.WebCamView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebCamView.Location = new System.Drawing.Point(0, 0);
            this.WebCamView.Name = "WebCamView";
            this.WebCamView.Size = new System.Drawing.Size(698, 301);
            this.WebCamView.TabIndex = 0;
            this.WebCamView.TabStop = false;
            // 
            // webcam_stream
            // 
            this.webcam_stream.Location = new System.Drawing.Point(12, 41);
            this.webcam_stream.Name = "webcam_stream";
            this.webcam_stream.Size = new System.Drawing.Size(313, 239);
            this.webcam_stream.TabIndex = 1;
            this.webcam_stream.TabStop = false;
            // 
            // start_webcam
            // 
            this.start_webcam.Location = new System.Drawing.Point(12, 12);
            this.start_webcam.Name = "start_webcam";
            this.start_webcam.Size = new System.Drawing.Size(108, 23);
            this.start_webcam.TabIndex = 2;
            this.start_webcam.Text = "Start WebCam";
            this.start_webcam.UseVisualStyleBackColor = true;
            this.start_webcam.Click += new System.EventHandler(this.start_webcam_Click);
            // 
            // webcam_img
            // 
            this.webcam_img.Location = new System.Drawing.Point(332, 41);
            this.webcam_img.Name = "webcam_img";
            this.webcam_img.Size = new System.Drawing.Size(339, 246);
            this.webcam_img.TabIndex = 3;
            this.webcam_img.TabStop = false;
            // 
            // capture_image
            // 
            this.capture_image.Location = new System.Drawing.Point(127, 12);
            this.capture_image.Name = "capture_image";
            this.capture_image.Size = new System.Drawing.Size(90, 23);
            this.capture_image.TabIndex = 4;
            this.capture_image.Text = "Capture image";
            this.capture_image.UseVisualStyleBackColor = true;
            this.capture_image.Click += new System.EventHandler(this.capture_image_Click);
            // 
            // start_analyse
            // 
            this.start_analyse.Location = new System.Drawing.Point(223, 12);
            this.start_analyse.Name = "start_analyse";
            this.start_analyse.Size = new System.Drawing.Size(85, 23);
            this.start_analyse.TabIndex = 5;
            this.start_analyse.Text = "Start analyse";
            this.start_analyse.UseVisualStyleBackColor = true;
            this.start_analyse.Click += new System.EventHandler(this.start_analyse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 301);
            this.Controls.Add(this.start_analyse);
            this.Controls.Add(this.capture_image);
            this.Controls.Add(this.webcam_img);
            this.Controls.Add(this.start_webcam);
            this.Controls.Add(this.webcam_stream);
            this.Controls.Add(this.WebCamView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WebCamView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcam_stream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcam_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox WebCamView;
        private System.Windows.Forms.PictureBox webcam_stream;
        private System.Windows.Forms.Button start_webcam;
        private System.Windows.Forms.PictureBox webcam_img;
        private System.Windows.Forms.Button capture_image;
        private System.Windows.Forms.Button start_analyse;
    }
}

