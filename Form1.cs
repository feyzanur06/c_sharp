namespace degiskenler_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, Toplam;
            misir = Convert.ToInt32(TxtMisir.Text);
            su = Convert.ToInt32(TxtSu.Text);
            cay = Convert.ToInt32(Txtcay.Text);
            bilet = Convert.ToInt32(TxtBilet.Text);

            Toplam = misir * 4 + su * 3 + cay * 3 + bilet * 10;
            LblToplam.Text = Toplam.ToString();
            kasatutar = kasatutar + Toplam;
            LblKasa.Text = kasatutar.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            Txtcay.Text = "";
            TxtMisir.Text = "";
            TxtSu.Text = "";
            TxtMisir.Focus();
        }
    }
}
