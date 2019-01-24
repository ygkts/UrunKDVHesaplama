using System;

namespace u2_UrunKdvHesaplama
{
    public class Tekstil : Urun
    {
        public string KumasTuru { get; set; }
        public int Beden { get; set; }
        public string UreticiFirma { get; set; }

        public Tekstil(string ad, double fiyat, string kumasTuru, int beden)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
            KumasTuru = kumasTuru;
            Beden = beden;
        }
    }
}
