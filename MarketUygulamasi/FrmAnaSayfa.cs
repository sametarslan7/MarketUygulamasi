namespace MarketUygulamasi
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            FrmUrunEkle fr=new FrmUrunEkle();
            fr.Show();
            this.Hide();
        }
    }
}
