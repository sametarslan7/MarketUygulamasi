namespace MarketUygulamasi
{
    partial class FrmKullaniciKayitPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciKayitPaneli));
            btnGirisYap = new Button();
            txtSifre = new TextBox();
            txtKullaniciAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtMail = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = SystemColors.Info;
            btnGirisYap.Location = new Point(429, 415);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(154, 36);
            btnGirisYap.TabIndex = 13;
            btnGirisYap.Text = "Kayıt Ol";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(429, 350);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(189, 35);
            txtSifre.TabIndex = 12;
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Location = new Point(429, 248);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(189, 35);
            txtKullaniciAd.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(251, 355);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 10;
            label3.Text = "Şifre : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(251, 251);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 9;
            label2.Text = "Kullanıcı Adı : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(311, 183);
            label1.Name = "label1";
            label1.Size = new Size(227, 23);
            label1.TabIndex = 8;
            label1.Text = "winMarket Giriş Paneli";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(311, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(429, 298);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(189, 35);
            txtMail.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(251, 301);
            label4.Name = "label4";
            label4.Size = new Size(70, 30);
            label4.TabIndex = 14;
            label4.Text = "Mail : ";
            // 
            // FrmKullaniciKayitPaneli
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(856, 492);
            Controls.Add(txtMail);
            Controls.Add(label4);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmKullaniciKayitPaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Kayıt Paneli";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGirisYap;
        private TextBox txtSifre;
        private TextBox txtKullaniciAd;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtMail;
        private Label label4;
    }
}