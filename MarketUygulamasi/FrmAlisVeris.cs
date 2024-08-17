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
            lblToplam.Text = (Convert.ToInt32(txtAdet.Text) * (Convert.ToDecimal(lblBirimFiyat.Text))).ToString();
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLURUN set URUNSTOK=@p1 where URUNBARKOD=@pbarkod",baglanti);
            komut.Parameters.AddWithValue("@pbarkod",txtBarkod.Text);
            komut.Parameters.AddWithValue("@p1", Convert.ToInt32(lblGuncelStok.Text) - Convert.ToInt32(txtAdet.Text));

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Stok bilgisi güncellendi");

        }
    }
}
