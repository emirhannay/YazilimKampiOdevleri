using System;

namespace Day_3_Work_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Şimdi Github hesabınıza biraz hit alalım :)

            //            ClassMetotDemo isimli bir proje oluşturunuz.
            //Bunu Github'a aktarınız.
            //Projeniz şunu yapacak.

            //Bir bankada müşteri takibi yapmak istiyorsunuz.
            //Musteri isimli bir Class oluşturunuz.Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
            //MusteriManager sınıfı oluşturunuz.Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Emirhan";
            musteri1.Soyad = "Ay";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri1);
            musteriManager.Listele(musteri1);

        }
    }
}
