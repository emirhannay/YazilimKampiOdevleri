using System;

namespace YazılımKampıOdevleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Herhangi bir e-ticaret sistemine giriniz.

        Genellikle bir e-ticaret sistemine girdiğinizde ürünler listelenir. Siz de Urun (Product) isimli bir class oluşturup, oluşturduğunuz bir kaç ürünü bir diziye ekleyiniz.

         Ürünlerinizi for, foreach ve while döngüleri ile ayrı ayrı listeleyiniz.

         Bunu repl.it sitesinde yapıp, repl linkinizi paylaşabilirsiniz. Kodlarınızın arasına yorum satırı ekleyerek, ilgili satırın ne işe yaradığını anlatabilirsiniz. */


            Product urun1 = new Product();
            urun1.Id = 1;
            urun1.Adi = "Helios 7A";
            urun1.Gpu = "Msi Rtx 3090";
            urun1.Cpu = "AMD Ryzen 9 5900x";
            urun1.Ram = "Corsair 32GB(2x16) 3200Mhz";
            urun1.Fiyat = 32648;

            Product urun2 = new Product();
            urun2.Id = 2;
            urun2.Adi = "Deluxe 5A-RTX3070";
            urun2.Gpu = "Palit Rtx 3070";
            urun2.Cpu = "AMD Ryzen 5 3600";
            urun2.Ram = "Crucial Ballistix 2x8 16GB 3000Mhz";
            urun2.Fiyat = 11352;

            Product urun3 = new Product();
            urun3.Id = 3;
            urun3.Adi = "Deluxe 5A-RTX3060";
            urun3.Gpu = "Inno3D RTX3060Ti";
            urun3.Cpu = "AMD Ryzen 5 3500X";
            urun3.Ram = "Corsair 32GB(2x16) 3200Mhz";
            urun3.Fiyat = 9982;

            Product[] urunler = new Product[] { urun1, urun2, urun3 };

            foreach (Product y in urunler)
            {
                Console.WriteLine(y.Id + ": " + y.Adi);
                Console.WriteLine("Özellikleri : " + y.Gpu + "  " + y.Cpu + "  " + y.Ram + "  Fiyat :" + y.Fiyat);
                Console.WriteLine("Writed by foreach");
                Console.WriteLine("            ");
            }

            Console.WriteLine("--------------------------------------------------------------------------------");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].Id + ": " + urunler[i].Adi);
                Console.WriteLine("Özellikleri : " + urunler[i].Gpu + "  " + urunler[i].Cpu + "  " + urunler[i].Ram + "  Fiyat :" + urunler[i].Fiyat);
                Console.WriteLine(" Writed by 'for'");
                Console.WriteLine("            ");
            }

            Console.WriteLine("--------------------------------------------------------------------------------");

            int a = 0;

            while (a < urunler.Length)
            {
                Console.WriteLine(urunler[a].Id + ": " + urunler[a].Adi);
                Console.WriteLine("Özellikleri : " + urunler[a].Gpu + "  " + urunler[a].Cpu + "  " + urunler[a].Ram + "  Fiyat :" + urunler[a].Fiyat);
                Console.WriteLine("Writed by 'while'");
                Console.WriteLine("            ");
                a++;
            }














        }
    }
}
