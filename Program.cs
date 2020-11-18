using System;

namespace MertMelihYuceClassOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Odev();
        }
        private static void Baslik(string baslik)
        {
            Console.Write($"--------------\n{baslik}");
        }

        private static void Odev()
        {
            int secim;
            try
            {
                Baslik("1 = Alan Hesapla\n2 = Çevre Hesapla\n3 = Müşteri/Öğrenci\nÖdev Numarası Giriniz: ");
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        AlanHesaplama();
                        break;

                    case 2:
                        CevreHesaplama();
                        break;

                    case 3:
                        MusteriOgrenci();
                        break;

                    default:
                        Console.Clear();
                        Console.Write("Lütfen geçerli ödev numarası giriniz. (1-3)\n");
                        Odev();
                        break;
                }
            }
            catch
            {
                Console.Write("Hata.");
            }
        }

        private static void AlanHesaplama()
        {
            try
            {
                Console.Clear();
                double a, b,sonuc;
                Console.Write("1. Kenarı Giriniz: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("2. Kenarı Giriniz: ");
                b = double.Parse(Console.ReadLine());
                Dikdortgen dikdortgen = new Dikdortgen();
                sonuc = dikdortgen.Alan(a, b);
                Console.WriteLine($"Sonuç: {sonuc}");
                Odev();
            }

            catch
            {
                Console.Write("Hata.");
            }
        }

        private static void CevreHesaplama()
        {
            try
            {
                Console.Clear();
                double a, b, sonuc;
                Console.Write("1. Kenarı Giriniz: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("2. Kenarı Giriniz: ");
                b = double.Parse(Console.ReadLine());
                Dikdortgen dikdortgen = new Dikdortgen();
                sonuc = dikdortgen.Cevre(a, b);
                Console.WriteLine($"Sonuç: {sonuc}");
                Odev();
            }

            catch
            {
                Console.Write("Hata.");
            }
        }

        private static void MusteriOgrenci()
        {
            try
            {
                Console.Clear();
                string ogrencimi, ad, soyad, meslek, sonuc;
                int ogrno, yas;
                double maas;
                Console.Write("Öğrenci misiniz? (Evet-Hayır): ");
                ogrencimi = Console.ReadLine();
                if (ogrencimi.ToLower() == "evet")
                {
                    Musteri musteri = new Musteri();
                    Console.Write("Adınız: ");
                    ad = Console.ReadLine();
                    Console.Write("Soyadınız: ");
                    soyad = Console.ReadLine();
                    Console.Write("Öğrenci No: ");
                    ogrno = int.Parse(Console.ReadLine());
                    Console.Write("Yaş: ");
                    yas = int.Parse(Console.ReadLine());
                    sonuc = $"Adınız: {ad},\nSoyadınız: {soyad},\nÖğrenci No: {ogrno},\nYaş: {yas}\n";
                    Baslik(sonuc);
                }
                else if(ogrencimi.ToLower()=="hayır")
                {
                    Musteri musteri = new Musteri();
                    Console.Write("Adınız: ");
                    ad = Console.ReadLine();
                    Console.Write("Soyadınız: ");
                    soyad = Console.ReadLine();
                    Console.Write("Yaş: ");
                    yas = int.Parse(Console.ReadLine());
                    Console.Write("Meslek: ");
                    meslek = Console.ReadLine();
                    Console.Write("Maaş: ");
                    maas = double.Parse(Console.ReadLine());
                    sonuc = $"Adınız: {ad},\nSoyadınız: {soyad},\nYaş: {yas},\nMeslek: {meslek},\nMaaş: {maas}\n";
                    Baslik(sonuc);
                }
                Odev();
            }

            catch
            {
                Console.Write("Hata.");
            }
        }
    }
}
