using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi :"+musteri.Id + " "+musteri.Adi+" "+musteri.Soyadi+" "+musteri.Sehir);
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi :"+musteri.Id+" "+musteri.Adi+" "+musteri.Soyadi+" "+musteri.Sehir);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi :"+musteri.Id+" "+musteri.Adi+""+musteri.Soyadi+" "+musteri.Sehir);
        }
    }
}
