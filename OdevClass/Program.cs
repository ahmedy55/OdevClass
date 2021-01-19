using System;

namespace OdevClass
{
    class Program
    {
        static void Main(string[] args)
        {

                        
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAd = "Ahmet";
            musteri1.MusteriSoyad = "türkdönmez";
            musteri1.SubeKodu = 15;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAd = "Feyza";
            musteri2.MusteriSoyad = "Genç";
            musteri2.SubeKodu = 34;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAd = "Pırıl";
            musteri3.MusteriSoyad = "Ak";
            musteri3.SubeKodu = 2;

            Musteri musteri4 = new Musteri();
            musteri4.MusteriAd = "Özen ";
            musteri4.MusteriSoyad = "Keskin";
            musteri4.SubeKodu = 1;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + "\n");

            }

            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz" + "\n" + " 1-Müşteri Silme" + "\n" + "2-Müşteri Ekleme");
            Console.Write("Lütfen Klavyenizden değer giriniz : "); Console.ReadLine();

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Sil(musteri2);
           



        }
    }
}
