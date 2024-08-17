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
            FrmUrunListesi fr = new FrmUrunListesi();
            fr.Show();
            this.Hide();
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            FrmMarkalar fr = new FrmMarkalar();
            fr.Show();
            this.Hide();
        }

        private void btnAlisVeris_Click(object sender, EventArgs e)
        {
            FrmAlisVeris fr=new FrmAlisVeris();
            fr.Show();
            this.Hide();    
        }
    }
}
