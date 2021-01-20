using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3_Work_3
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla eklendi...");
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Id);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla silindi...");
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Id);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla listelendi...");
            Console.WriteLine("Bilgiler şu şekildedir...");
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Id);
        }
    }
    
}

