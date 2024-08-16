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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESTROYERM\\SQLEXPRESS;Initial Catalog=DB_MARKET;Integrated Security=True");

        public void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select TBLURUN.URUNID,TBLURUN.URUNAD,TBLURUN.MARKAAD,TBLKATEGORI.KATEGORIAD,TBLURUN.URUNBARKOD,TBLURUN.URUNSTOK,TBLURUN.URUNFIYAT from TBLURUN join TBLKATEGORI on TBLURUN.KATEGORIID=TBLKATEGORI.KATEGORIID", baglanti);

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem();

                item.Text = oku["URUNID"].ToString();
                item.SubItems.Add(oku["URUNAD"].ToString());
                item.SubItems.Add(oku["MARKAAD"].ToString());
                item.SubItems.Add(oku["KATEGORIAD"].ToString());
                item.SubItems.Add(oku["URUNBARKOD"].ToString());
                item.SubItems.Add(oku["URUNSTOK"].ToString());
                item.SubItems.Add(oku["URUNFIYAT"].ToString());

                listView1.Items.Add(item);
            }
            baglanti.Close();
        }

        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            VerileriGoster();
        }


        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            txtID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBoxMarka.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1Kategori.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtBarkod.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtStok.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtFiyat.Text = listView1.SelectedItems[0].SubItems[6].Text;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand(@"
    UPDATE TBLURUN 
    SET 
        TBLURUN.URUNAD = @p1,
        TBLURUN.MARKAAD = @p2,
        TBLURUN.URUNBARKOD = @p4,
        TBLURUN.URUNSTOK = @p5,
        TBLURUN.URUNFIYAT = @p6
    FROM 
        TBLURUN
    INNER JOIN 
        TBLKATEGORI ON TBLURUN.KATEGORIID = TBLKATEGORI.KATEGORIID
    WHERE 
        TBLURUN.URUNID = @pid 
        AND TBLKATEGORI.KATEGORIAD = @p3", baglanti);
            komut2.Parameters.AddWithValue("@pid", txtID.Text);
            komut2.Parameters.AddWithValue("@p1", txtAd.Text);
            komut2.Parameters.AddWithValue("@p2", comboBoxMarka.Text);
            komut2.Parameters.AddWithValue("@p3", comboBox1Kategori.Text);
            komut2.Parameters.AddWithValue("@p4", txtBarkod.Text);
            komut2.Parameters.AddWithValue("@p5", txtStok.Text);
            komut2.Parameters.AddWithValue("@p6", Convert.ToDecimal(txtFiyat.Text));

            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün veritabanından başarılı bir şekilde silindi.");
            VerileriGoster();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("DELETE from TBLURUN where URUNID=@pid", baglanti);

            komut2.Parameters.AddWithValue("@pid", txtID.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün veritabanından başarılı bir şekilde silindi.");
            VerileriGoster();
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
            comboBox1Kategori.Text = "Bebek";
            lblKategoriID.Text = "1";
            MarkalariGetir();
        }

        private void btnSebzeMeyve_Click(object sender, EventArgs e)
        {
            comboBox1Kategori.Text = "Sebze-Meyve";
            lblKategoriID.Text = "2";
            MarkalariGetir();
        }

        private void btnUnluMamuller_Click(object sender, EventArgs e)
        {
            comboBox1Kategori.Text = "Unlu Mamüller";
            lblKategoriID.Text = "3";
            MarkalariGetir();
        }

        private void btnTemizlik_Click(object sender, EventArgs e)
        {
            comboBox1Kategori.Text = "Temizlik";
            lblKategoriID.Text = "4";
            MarkalariGetir();
        }

        private void btnIcecek_Click(object sender, EventArgs e)
        {
            comboBox1Kategori.Text = "İçecek";
            lblKategoriID.Text = "5";
            MarkalariGetir();
        }

        private void btnAtistirmalik_Click(object sender, EventArgs e)
        {
            comboBox1Kategori.Text = "Atıştırmalık";
            lblKategoriID.Text = "6";
            MarkalariGetir();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select TBLURUN.URUNID,TBLURUN.URUNAD,TBLURUN.MARKAAD,TBLKATEGORI.KATEGORIAD,TBLURUN.URUNBARKOD,TBLURUN.URUNSTOK,TBLURUN.URUNFIYAT from TBLURUN join TBLKATEGORI on TBLURUN.KATEGORIID=TBLKATEGORI.KATEGORIID where URUNBARKOD=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAra.Text);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = oku["URUNID"].ToString();
                item.SubItems.Add(oku["URUNAD"].ToString());
                item.SubItems.Add(oku["MARKAAD"].ToString());
                item.SubItems.Add(oku["KATEGORIAD"].ToString());
                item.SubItems.Add(oku["URUNBARKOD"].ToString());
                item.SubItems.Add(oku["URUNSTOK"].ToString());
                item.SubItems.Add(oku["URUNFIYAT"].ToString());

                listView1.Items.Add(item);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUrunEkle fr = new FrmUrunEkle();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr=new FrmAnaSayfa();
            fr.Show();
            this.Close();
        }
    }
}
