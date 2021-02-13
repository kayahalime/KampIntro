using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.AdSoyad = "Ahmet Yılmaz";
            musteri1.HesapTipi = "Vadesiz Hesap";
            musteri1.Bakiye = 100.000;

            Musteri musteri2 = new Musteri();

            musteri2.Id = 2;
            musteri2.AdSoyad = "Ayşe Solmaz";
            musteri2.HesapTipi = "Vadeli Hesap";
            musteri2.Bakiye = 88.000;


            Musteri musteri3 = new Musteri();

            musteri3.Id = 3;
            musteri3.AdSoyad = "Fatma Demir";
            musteri3.HesapTipi = "Yatırım Hesabı";
            musteri3.Bakiye = 92.000;

            Musteri musteri4 = new Musteri();

            musteri4.Id = 4;
            musteri4.AdSoyad = "Mert Varol";
            musteri4.HesapTipi = "Vadesiz Hesap";
            musteri4.Bakiye = 15.700;

            Musteri musteri5 = new Musteri();

            musteri5.Id = 5;
            musteri5.AdSoyad = "Sevgi Çakır";
            musteri5.HesapTipi = "Yatırım Hesap";
            musteri5.Bakiye = 150.250;
            Musteri[] musteriler = new Musteri[5] { musteri1, musteri2, musteri3, musteri4, musteri5 };
            Console.WriteLine("****************************************************");
            Console.WriteLine("----------------Ekle metodu-------------------");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("****************************************************");
            Console.WriteLine("----------------Listele metodu-------------------");

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Listele(musteri);
                Console.WriteLine("---------------------------");

            }
          
           
            Console.WriteLine("****************************************************");
            Console.WriteLine("----------------Sil metodu-------------------");
            
                musteriManager.Sil(musteri4);
                musteriManager.Sil(musteri5);
            Console.WriteLine("****************************************************");

        }
    }
}
