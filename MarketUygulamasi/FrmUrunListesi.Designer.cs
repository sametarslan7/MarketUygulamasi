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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            txtKategori = new TextBox();
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
            button4 = new Button();
            txtAra = new TextBox();
            label7 = new Label();
            txtBarkod = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.Location = new Point(86, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(897, 339);
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
            // txtKategori
            // 
            txtKategori.Enabled = false;
            txtKategori.Location = new Point(185, 523);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(330, 39);
            txtKategori.TabIndex = 23;
            // 
            // comboBoxMarka
            // 
            comboBoxMarka.Enabled = false;
            comboBoxMarka.FormattingEnabled = true;
            comboBoxMarka.Location = new Point(185, 470);
            comboBoxMarka.Name = "comboBoxMarka";
            comboBoxMarka.Size = new Size(330, 40);
            comboBoxMarka.TabIndex = 22;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(185, 679);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(330, 39);
            txtFiyat.TabIndex = 21;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(185, 627);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(330, 39);
            txtStok.TabIndex = 20;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(185, 418);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(330, 39);
            txtAd.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 528);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 17;
            label4.Text = "Kategori : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 687);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 16;
            label5.Text = "Fiyat : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 634);
            label6.Name = "label6";
            label6.Size = new Size(136, 32);
            label6.TabIndex = 15;
            label6.Text = "Stok Adet : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 475);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 13;
            label2.Text = "Marka : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 422);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 12;
            label1.Text = "Ürün Ad : ";
            // 
            // btnAra
            // 
            btnAra.Location = new Point(785, 444);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(173, 40);
            btnAra.TabIndex = 24;
            btnAra.Text = "Ürün Ara";
            btnAra.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(785, 512);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(173, 40);
            btnGuncelle.TabIndex = 25;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(785, 582);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(173, 40);
            btnSil.TabIndex = 26;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(785, 647);
            button4.Name = "button4";
            button4.Size = new Size(173, 40);
            button4.TabIndex = 27;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(718, 366);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(330, 39);
            txtAra.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(585, 369);
            label7.Name = "label7";
            label7.Size = new Size(127, 32);
            label7.TabIndex = 28;
            label7.Text = "Ürün Ara : ";
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(185, 575);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(330, 39);
            txtBarkod.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 581);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 30;
            label3.Text = "Barkod : ";
            // 
            // txtID
            // 
            txtID.Location = new Point(185, 366);
            txtID.Name = "txtID";
            txtID.Size = new Size(330, 39);
            txtID.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 369);
            label8.Name = "label8";
            label8.Size = new Size(115, 32);
            label8.TabIndex = 32;
            label8.Text = "Ürün ID : ";
            // 
            // FrmUrunListesi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1071, 752);
            Controls.Add(txtID);
            Controls.Add(label8);
            Controls.Add(txtBarkod);
            Controls.Add(label3);
            Controls.Add(txtAra);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnAra);
            Controls.Add(txtKategori);
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
            Name = "FrmUrunListesi";
            Text = "FrmUrunListesi";
            Load += FrmUrunListesi_Load;
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
        private TextBox txtKategori;
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
        private Button button4;
        private TextBox txtAra;
        private Label label7;
        private TextBox txtBarkod;
        private Label label3;
        private TextBox txtID;
        private Label label8;
    }
}