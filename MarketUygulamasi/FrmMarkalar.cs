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
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESTROYERM\\SQLEXPRESS;Initial Catalog=DB_MARKET;Integrated Security=True");

        public void MarkalarıGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select TBLMARKA.MARKAID,TBLMARKA.MARKAAD,TBLKATEGORI.KATEGORIAD from TBLMARKA join TBLKATEGORI on TBLMARKA.KATEGORIID=TBLKATEGORI.KATEGORIID", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = oku["MARKAID"].ToString();
                item.SubItems.Add(oku["MARKAAD"].ToString());
                item.SubItems.Add(oku["KATEGORIAD"].ToString());

                listView1.Items.Add(item);
            }
            baglanti.Close();
        }

        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            MarkalarıGoster();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT KATEGORIAD FROM TBLKATEGORI", baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                comboBoxKategori.Items.Add(reader["KATEGORIAD"].ToString());
            }

            reader.Close();
            baglanti.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select TBLMARKA.MARKAID,TBLMARKA.MARKAAD,TBLKATEGORI.KATEGORIAD from TBLMARKA join TBLKATEGORI on TBLMARKA.KATEGORIID=TBLKATEGORI.KATEGORIID where MARKAAD=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAra.Text);

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = oku["MARKAID"].ToString();
                item.SubItems.Add(oku["MARKAAD"].ToString());
                item.SubItems.Add(oku["KATEGORIAD"].ToString());

                listView1.Items.Add(item);
            }
            baglanti.Close();
            txtAra.Text = "";
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtMarkaID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtMarkaAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBoxKategori.SelectedItem = listView1.SelectedItems[0].SubItems[2].Text;

        }

        public void Temizle()
        {
            txtMarkaID.Text = "";
            txtMarkaAd.Text = "";
            comboBoxKategori.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from TBLMARKA where MARKAID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtMarkaID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün veritabanından başarılı bir şekilde silindi.");
            MarkalarıGoster();
            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMARKA (MARKAAD,KATEGORIID) values(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtMarkaAd.Text);
            komut.Parameters.AddWithValue("@p2", Convert.ToInt32(comboBoxKategori.SelectedIndex + 1));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MarkalarıGoster();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLMARKA set MARKAAD=@p1,KATEGORIID=@p2 where MARKAID=@pid", baglanti);
            komut.Parameters.AddWithValue("@pid", txtMarkaID.Text);
            komut.Parameters.AddWithValue("@p1", txtMarkaAd.Text);
            komut.Parameters.AddWithValue("@p2", Convert.ToInt32(comboBoxKategori.SelectedIndex + 1));
            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Marka başarılı bir şekilde güncellendi.");
            MarkalarıGoster();
            Temizle();
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
    }
}
