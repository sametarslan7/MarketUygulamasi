namespace MarketUygulamasi
{
    partial class FrmUrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunEkle));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAd = new TextBox();
            txtBarkod = new TextBox();
            txtStok = new TextBox();
            txtFiyat = new TextBox();
            comboBoxMarka = new ComboBox();
            txtKategori = new TextBox();
            btnUrunEkle = new Button();
            btnSebzeMeyve = new Button();
            btnUnluMamuller = new Button();
            btnIcecek = new Button();
            btnAtistirmalik = new Button();
            btnTemizlik = new Button();
            btnBebek = new Button();
            lblKategoriID = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(35, 111);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 0;
            label1.Text = "Ürün Ad : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(35, 174);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 1;
            label2.Text = "Marka : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(35, 237);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 2;
            label3.Text = "Barkod : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(35, 300);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 5;
            label4.Text = "Kategori : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(35, 426);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 4;
            label5.Text = "Fiyat : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(35, 363);
            label6.Name = "label6";
            label6.Size = new Size(136, 32);
            label6.TabIndex = 3;
            label6.Text = "Stok Adet : ";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(188, 108);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(330, 39);
            txtAd.TabIndex = 6;
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(188, 234);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(330, 39);
            txtBarkod.TabIndex = 7;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(188, 360);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(330, 39);
            txtStok.TabIndex = 8;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(188, 419);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(330, 39);
            txtFiyat.TabIndex = 9;
            // 
            // comboBoxMarka
            // 
            comboBoxMarka.FormattingEnabled = true;
            comboBoxMarka.Location = new Point(188, 171);
            comboBoxMarka.Name = "comboBoxMarka";
            comboBoxMarka.Size = new Size(330, 40);
            comboBoxMarka.TabIndex = 10;
            // 
            // txtKategori
            // 
            txtKategori.Enabled = false;
            txtKategori.Location = new Point(188, 300);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(330, 39);
            txtKategori.TabIndex = 11;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(188, 504);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(175, 40);
            btnUrunEkle.TabIndex = 12;
            btnUrunEkle.Text = "Ürün Ekle ";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // btnSebzeMeyve
            // 
            btnSebzeMeyve.BackgroundImage = (Image)resources.GetObject("btnSebzeMeyve.BackgroundImage");
            btnSebzeMeyve.BackgroundImageLayout = ImageLayout.Stretch;
            btnSebzeMeyve.Location = new Point(846, 108);
            btnSebzeMeyve.Name = "btnSebzeMeyve";
            btnSebzeMeyve.Size = new Size(165, 133);
            btnSebzeMeyve.TabIndex = 13;
            btnSebzeMeyve.UseVisualStyleBackColor = true;
            btnSebzeMeyve.Click += btnSebzeMeyve_Click;
            // 
            // btnUnluMamuller
            // 
            btnUnluMamuller.BackgroundImage = (Image)resources.GetObject("btnUnluMamuller.BackgroundImage");
            btnUnluMamuller.BackgroundImageLayout = ImageLayout.Stretch;
            btnUnluMamuller.Location = new Point(624, 259);
            btnUnluMamuller.Name = "btnUnluMamuller";
            btnUnluMamuller.Size = new Size(165, 133);
            btnUnluMamuller.TabIndex = 14;
            btnUnluMamuller.UseVisualStyleBackColor = true;
            btnUnluMamuller.Click += btnUnluMamuller_Click;
            // 
            // btnIcecek
            // 
            btnIcecek.BackgroundImage = (Image)resources.GetObject("btnIcecek.BackgroundImage");
            btnIcecek.BackgroundImageLayout = ImageLayout.Stretch;
            btnIcecek.Location = new Point(624, 407);
            btnIcecek.Name = "btnIcecek";
            btnIcecek.Size = new Size(165, 133);
            btnIcecek.TabIndex = 15;
            btnIcecek.UseVisualStyleBackColor = false;
            btnIcecek.Click += btnIcecek_Click;
            // 
            // btnAtistirmalik
            // 
            btnAtistirmalik.BackgroundImage = (Image)resources.GetObject("btnAtistirmalik.BackgroundImage");
            btnAtistirmalik.BackgroundImageLayout = ImageLayout.Stretch;
            btnAtistirmalik.Location = new Point(846, 407);
            btnAtistirmalik.Name = "btnAtistirmalik";
            btnAtistirmalik.Size = new Size(165, 133);
            btnAtistirmalik.TabIndex = 18;
            btnAtistirmalik.UseVisualStyleBackColor = false;
            btnAtistirmalik.Click += btnAtistirmalik_Click;
            // 
            // btnTemizlik
            // 
            btnTemizlik.BackgroundImage = (Image)resources.GetObject("btnTemizlik.BackgroundImage");
            btnTemizlik.BackgroundImageLayout = ImageLayout.Stretch;
            btnTemizlik.Location = new Point(846, 259);
            btnTemizlik.Name = "btnTemizlik";
            btnTemizlik.Size = new Size(165, 133);
            btnTemizlik.TabIndex = 17;
            btnTemizlik.UseVisualStyleBackColor = false;
            btnTemizlik.Click += btnTemizlik_Click;
            // 
            // btnBebek
            // 
            btnBebek.BackgroundImage = (Image)resources.GetObject("btnBebek.BackgroundImage");
            btnBebek.BackgroundImageLayout = ImageLayout.Stretch;
            btnBebek.Location = new Point(624, 108);
            btnBebek.Name = "btnBebek";
            btnBebek.Size = new Size(165, 133);
            btnBebek.TabIndex = 16;
            btnBebek.UseVisualStyleBackColor = false;
            btnBebek.Click += btnBebek_Click;
            // 
            // lblKategoriID
            // 
            lblKategoriID.AutoSize = true;
            lblKategoriID.BackColor = Color.Transparent;
            lblKategoriID.ForeColor = SystemColors.Control;
            lblKategoriID.Location = new Point(852, 582);
            lblKategoriID.Name = "lblKategoriID";
            lblKategoriID.Size = new Size(149, 32);
            lblKategoriID.TabIndex = 19;
            lblKategoriID.Text = "lblKategoriId";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(870, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 47);
            panel1.TabIndex = 44;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(50, 3);
            button1.Name = "button1";
            button1.Size = new Size(46, 41);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(98, 3);
            button3.Name = "button3";
            button3.Size = new Size(46, 41);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(45, 41);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(85, 45);
            label7.Name = "label7";
            label7.Size = new Size(152, 32);
            label7.TabIndex = 45;
            label7.Text = "Ürün Bilgileri";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(570, 45);
            label8.Name = "label8";
            label8.Size = new Size(130, 32);
            label8.TabIndex = 46;
            label8.Text = "Kategoriler";
            // 
            // FrmUrunEkle
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1071, 752);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(lblKategoriID);
            Controls.Add(btnAtistirmalik);
            Controls.Add(btnTemizlik);
            Controls.Add(btnBebek);
            Controls.Add(btnIcecek);
            Controls.Add(btnUnluMamuller);
            Controls.Add(btnSebzeMeyve);
            Controls.Add(btnUrunEkle);
            Controls.Add(txtKategori);
            Controls.Add(comboBoxMarka);
            Controls.Add(txtFiyat);
            Controls.Add(txtStok);
            Controls.Add(txtBarkod);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUrunEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekle";
            Load += FrmUrunEkle_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAd;
        private TextBox txtBarkod;
        private TextBox txtStok;
        private TextBox txtFiyat;
        private ComboBox comboBoxMarka;
        private TextBox txtKategori;
        private Button btnUrunEkle;
        private Button btnSebzeMeyve;
        private Button btnUnluMamuller;
        private Button btnIcecek;
        private Button btnAtistirmalik;
        private Button btnTemizlik;
        private Button btnBebek;
        private Label lblKategoriID;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Label label7;
        private Label label8;
        private Button button1;
    }
}