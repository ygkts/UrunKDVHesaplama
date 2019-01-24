using System;
using System.Windows.Forms;

namespace u2_UrunKdvHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sepet spt = new Sepet();

            Ekmek ekm = new Ekmek(txtEkMarka.Text, Convert.ToInt16(txtEkFiyat.Text), txtEkTur.Text, Convert.ToInt16(txtEkGram.Text));
            spt.urunEkle(ekm);

            Tekstil tks = new Tekstil(txtTekAd.Text, Convert.ToInt16(txtTekFiyat.Text), txtTekTur.Text, Convert.ToInt16(txtTekBeden.Text));
            spt.urunEkle(tks);

            CepTelefonu cptel = new CepTelefonu(txtCepTur.Text, Convert.ToInt16(txtCepFiyat.Text), txtCepMarka.Text);
            spt.urunEkle(cptel);

            label1.Text = "Sepetteki ürünlerin kdv'li fiyatları toplamı : " + spt.ToplamTutar().ToString();
            //MessageBox.Show("Sepetteki ürünlerin kdv'li fiyatları toplamı : " + spt.ToplamTutar().ToString());
        }
    }
}
