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
    public partial class FrmKullaniciKayitPaneli : Form
    {
        public FrmKullaniciKayitPaneli()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESTROYERM\\SQLEXPRESS;Initial Catalog=DB_MARKET;Integrated Security=True");


        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into TBLKULLANICI(KULLANICIAD,MAIL,SIFRE) values (@p1,@p2,@p3) ",baglanti);
            komut.Parameters.AddWithValue("@p1",txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2",txtMail.Text);
            komut.Parameters.AddWithValue("@p3",txtSifre.Text);

            komut.ExecuteNonQuery();
                
            baglanti.Close();
            MessageBox.Show("Kayıt yapıldı . Lütfen giriş yapınız");
            FrmGirisPaneli fr=new FrmGirisPaneli();
            fr.Show();
            this.Close();
        }
    }
}
