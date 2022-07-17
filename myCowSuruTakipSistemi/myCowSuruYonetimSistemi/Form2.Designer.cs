
namespace myCowSuruYonetimSistemi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.mailGonder = new System.Windows.Forms.Button();
            this.mailAdresi = new System.Windows.Forms.Label();
            this.mainPage = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMail.Location = new System.Drawing.Point(327, 261);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(415, 45);
            this.textBoxMail.TabIndex = 0;
            // 
            // mailGonder
            // 
            this.mailGonder.BackColor = System.Drawing.Color.Transparent;
            this.mailGonder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mailGonder.BackgroundImage")));
            this.mailGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mailGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mailGonder.Font = new System.Drawing.Font("Pristina", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailGonder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mailGonder.Location = new System.Drawing.Point(747, 245);
            this.mailGonder.Name = "mailGonder";
            this.mailGonder.Size = new System.Drawing.Size(179, 83);
            this.mailGonder.TabIndex = 1;
            this.mailGonder.Text = "Gönder";
            this.mailGonder.UseVisualStyleBackColor = false;
            this.mailGonder.Click += new System.EventHandler(this.button1_Click);
            // 
            // mailAdresi
            // 
            this.mailAdresi.AutoSize = true;
            this.mailAdresi.BackColor = System.Drawing.Color.Transparent;
            this.mailAdresi.Font = new System.Drawing.Font("Pristina", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailAdresi.ForeColor = System.Drawing.Color.Crimson;
            this.mailAdresi.Location = new System.Drawing.Point(18, 264);
            this.mailAdresi.Name = "mailAdresi";
            this.mailAdresi.Size = new System.Drawing.Size(300, 44);
            this.mailAdresi.TabIndex = 2;
            this.mailAdresi.Text = "Mail Adresinizi Giriniz:";
            // 
            // mainPage
            // 
            this.mainPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPage.BackgroundImage")));
            this.mainPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainPage.Location = new System.Drawing.Point(857, 458);
            this.mainPage.Name = "mainPage";
            this.mainPage.Size = new System.Drawing.Size(91, 77);
            this.mainPage.TabIndex = 3;
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(908, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 41);
            this.exitButton.TabIndex = 4;
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(349, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 539);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mainPage);
            this.Controls.Add(this.mailAdresi);
            this.Controls.Add(this.mailGonder);
            this.Controls.Add(this.textBoxMail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Button mailGonder;
        private System.Windows.Forms.Label mailAdresi;
        private System.Windows.Forms.Button mainPage;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}