using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MarketUygulamasi
{
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESTROYERM\\SQLEXPRESS;Initial Catalog=DB_MARKET;Integrated Security=True");
        private void FrmUrunEkle_Load(object sender, EventArgs e)
        {

        }

        public void MarkalariGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select MARKAAD from TBLMARKA where KATEGORIID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", lblKategoriID.Text);

            SqlDataReader oku = komut.ExecuteReader();

            comboBoxMarka.Items.Clear();

            while (oku.Read())
            {
                comboBoxMarka.Items.Add(oku["MARKAAD"].ToString());
            }
            if (comboBoxMarka.Items.Count > 0)
            {
                comboBoxMarka.SelectedIndex = 0;
            }
            baglanti.Close();
        }
        private void btnBebek_Click(object sender, EventArgs e)
        {
            txtKategori.Text = "Bebek";
            lblKategoriID.Text = "1";
            MarkalariGetir();
        }

        private void btnSebzeMeyve_Click(object sender, EventArgs e)
        {
            txtKategori.Text = "Sebze-Meyve";
            lblKategoriID.Text = "2";
            MarkalariGetir();
        }

        private void btnUnluMamuller_Click(object sender, EventArgs e)
        {
            txtKategori.Text = "Unlu Mamüller";
            lblKategoriID.Text = "3";
            MarkalariGetir();
        }

        private void btnTemizlik_Click(object sender, EventArgs e)
        {
            txtKategori.Text = "Temizlik";
            lblKategoriID.Text = "4";
            MarkalariGetir();
        }

        private void btnIcecek_Click(object sender, EventArgs e)
        {
            txtKategori.Text = "İçecek";
            lblKategoriID.Text = "5";
            MarkalariGetir();
        }

        private void btnAtistirmalik_Click(object sender, EventArgs e)
        {
            txtKategori.Text = "Atıştırmalık";
            lblKategoriID.Text = "6";
            MarkalariGetir();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into TBLURUN (URUNAD,MARKAAD,KATEGORIID,URUNBARKOD,URUNSTOK,URUNFIYAT) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut2.Parameters.AddWithValue("@p1", txtAd.Text);
            komut2.Parameters.AddWithValue("@p2", comboBoxMarka.SelectedItem.ToString());
            komut2.Parameters.AddWithValue("@p3", lblKategoriID.Text);
            komut2.Parameters.AddWithValue("@p4", txtBarkod.Text);
            komut2.Parameters.AddWithValue("@p5", txtStok.Text);
            komut2.Parameters.AddWithValue("@p6", Convert.ToDecimal(txtFiyat.Text));

            komut2.ExecuteNonQuery();
            MessageBox.Show("Ürün veritabanına başarıyla kaydedildi.");
            baglanti.Close();

            txtAd.Text = "";
            comboBoxMarka.Text = "";
            txtKategori.Text="";
            txtBarkod.Text = "";
            txtStok.Text = "";
            txtFiyat.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUrunListesi fr = new FrmUrunListesi();
            fr.Show();
            this.Close();
        }
    }
}
