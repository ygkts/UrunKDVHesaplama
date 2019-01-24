using System;

// HER BİR ÜRÜN İÇİN AYRI AYRI KDV UYGULATICAZ

namespace u2_UrunKdvHesaplama
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public virtual double kdvUygula()  // 8% kdv  // virtual diyerek ezilebilir (override edilebilir) hale getirdik.
        {
            return Fiyat * 1.08;
        }  
        public Urun()   // constructor
        {

        }
        public Urun(string ad, double fiyat)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
        }
    }
}
