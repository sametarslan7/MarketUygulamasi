namespace MarketUygulamasi
{
    partial class FrmMarkalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarkalar));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMarkaID = new TextBox();
            txtMarkaAd = new TextBox();
            comboBoxKategori = new ComboBox();
            btnGuncelle = new Button();
            btnEkle = new Button();
            btnSil = new Button();
            txtAra = new TextBox();
            label4 = new Label();
            btnAra = new Button();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(59, 63);
            listView1.Name = "listView1";
            listView1.Size = new Size(362, 438);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "MARKA";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "KATEGORİ";
            columnHeader3.Width = 140;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(595, 260);
            label1.Name = "label1";
            label1.Size = new Size(56, 32);
            label1.TabIndex = 1;
            label1.Text = "ID : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(595, 320);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 2;
            label2.Text = "Marka : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(595, 382);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 3;
            label3.Text = "Kategori : ";
            // 
            // txtMarkaID
            // 
            txtMarkaID.Enabled = false;
            txtMarkaID.Location = new Point(726, 257);
            txtMarkaID.Name = "txtMarkaID";
            txtMarkaID.Size = new Size(215, 39);
            txtMarkaID.TabIndex = 4;
            // 
            // txtMarkaAd
            // 
            txtMarkaAd.Location = new Point(726, 317);
            txtMarkaAd.Name = "txtMarkaAd";
            txtMarkaAd.Size = new Size(215, 39);
            txtMarkaAd.TabIndex = 5;
            // 
            // comboBoxKategori
            // 
            comboBoxKategori.FormattingEnabled = true;
            comboBoxKategori.Location = new Point(726, 379);
            comboBoxKategori.Name = "comboBoxKategori";
            comboBoxKategori.Size = new Size(215, 40);
            comboBoxKategori.TabIndex = 6;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(726, 461);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(148, 42);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEkle.Location = new Point(546, 461);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(148, 42);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(901, 461);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(148, 42);
            btnSil.TabIndex = 9;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(726, 60);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(215, 39);
            txtAra.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(595, 63);
            label4.Name = "label4";
            label4.Size = new Size(142, 32);
            label4.TabIndex = 10;
            label4.Text = "Marka Ad  : ";
            // 
            // btnAra
            // 
            btnAra.Location = new Point(793, 124);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(148, 42);
            btnAra.TabIndex = 12;
            btnAra.Text = "Marka Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(1071, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 47);
            panel1.TabIndex = 44;
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
            // FrmMarkalar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1205, 762);
            Controls.Add(panel1);
            Controls.Add(btnAra);
            Controls.Add(txtAra);
            Controls.Add(label4);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(comboBoxKategori);
            Controls.Add(txtMarkaAd);
            Controls.Add(txtMarkaID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMarkalar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMarkalar";
            Load += FrmMarkalar_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMarkaID;
        private TextBox txtMarkaAd;
        private ComboBox comboBoxKategori;
        private Button btnGuncelle;
        private Button btnEkle;
        private Button btnSil;
        private TextBox txtAra;
        private Label label4;
        private Button btnAra;
        private Panel panel1;
        private Button button3;
        private Button button2;
    }
}