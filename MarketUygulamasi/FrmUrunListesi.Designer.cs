namespace MarketUygulamasi
{
    partial class FrmUrunListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunListesi));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            comboBoxMarka = new ComboBox();
            txtFiyat = new TextBox();
            txtStok = new TextBox();
            txtAd = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAra = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            txtAra = new TextBox();
            label7 = new Label();
            txtBarkod = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            label8 = new Label();
            btnAtistirmalik = new Button();
            btnTemizlik = new Button();
            btnBebek = new Button();
            btnIcecek = new Button();
            btnUnluMamuller = new Button();
            btnSebzeMeyve = new Button();
            lblKategoriID = new Label();
            comboBox1Kategori = new ComboBox();
            button1 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.Location = new Point(88, 115);
            listView1.Name = "listView1";
            listView1.Size = new Size(897, 221);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ürün AD";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "MARKA";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "KATEGORİ";
            columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "BARKOD";
            columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "ÜRÜN STOK";
            columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "FİYAT";
            columnHeader7.Width = 100;
            // 
            // comboBoxMarka
            // 
            comboBoxMarka.FormattingEnabled = true;
            comboBoxMarka.Location = new Point(189, 465);
            comboBoxMarka.Name = "comboBoxMarka";
            comboBoxMarka.Size = new Size(330, 40);
            comboBoxMarka.TabIndex = 22;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(189, 674);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(330, 39);
            txtFiyat.TabIndex = 21;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(189, 622);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(330, 39);
            txtStok.TabIndex = 20;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(189, 413);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(330, 39);
            txtAd.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 523);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 17;
            label4.Text = "Kategori : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 682);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 16;
            label5.Text = "Fiyat : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 629);
            label6.Name = "label6";
            label6.Size = new Size(136, 32);
            label6.TabIndex = 15;
            label6.Text = "Stok Adet : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 470);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 13;
            label2.Text = "Marka : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 417);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 12;
            label1.Text = "Ürün Ad : ";
            // 
            // btnAra
            // 
            btnAra.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAra.Location = new Point(637, 729);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(96, 39);
            btnAra.TabIndex = 24;
            btnAra.Text = "Ürün Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(755, 729);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(96, 39);
            btnGuncelle.TabIndex = 25;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.Location = new Point(873, 729);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(96, 39);
            btnSil.TabIndex = 26;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(189, 729);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(330, 39);
            txtAra.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 736);
            label7.Name = "label7";
            label7.Size = new Size(127, 32);
            label7.TabIndex = 28;
            label7.Text = "Ürün Ara : ";
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(189, 570);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(330, 39);
            txtBarkod.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 576);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 30;
            label3.Text = "Barkod : ";
            // 
            // txtID
            // 
            txtID.Location = new Point(189, 361);
            txtID.Name = "txtID";
            txtID.Size = new Size(330, 39);
            txtID.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 364);
            label8.Name = "label8";
            label8.Size = new Size(115, 32);
            label8.TabIndex = 32;
            label8.Text = "Ürün ID : ";
            // 
            // btnAtistirmalik
            // 
            btnAtistirmalik.BackgroundImage = (Image)resources.GetObject("btnAtistirmalik.BackgroundImage");
            btnAtistirmalik.BackgroundImageLayout = ImageLayout.Stretch;
            btnAtistirmalik.Location = new Point(837, 609);
            btnAtistirmalik.Name = "btnAtistirmalik";
            btnAtistirmalik.Size = new Size(132, 105);
            btnAtistirmalik.TabIndex = 39;
            btnAtistirmalik.UseVisualStyleBackColor = false;
            btnAtistirmalik.Click += btnAtistirmalik_Click;
            // 
            // btnTemizlik
            // 
            btnTemizlik.BackgroundImage = (Image)resources.GetObject("btnTemizlik.BackgroundImage");
            btnTemizlik.BackgroundImageLayout = ImageLayout.Stretch;
            btnTemizlik.Location = new Point(837, 487);
            btnTemizlik.Name = "btnTemizlik";
            btnTemizlik.Size = new Size(132, 105);
            btnTemizlik.TabIndex = 38;
            btnTemizlik.UseVisualStyleBackColor = false;
            btnTemizlik.Click += btnTemizlik_Click;
            // 
            // btnBebek
            // 
            btnBebek.BackgroundImage = (Image)resources.GetObject("btnBebek.BackgroundImage");
            btnBebek.BackgroundImageLayout = ImageLayout.Stretch;
            btnBebek.Location = new Point(637, 364);
            btnBebek.Name = "btnBebek";
            btnBebek.Size = new Size(132, 105);
            btnBebek.TabIndex = 37;
            btnBebek.UseVisualStyleBackColor = false;
            btnBebek.Click += btnBebek_Click;
            // 
            // btnIcecek
            // 
            btnIcecek.BackgroundImage = (Image)resources.GetObject("btnIcecek.BackgroundImage");
            btnIcecek.BackgroundImageLayout = ImageLayout.Stretch;
            btnIcecek.Location = new Point(637, 608);
            btnIcecek.Name = "btnIcecek";
            btnIcecek.Size = new Size(132, 105);
            btnIcecek.TabIndex = 36;
            btnIcecek.UseVisualStyleBackColor = false;
            btnIcecek.Click += btnIcecek_Click;
            // 
            // btnUnluMamuller
            // 
            btnUnluMamuller.BackgroundImage = (Image)resources.GetObject("btnUnluMamuller.BackgroundImage");
            btnUnluMamuller.BackgroundImageLayout = ImageLayout.Stretch;
            btnUnluMamuller.Location = new Point(637, 485);
            btnUnluMamuller.Name = "btnUnluMamuller";
            btnUnluMamuller.Size = new Size(132, 105);
            btnUnluMamuller.TabIndex = 35;
            btnUnluMamuller.UseVisualStyleBackColor = true;
            btnUnluMamuller.Click += btnUnluMamuller_Click;
            // 
            // btnSebzeMeyve
            // 
            btnSebzeMeyve.BackgroundImage = (Image)resources.GetObject("btnSebzeMeyve.BackgroundImage");
            btnSebzeMeyve.BackgroundImageLayout = ImageLayout.Stretch;
            btnSebzeMeyve.Location = new Point(837, 364);
            btnSebzeMeyve.Name = "btnSebzeMeyve";
            btnSebzeMeyve.Size = new Size(132, 105);
            btnSebzeMeyve.TabIndex = 34;
            btnSebzeMeyve.UseVisualStyleBackColor = true;
            btnSebzeMeyve.Click += btnSebzeMeyve_Click;
            // 
            // lblKategoriID
            // 
            lblKategoriID.AutoSize = true;
            lblKategoriID.Location = new Point(820, 771);
            lblKategoriID.Name = "lblKategoriID";
            lblKategoriID.Size = new Size(149, 32);
            lblKategoriID.TabIndex = 40;
            lblKategoriID.Text = "lblKategoriId";
            // 
            // comboBox1Kategori
            // 
            comboBox1Kategori.FormattingEnabled = true;
            comboBox1Kategori.Location = new Point(189, 520);
            comboBox1Kategori.Name = "comboBox1Kategori";
            comboBox1Kategori.Size = new Size(330, 40);
            comboBox1Kategori.TabIndex = 41;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(103, 42);
            button1.Name = "button1";
            button1.Size = new Size(866, 47);
            button1.TabIndex = 42;
            button1.Text = "Yeni Ürün Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(975, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 47);
            panel1.TabIndex = 43;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(54, 3);
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
            // FrmUrunListesi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1081, 812);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(comboBox1Kategori);
            Controls.Add(lblKategoriID);
            Controls.Add(btnAtistirmalik);
            Controls.Add(btnTemizlik);
            Controls.Add(btnBebek);
            Controls.Add(btnIcecek);
            Controls.Add(btnUnluMamuller);
            Controls.Add(btnSebzeMeyve);
            Controls.Add(txtID);
            Controls.Add(label8);
            Controls.Add(txtBarkod);
            Controls.Add(label3);
            Controls.Add(txtAra);
            Controls.Add(label7);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnAra);
            Controls.Add(comboBoxMarka);
            Controls.Add(txtFiyat);
            Controls.Add(txtStok);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUrunListesi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUrunListesi";
            Load += FrmUrunListesi_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ComboBox comboBoxMarka;
        private TextBox txtFiyat;
        private TextBox txtStok;
        private TextBox txtAd;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label1;
        private Button btnAra;
        private Button btnGuncelle;
        private Button btnSil;
        private TextBox txtAra;
        private Label label7;
        private TextBox txtBarkod;
        private Label label3;
        private TextBox txtID;
        private Label label8;
        private Button btnAtistirmalik;
        private Button btnTemizlik;
        private Button btnBebek;
        private Button btnIcecek;
        private Button btnUnluMamuller;
        private Button btnSebzeMeyve;
        private Label lblKategoriID;
        private ComboBox comboBox1Kategori;
        private Button button1;
        private Panel panel1;
        private Button button3;
        private Button button2;
    }
}