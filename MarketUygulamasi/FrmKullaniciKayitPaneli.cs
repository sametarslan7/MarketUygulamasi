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
            try
            {
                baglanti.Open();

                SqlCommand komut_1 = new SqlCommand("select * from TBLKULLANICI where MAIL=@mail", baglanti);
                komut_1.Parameters.AddWithValue("@mail", txtMail.Text);
                SqlDataReader oku = komut_1.ExecuteReader();

                if (oku.Read())
                {
                    MessageBox.Show("Bu mail ile oluşturulmuş bir kayıt zaten var , farklı bir mail ile deneyin.");
                    txtMail.Text = "";
                    txtSifre.Text = "";
                    return;
                }
                oku.Close();

                if (txtKullaniciAd.Text.Length > 20)
                {
                    MessageBox.Show("Kullanıcı adı çok uzun");
                }
                else if (string.IsNullOrEmpty(txtKullaniciAd.Text))
                {
                    MessageBox.Show("Kullanıcı adı boş bırakılamaz");
                }
                else if (string.IsNullOrEmpty(txtMail.Text))
                {
                    MessageBox.Show("Mail boş bırakılamaz");
                }
                else if (string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("Şifre boş bırakılamaz");
                }
                else if (txtSifre.Text.Length > 20)
                {
                    MessageBox.Show("Şifre çok uzun");
                }
                else
                {
                    SqlCommand komut = new SqlCommand("insert into TBLKULLANICI(KULLANICIAD,MAIL,SIFRE) values (@p1,@p2,@p3) ", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtMail.Text);
                    komut.Parameters.AddWithValue("@p3", txtSifre.Text);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kayıt yapıldı . Lütfen giriş yapınız");
                    FrmGirisPaneli fr = new FrmGirisPaneli();
                    fr.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

    }
}
