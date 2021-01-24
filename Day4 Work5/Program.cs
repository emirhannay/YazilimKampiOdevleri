using System;

namespace Day4_Work5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aynen derste yaptığımız MyList gibi siz de kendi Dictonary sınıfınızı yazınız. (MyDictionary)

            //Sadece ekleme(Add) metodunu yazınız.


            MyGenericDictionary<int, string> Sehirler = new MyGenericDictionary<int, string>();
            Sehirler.Add(16, "Bursa");
            Sehirler.Add(34, "İstanbul");
            Sehirler.Add(52, "Ordu");
            Sehirler.Add(16, "Şanlıurfa");
            Sehirler.Add(16, "Yalova");

            Console.WriteLine("Plaka No: " +Sehirler.Items1[0] + " " + "Şehir: " + Sehirler.Items2[0]);
            Console.WriteLine("Plaka No: " + Sehirler.Items1[1] + " " + "Şehir: " + Sehirler.Items2[1]);
            Console.WriteLine("Plaka No: " + Sehirler.Items1[2] + " " + "Şehir: " + Sehirler.Items2[2]);
            Console.WriteLine("Plaka No: " + Sehirler.Items1[3] + " " + "Şehir: " + Sehirler.Items2[3]);
            Console.WriteLine("Plaka No: " + Sehirler.Items1[4] + " " + "Şehir: " + Sehirler.Items2[4]);








        }
    }

}
