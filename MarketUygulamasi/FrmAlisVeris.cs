using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;



namespace MarketUygulamasi
{
    public partial class FrmAlisVeris : Form
    {

        private List<Product> sepet = new List<Product>();

        public FrmAlisVeris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESTROYERM\\SQLEXPRESS;Initial Catalog=DB_MARKET;Integrated Security=True");

        public void BilgileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT TBLURUN.URUNAD, TBLURUN.MARKAAD, TBLKATEGORI.KATEGORIAD, TBLURUN.URUNSTOK, TBLURUN.URUNFIYAT FROM TBLURUN JOIN TBLKATEGORI ON TBLURUN.KATEGORIID = TBLKATEGORI.KATEGORIID where URUNBARKOD=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtBarkod.Text);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read()) // İlk kaydı okumak için
            {
                lblAd.Text = oku["URUNAD"].ToString();
                lblKategori.Text = oku["KATEGORIAD"].ToString();
                lblMarka.Text = oku["MARKAAD"].ToString();
                lblGuncelStok.Text = oku["URUNSTOK"].ToString();
                lblBirimFiyat.Text = oku["URUNFIYAT"].ToString();
            }

            baglanti.Close();
        }

        private void FrmAlisVeris_Load(object sender, EventArgs e)
        {

        }


        private void txtBarkod_Leave(object sender, EventArgs e)
        {
            BilgileriGoster();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            lblToplam.Text = (Convert.ToInt32(txtAdet.Text) *Convert.ToDecimal(lblBirimFiyat.Text)).ToString();
            lblToplam.Visible = true;
        }

        public void Temizle()
        {
            txtBarkod.Clear();
            lstSepet.Items.Clear();
            txtAdet.Clear();
            lblAd.Text = "";
            lblBirimFiyat.Text = "";
            lblKategori.Text = "";
            lblMarka.Text = "";
            lblToplam.Visible=false;
            lblGuncelStok.Text = "";
            lblBirimFiyat.Text = "";

        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            // Her ürün için stok güncelleme işlemi yapıyoruz.
            foreach (var urun in sepet)
            {
                // Mevcut stok bilgisini alıyoruz.
                SqlCommand komut = new SqlCommand("SELECT URUNSTOK FROM TBLURUN WHERE URUNAD = @p1", baglanti);
                komut.Parameters.AddWithValue("@p1", urun.UrunAd);

                object result = komut.ExecuteScalar();
                int mevcutStok = Convert.ToInt32(result);

                // Stok güncelleme sorgusunu oluşturuyoruz.
                SqlCommand guncelleKomut = new SqlCommand("UPDATE TBLURUN SET URUNSTOK = @p1 WHERE URUNAD = @p2", baglanti);
                guncelleKomut.Parameters.AddWithValue("@p1", mevcutStok - urun.Adet);
                guncelleKomut.Parameters.AddWithValue("@p2", urun.UrunAd);

                guncelleKomut.ExecuteNonQuery();
                baglanti.Close();
                
            }

            // Sepeti sıfırlıyoruz.
            sepet.Clear();
            lstSepet.Visible=false;
            MessageBox.Show("Ödeme işlemi gerçekleştirildi ve sepet sıfırlandı.");
            Temizle();

        }

        private void txtBarkod_DragEnter(object sender, DragEventArgs e)
        {
            BilgileriGoster();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BilgileriGoster();
                // Olayın daha fazla işlenmesini engellemek için
                e.SuppressKeyPress = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GüncelleSepetGoruntuleme()
        {
            lstSepet.Items.Clear(); // Mevcut öğeleri temizleyin

            foreach (var urun in sepet)
            {
                // Ürün adı ve adedi birleştirilmiş olarak listeye eklenir
                lstSepet.Items.Add($"{urun.UrunAd} - Adet: {urun.Adet}");
            }
        }


        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            string urunAd = lblAd.Text;
            int adet;

            if (int.TryParse(txtAdet.Text, out adet) && !string.IsNullOrEmpty(urunAd))
            {
                sepet.Add(new Product { UrunAd = urunAd, Adet = adet });
                MessageBox.Show("Ürün sepete eklendi.");
                GüncelleSepetGoruntuleme(); // Sepet görünümünü güncelle
            }
            else
            {
                MessageBox.Show("Geçerli bir adet ve ürün adı giriniz.");
            }
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            GüncelleSepetGoruntuleme();
        }
    }
}
