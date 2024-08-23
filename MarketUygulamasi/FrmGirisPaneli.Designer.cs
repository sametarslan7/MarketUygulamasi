namespace MarketUygulamasi
{
    partial class FrmGirisPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisPaneli));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtKullaniciAd = new TextBox();
            txtSifre = new TextBox();
            btnGirisYap = new Button();
            button1 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(325, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(325, 183);
            label1.Name = "label1";
            label1.Size = new Size(227, 23);
            label1.TabIndex = 1;
            label1.Text = "winMarket Giriş Paneli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(265, 251);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı Adı : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(265, 310);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 3;
            label3.Text = "Şifre : ";
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Location = new Point(443, 248);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(189, 35);
            txtKullaniciAd.TabIndex = 4;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(443, 305);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(189, 35);
            txtSifre.TabIndex = 5;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = SystemColors.Info;
            btnGirisYap.Location = new Point(443, 379);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(154, 36);
            btnGirisYap.TabIndex = 6;
            btnGirisYap.Text = "Giriş Yap ";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(558, 432);
            button1.Name = "button1";
            button1.Size = new Size(74, 36);
            button1.TabIndex = 7;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poor Richard", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(413, 442);
            label4.Name = "label4";
            label4.Size = new Size(130, 19);
            label4.TabIndex = 8;
            label4.Text = "Hesabınız yok Mu ? ";
            // 
            // FrmGirisPaneli
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(856, 492);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmGirisPaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Paneli";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKullaniciAd;
        private TextBox txtSifre;
        private Button btnGirisYap;
        private Button button1;
        private Label label4;
    }
}