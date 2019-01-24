using System;

namespace u2_UrunKdvHesaplama
{
    public class CepTelefonu : Urun
    {
        public string Ozellikler { get; set; }
        public string Marka { get; set; }
        public CepTelefonu (string ad, double fiyat, string marka)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
            Marka = marka;
        }
        public override double kdvUygula()  // Urun sınıfndaki bu metodu ezdik (override ettik)
        {
            return Fiyat * 1.18;
        }
    }
}
