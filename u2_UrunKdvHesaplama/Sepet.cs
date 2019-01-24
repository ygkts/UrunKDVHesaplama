using System;
using System.Collections.Generic;

namespace u2_UrunKdvHesaplama
{
    public class Sepet : Urun
    {
        private List<Urun> urunler = new List<Urun>();
        public double ToplamTutar ()
        {
            double toplamFiyat = 0;
            foreach (Urun item in urunler)  // Urun sınıfından üretilen item, urunler listesinin her bir elemanı oluyor
            {
                toplamFiyat = item.kdvUygula();  // Urun Sınıfındaki kdvUygula metodunun döndürdüğü kdvli fyat toplam fiyata ekleniyor
            }
            return toplamFiyat;
        }
        public void urunEkle(Urun yeniUrun)
        {
            urunler.Add(yeniUrun);
        }
    }
}
