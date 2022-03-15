using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Patika_Odev_Telefon_Rehberi
{

    class Program
    {
        static void Main(string[] args)
        {
            Database.Telefon_Numarası.Add(new Degiskenler("Yakup", "Tepatam", "05358254505"));
            Database.Telefon_Numarası.Add(new Degiskenler("Yakup", "Cevizli", "05358254506"));
            Database.Telefon_Numarası.Add(new Degiskenler("Sude", "Naz", "05358254507"));
            Database.Telefon_Numarası.Add(new Degiskenler("Selin", "Yılmaz", "05358254508"));
            Database.Telefon_Numarası.Add(new Degiskenler("Kemal", "Korkun", "05358254509"));

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz ");
            Console.WriteLine("****************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncellemek");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
            int secim = int.Parse(Console.ReadLine());
            if (secim == 1)
            {
                Islemler.Numara_Kaydet();
            }
            else if (secim == 2)
            {
                Islemler.Numara_Sil();
            }
            else if (secim == 3)
            {
                Islemler.Numara_Güncelle();
            }
            else if (secim == 4)
            {
                Islemler.Rehber_Listele();
            }
            else if (secim == 5)
            {
                Islemler.Numara_Ara();
            }
            else
            {
                Console.WriteLine("1-5 Aralığı Dışında Bir Sayı Girdiniz, Lütfen Tekrar Deneyiniz.");
            }
        }
    }
}