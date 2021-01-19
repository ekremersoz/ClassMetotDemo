using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Adi = "Ekrem";
            musteri.Soyadi = "Ersöz";
            musteri.Sehir = "Ankara";

            Musteri musteri2 = new Musteri
            {
                Id = 2,
                Adi ="Baran",
                Soyadi = "Düzgün",
                Sehir = "Sivas"
            };

            Musteri muster3 = new Musteri
            {
                Id = 3,
                Adi = "Onur",
                Soyadi = "Yılmaz",
                Sehir = "Yozgat"
            };
            
            Musteri[] musteriler = new Musteri [] {musteri , musteri2,muster3 };

            foreach (Musteri item in musteriler)
            {
                musteriManager.Listeleme(item);
            }

            musteriManager.Ekleme(musteri);
            musteriManager.Silme(musteri2);
        }
    }
}
