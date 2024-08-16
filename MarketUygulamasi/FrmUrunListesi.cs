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


        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
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
    }
}
