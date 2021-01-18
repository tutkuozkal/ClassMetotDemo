using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi" + " : " + musteri.ID + " " +musteri.Adi + " " + musteri.Soyadi + " " + musteri.Sehir + " " + musteri.Telefon);
        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi" + " : " + musteri.ID + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Sehir + " " + musteri.Telefon);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi" + " : " + musteri.ID + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Sehir + " " + musteri.Telefon);
        }

        public void ListMusteri(Musteri musteri)
        {
            
            //foreach (var Listeler in List)
            //{
            //    Console.WriteLine("Musteri ID: " + musteri.ID);
            //    Console.WriteLine(" ");
            //    Console.WriteLine("Musteri Adı: " + musteri.Adi);
            //    Console.WriteLine("Musteri Soyadi: " + musteri.Soyadi);
            //    Console.WriteLine("Musteri Sehir: " + musteri.Sehir);
            //    Console.WriteLine("Musteri Telefon: " + musteri.Telefon);
            //    Console.WriteLine(" ");
            //}
            //Console.WriteLine("Müşteri " + " : " + musteri.ID + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Sehir + " " + musteri.Telefon);
        }
    }
}
