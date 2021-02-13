using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {

            Console.WriteLine(musteri.AdSoyad + "  Başarıyla eklendi...");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Id:  " + musteri.Id);
            Console.WriteLine("Müşteri Adı:  " + musteri.AdSoyad);
            Console.WriteLine("Müşteri Hesap Tipi:  " + musteri.HesapTipi);
            Console.WriteLine("Müşteri Bakiyesi:  " + musteri.Bakiye);

        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.AdSoyad + "  Başarıyla silindi...");
        }
    }
}
