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
            FrmUrunListesi fr=new FrmUrunListesi();
            fr.Show();
            this.Hide();
        }
    }
}
