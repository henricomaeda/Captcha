namespace Captcha
{
    partial class FrmCaptcha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaptcha));
            this.lblTitle = new System.Windows.Forms.Label();
            this.picCookie = new System.Windows.Forms.PictureBox();
            this.picLeaves = new System.Windows.Forms.PictureBox();
            this.picRibbon = new System.Windows.Forms.PictureBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCookie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRibbon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(842, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Medida de segurança para autenticação";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCookie
            // 
            this.picCookie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picCookie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCookie.Image = global::Captcha.Properties.Resources.Cookies;
            this.picCookie.Location = new System.Drawing.Point(32, 106);
            this.picCookie.Name = "picCookie";
            this.picCookie.Size = new System.Drawing.Size(250, 250);
            this.picCookie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCookie.TabIndex = 1;
            this.picCookie.TabStop = false;
            this.picCookie.Click += new System.EventHandler(this.VerifyCaptcha);
            // 
            // picLeaves
            // 
            this.picLeaves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLeaves.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLeaves.Image = global::Captcha.Properties.Resources.Folhas;
            this.picLeaves.Location = new System.Drawing.Point(308, 106);
            this.picLeaves.Name = "picLeaves";
            this.picLeaves.Size = new System.Drawing.Size(250, 250);
            this.picLeaves.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLeaves.TabIndex = 2;
            this.picLeaves.TabStop = false;
            this.picLeaves.Click += new System.EventHandler(this.VerifyCaptcha);
            // 
            // picRibbon
            // 
            this.picRibbon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picRibbon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picRibbon.Image = global::Captcha.Properties.Resources.Laço;
            this.picRibbon.Location = new System.Drawing.Point(584, 106);
            this.picRibbon.Name = "picRibbon";
            this.picRibbon.Size = new System.Drawing.Size(250, 250);
            this.picRibbon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRibbon.TabIndex = 3;
            this.picRibbon.TabStop = false;
            this.picRibbon.Click += new System.EventHandler(this.VerifyCaptcha);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(12, 61);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(842, 23);
            this.lblSubtitle.TabIndex = 4;
            this.lblSubtitle.Text = "Precisamos verificar se você é um robô ou não.";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCaptcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 388);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.picRibbon);
            this.Controls.Add(this.picLeaves);
            this.Controls.Add(this.picCookie);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCaptcha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagem de captcha";
            this.Load += new System.EventHandler(this.FrmCaptcha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCookie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRibbon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picCookie;
        private System.Windows.Forms.PictureBox picLeaves;
        private System.Windows.Forms.PictureBox picRibbon;
        private System.Windows.Forms.Label lblSubtitle;
    }
}

