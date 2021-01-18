using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.Adi = "Ilhan";
            musteri1.Soyadi = "Koman";
            musteri1.TcKimlikNo = 00001111111;
            musteri1.Yas = 65;
            musteri1.Sehir = "Edirne";
            musteri1.Email = "ilhank@gmail.com";
            musteri1.Telefon = 123456;

            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.Adi = "Ara";
            musteri2.Soyadi = "Guler";
            musteri2.TcKimlikNo = 00002222222;
            musteri2.Yas = 90;
            musteri2.Sehir = "Istanbul";
            musteri2.Email = "arag@gmail.com";
            musteri2.Telefon = 789101;

            Musteri musteri3 = new Musteri();
            musteri3.ID = 3;
            musteri3.Adi = "Tanju";
            musteri3.Soyadi = "Okan";
            musteri3.TcKimlikNo = 00003333333;
            musteri3.Yas = 57;
            musteri3.Sehir = "Izmir";
            musteri3.Email = "tanjuo@gmail.com";
            musteri3.Telefon = 111213;


            MusteriManager MusteriListesi = new MusteriManager();
            MusteriListesi.Add(musteri1);
            MusteriListesi.Delete(musteri2);
            MusteriListesi.Update(musteri3);
           

            Musteri[] musteri = new Musteri[] {musteri1,musteri2,musteri3 };

            foreach (var Listeler in musteri)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Musteri ID: " + Listeler.ID);
                Console.WriteLine(" ");
                Console.WriteLine("Musteri Adı: " + Listeler.Adi);
                Console.WriteLine("Musteri Soyadi: " + Listeler.Soyadi);
                Console.WriteLine("Musteri Sehir: " + Listeler.Sehir);
                Console.WriteLine("Musteri Telefon: " + Listeler.Telefon);
                Console.WriteLine(" ");
            }

        }
    }
}
