using System;
using System.Collections.Generic;
using System.Text;

namespace OdevClass
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " " + musteri.SubeKodu +  " " +"SİSTEME EKLENDİ");

        }

        public void Sil (Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " " + musteri.SubeKodu + " " + "sistemden silindi");

        }
    }
}
