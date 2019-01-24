using System;

namespace u2_UrunKdvHesaplama
{
    public class Ekmek : Urun
    {
        public string EkmekTuru { get; set; }
        public int Gramaj { get; set; }
        public Ekmek(string ad, double fiyat, string ekmekTuru, int gram)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
            EkmekTuru = ekmekTuru;
            Gramaj = gram;
        }
        public override double kdvUygula()  // Urun sınıfndaki bu metodu ezdik (override ettik)
        {
            return Fiyat*1.01;
        }
    }
}
