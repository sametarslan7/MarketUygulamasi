namespace MarketUygulamasi
{
    partial class FrmAlisVeris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlisVeris));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtBarkod = new TextBox();
            groupBox1 = new GroupBox();
            lblGuncelStok = new Label();
            lblBirimFiyat = new Label();
            lblMarka = new Label();
            lblKategori = new Label();
            lblAd = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            txtAdet = new TextBox();
            lblToplam = new Label();
            btnHesapla = new Button();
            btnOde = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1005, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1048, 220);
            label1.Name = "label1";
            label1.Size = new Size(123, 27);
            label1.TabIndex = 7;
            label1.Text = "winMarket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 74);
            label2.Name = "label2";
            label2.Size = new Size(274, 32);
            label2.TabIndex = 8;
            label2.Text = "Ürün Barkod Numarası : ";
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(349, 67);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(185, 39);
            txtBarkod.TabIndex = 0;
            txtBarkod.Leave += txtBarkod_Leave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblGuncelStok);
            groupBox1.Controls.Add(lblBirimFiyat);
            groupBox1.Controls.Add(lblMarka);
            groupBox1.Controls.Add(lblKategori);
            groupBox1.Controls.Add(lblAd);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(35, 292);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 345);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Bilgileri";
            // 
            // lblGuncelStok
            // 
            lblGuncelStok.AutoSize = true;
            lblGuncelStok.Location = new Point(193, 221);
            lblGuncelStok.Name = "lblGuncelStok";
            lblGuncelStok.Size = new Size(155, 32);
            lblGuncelStok.TabIndex = 9;
            lblGuncelStok.Text = "Güncel Stok  ";
            // 
            // lblBirimFiyat
            // 
            lblBirimFiyat.AutoSize = true;
            lblBirimFiyat.Location = new Point(193, 273);
            lblBirimFiyat.Name = "lblBirimFiyat";
            lblBirimFiyat.Size = new Size(133, 32);
            lblBirimFiyat.TabIndex = 8;
            lblBirimFiyat.Text = "Birim Fiyat ";
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(193, 165);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(94, 32);
            lblMarka.TabIndex = 7;
            lblMarka.Text = "Marka  ";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(193, 108);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(110, 32);
            lblKategori.TabIndex = 6;
            lblKategori.Text = "Kategori ";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(193, 58);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(50, 32);
            lblAd.TabIndex = 5;
            lblAd.Text = "Ad ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 221);
            label6.Name = "label6";
            label6.Size = new Size(167, 32);
            label6.TabIndex = 4;
            label6.Text = "Güncel Stok  : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 273);
            label5.Name = "label5";
            label5.Size = new Size(145, 32);
            label5.TabIndex = 3;
            label5.Text = "Birim Fiyat : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 165);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 2;
            label4.Text = "Marka  : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 108);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 1;
            label3.Text = "Kategori : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 58);
            label8.Name = "label8";
            label8.Size = new Size(62, 32);
            label8.TabIndex = 0;
            label8.Text = "Ad : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 216);
            label7.Name = "label7";
            label7.Size = new Size(173, 32);
            label7.TabIndex = 11;
            label7.Text = "Toplam Tutar : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 152);
            label9.Name = "label9";
            label9.Size = new Size(83, 32);
            label9.TabIndex = 12;
            label9.Text = "Adet : ";
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(146, 145);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(146, 39);
            txtAdet.TabIndex = 1;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(244, 216);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(161, 32);
            lblToplam.TabIndex = 14;
            lblToplam.Text = "Toplam Tutar ";
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(414, 145);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(109, 42);
            btnHesapla.TabIndex = 15;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // btnOde
            // 
            btnOde.Location = new Point(432, 598);
            btnOde.Name = "btnOde";
            btnOde.Size = new Size(215, 39);
            btnOde.TabIndex = 16;
            btnOde.Text = "Öde";
            btnOde.UseVisualStyleBackColor = true;
            btnOde.Click += btnOde_Click;
            // 
            // FrmAlisVeris
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1238, 738);
            Controls.Add(btnOde);
            Controls.Add(btnHesapla);
            Controls.Add(lblToplam);
            Controls.Add(txtAdet);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(txtBarkod);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "FrmAlisVeris";
            Text = "FrmAlisVeris";
            Load += FrmAlisVeris_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtBarkod;
        private GroupBox groupBox1;
        private Label label3;
        private Label label8;
        private Label lblGuncelStok;
        private Label lblBirimFiyat;
        private Label lblMarka;
        private Label lblKategori;
        private Label lblAd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label9;
        private TextBox txtAdet;
        private Label lblToplam;
        private Button btnHesapla;
        private Button btnOde;
    }
}