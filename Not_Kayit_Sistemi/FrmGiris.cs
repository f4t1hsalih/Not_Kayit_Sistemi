namespace Not_Kayit_Sistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOgrenciDetay ogrenciDetay = new FrmOgrenciDetay();
            ogrenciDetay.numara = maskedTextBox1.Text;
            ogrenciDetay.Show();
            this.Hide();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                FrmOgretmenDetay ogretmenDetay = new FrmOgretmenDetay();
                ogretmenDetay.Show();
                this.Hide();
            }
        }

        private void FrmGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}