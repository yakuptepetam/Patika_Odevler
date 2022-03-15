using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_Odev_Telefon_Rehberi
{
    internal class Islemler
    {

        public static void Numara_Kaydet()
        {
            string ad, soyad, numara;
            Console.Write("Bir  İsim Giriniz: ");
            ad = Console.ReadLine();
            Console.Write("Bir Soyad Giriniz: ");
            soyad = Console.ReadLine();
            Console.Write("Bir Numara Giriniz: ");
            numara = Console.ReadLine();
            Database.Telefon_Numarası.Add(new Degiskenler(ad, soyad, numara));
            Console.WriteLine("İşlem Başarıyla Yapıldı.");
        }
        public static void Numara_Sil()
        {
            Console.Write("Lütfen Numarasını Silmek İstediğiniz Kişinin Adını / Soyadını Giriniz:");
            string ad = Console.ReadLine();
            bool bulundumu = false;
            foreach (var item in Database.Telefon_Numarası)
            {
                if (item.Ad.ToLower() == ad.ToLower() || item.Soyad.ToLower() == ad.ToLower())
                {
                    Console.Write("{0} Adlı Kişi Silinmek İstiyor Musunuz? (Y/N) ", ad);
                    string secim = Console.ReadLine();
                    if (secim == "y" || secim == "Y")
                    {
                        Database.Telefon_Numarası.RemoveAt(Database.Telefon_Numarası.IndexOf(item));
                        Console.WriteLine("İşlem Başarıyla Yapıldı.");
                        bulundumu = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("İşlem İptal Edildi.");
                        bulundumu = false;
                    }
                }
                else
                {
                    Console.WriteLine("Kişi Bulunamadı, Lütfen Tekrar Deneyiniz.");
                    bulundumu = (false);
                }
            }
            if (bulundumu == false)
            {
                Console.WriteLine("Aradığınız Krtiterlere Uygun Veri Rehberde Bulunamadı Lütfen Bir Seçim Yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int secim2 = Convert.ToInt32(Console.ReadLine());
                if (secim2 == 2)
                {
                    Console.Write("Lütfen Numarasını Silmek İstediğiniz Kişinin Adını / Soyadını Giriniz:");
                    ad = Console.ReadLine();
                    foreach (var item2 in Database.Telefon_Numarası)
                    {
                        if (item2.Ad.ToLower() == ad.ToLower() || item2.Soyad.ToLower() == ad.ToLower())
                        {
                            Console.Write("{0} Adlı Kişi Silinmek İstiyor Musunuz? (Y/N) ", ad);
                            string secim3 = Console.ReadLine();
                            if (secim3 == "y" || secim3 == "Y")
                            {
                                Database.Telefon_Numarası.RemoveAt(Database.Telefon_Numarası.IndexOf(item2));
                                Console.WriteLine("İşlem Başarıyla Yapıldı.");
                                bulundumu = true;
                                break;
                            }
                            else
                            {
                                bulundumu = false;
                            }
                        }
                        else
                        {
                            bulundumu = false;
                        }
                    }
                    if (bulundumu == false)
                    {
                        Console.WriteLine("Kişi Bulunamadı / İşlem İptal Edildi, Lütfen Tekrar Deneyiniz.");
                    }
                }

            }
        }
        public static void Numara_Güncelle()
        {
            bool guncellendimi = false;
            string ad;
            Console.Write("Lütfen Numarasını Güncellemek İstediğiniz Kişinin Adını / Soyadını Giriniz:");
            ad = Console.ReadLine();
            for (int i = 0; i < Database.Telefon_Numarası.Count; i++)
            {
                if (Database.Telefon_Numarası[i].Ad.ToLower() == ad.ToLower() || Database.Telefon_Numarası[i].Soyad.ToLower() == ad.ToLower())
                {
                    Console.Write("{0} Adlı Kişi Güncellemek İstiyor Musunuz? (Y/N) ", ad);
                    string secim = Console.ReadLine();
                    if (secim == "y" || secim == "Y")
                    {
                        Console.Write("Lütfen Güncellemek İstediğiniz Telefon Numarasını Giriniz: ");
                        string numara = Console.ReadLine();
                        Database.Telefon_Numarası[i].Numara = numara;
                        Console.WriteLine("İşlem Başarıyla Yapıldı.");
                        guncellendimi = true;
                        break;
                    }
                    else
                    {
                        guncellendimi = false;
                    }
                }
                else
                {
                    guncellendimi = false;
                }
            }
            if (guncellendimi == false)
            {
                Console.WriteLine("Kişi Bulunamadı / İşlem İptal Edildi, Lütfen Tekrar Deneyiniz.");
            }

        }
        public static void Numara_Ara()
        {
            Console.WriteLine("Arama Yapmak İstediğiniz Tipi Seçiniz.");
            Console.WriteLine("***********************************************");
            Console.WriteLine("İsim Veya Soyisime Göre Arama Yapmak İçin: (1)");
            Console.WriteLine("Telefon Numarasına Göre Arama Yapmak İçin: (2)");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.Write("Lütfen Arama Yapmak İstediğiniz Kişinin Adını / Soyadını Giriniz: ");
                string ad = Console.ReadLine();
                foreach (var item in Database.Telefon_Numarası)
                {
                    if (item.Ad.ToLower() == ad.ToLower() || item.Soyad.ToLower() == ad.ToLower())
                    {
                        Console.WriteLine("isim: {0}", item.Ad);
                        Console.WriteLine("Soyisim: {0}", item.Soyad);
                        Console.WriteLine("Telefon Numarası: {0}", item.Numara);
                        Console.WriteLine("-");
                    }
                }
            }
            else
            {
                Console.Write("Lütfen Arama Yapmak İstediğiniz Kişinin Numarasını Giriniz: ");
                string numara = Console.ReadLine();
                foreach (var item in Database.Telefon_Numarası)
                {
                    if (item.Numara.ToLower() == numara.ToLower())
                    {
                        Console.WriteLine("isim: {0}", item.Ad);
                        Console.WriteLine("Soyisim: {0}", item.Soyad);
                        Console.WriteLine("Telefon Numarası: {0}", item.Numara);
                        Console.WriteLine("-");
                    }
                }
            }
        }
        public static void Rehber_Listele()
        {
            Console.WriteLine("Rehber Listeniz: ");
            Console.WriteLine("******************");
            foreach (var item in Database.Telefon_Numarası)
            {
                Console.WriteLine("isim: {0}", item.Ad);
                Console.WriteLine("Soyisim: {0}", item.Soyad);
                Console.WriteLine("Telefon Numarası: {0}", item.Numara);
                Console.WriteLine("-");
            }
        }
    }
}
