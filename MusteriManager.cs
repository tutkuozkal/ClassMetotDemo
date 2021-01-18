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

       
    }
}
