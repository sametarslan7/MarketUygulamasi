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
            txtKategori.Text = listView1.SelectedItems[0].SubItems[3].Text;
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
            komut2.Parameters.AddWithValue("@pid",txtID.Text);
            komut2.Parameters.AddWithValue("@p1",txtAd.Text);
            komut2.Parameters.AddWithValue("@p2",comboBoxMarka.Text);
            komut2.Parameters.AddWithValue("@p3",txtKategori.Text);
            komut2.Parameters.AddWithValue("@p4",txtBarkod.Text);
            komut2.Parameters.AddWithValue("@p5",txtStok.Text);
            komut2.Parameters.AddWithValue("@p6",Convert.ToDecimal(txtFiyat.Text));

            komut2.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }
    }
}
