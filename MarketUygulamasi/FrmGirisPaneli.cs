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
    public partial class FrmGirisPaneli : Form
    {
        public FrmGirisPaneli()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESTROYERM\\SQLEXPRESS;Initial Catalog=DB_MARKET;Integrated Security=True");

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from TBLKULLANICI where KULLANICIAD=@p1 AND SIFRE = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);

            int userCount = Convert.ToInt32(komut.ExecuteScalar());

            if (userCount >0)
            {
                MessageBox.Show("Giriş başarılı!");
                FrmAnaSayfa fr = new FrmAnaSayfa();
                this.Hide();
                fr.Show();

            }
            else
            {
                MessageBox.Show("Giriş başarısız , lütfen tekrar deneyiniz");
            }

            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKullaniciKayitPaneli fr=new FrmKullaniciKayitPaneli();
            fr.Show();
            this.Hide();
        }
    }
}
