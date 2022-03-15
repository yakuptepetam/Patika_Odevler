using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_Odev_ToDo
{
    internal class Islemler
    {
        public static string TeamName(int id)
        {
            foreach (var item in TeamList.Team)
            {
                if (item.Id == id)
                {
                    return item.Ad;
                }
            }
            return null;
        }

        public static string SizeGetir(int number)
        {
            if (number == 1)
            {
                return Size.CardSize.XS.ToString();
            }
            else if (number == 2)
            {
                return Size.CardSize.S.ToString();
            }
            else if (number == 3)
            {
                return Size.CardSize.M.ToString();
            }
            else if (number == 4)
            {
                return Size.CardSize.L.ToString();
            }
            else
            {
                return Size.CardSize.XL.ToString();
            }
        }
        public static void Board_Kaydet()
        {
            string baslik, icerik, size;
            int team;
            Console.Write("Bir  Başlık Giriniz: ");
            baslik = Console.ReadLine();
            Console.Write("Bir İçerik Giriniz: ");
            icerik = Console.ReadLine();
            Console.Write("Bir Kişi Numarası Giriniz: ");
            team = Convert.ToInt32(Console.ReadLine());
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5): ");
            size = SizeGetir(Convert.ToInt32(Console.ReadLine()));
            Board.Card.Add(new Card(baslik, icerik, team, size));
            Console.WriteLine("İşlem Başarıyla Yapıldı.");
        }
        public static void Board_Sil()
        {
            Console.Write("Lütfen Silmek İstediğiniz Kartın Adını Giriniz:");
            string baslik = Console.ReadLine();
            bool bulundumu = false;
            foreach (var item in Board.Card)
            {
                if (item.Baslik.ToLower() == baslik.ToLower())
                {
                    Console.Write("{0} Adlı Kartı Silinmek İstiyor Musunuz? (Y/N) ", baslik);
                    string secim = Console.ReadLine();
                    if (secim == "y" || secim == "Y")
                    {
                        Board.Card.RemoveAt(Board.Card.IndexOf(item));
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
                Console.WriteLine("Aradığınız Krtiterlere Uygun Veri Bulunamadı Lütfen Bir Seçim Yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int secim2 = Convert.ToInt32(Console.ReadLine());
                if (secim2 == 2)
                {
                    Console.Write("Lütfen Silmek İstediğiniz Kartın Adını Giriniz:");
                    baslik = Console.ReadLine();
                    foreach (var item2 in Board.Card)
                    {
                        if (item2.Baslik.ToLower() == baslik.ToLower())
                        {
                            Console.Write("{0} Adlı Kişi Silinmek İstiyor Musunuz? (Y/N) ", baslik);
                            string secim3 = Console.ReadLine();
                            if (secim3 == "y" || secim3 == "Y")
                            {
                                Board.Card.RemoveAt(Board.Card.IndexOf(item2));
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
        public static void Board_Listele()
        {
            Console.WriteLine("Kart Listeniz: ");
            foreach (var item in Board.Card)
            {
                Console.WriteLine("Başlık: {0}", item.Baslik);
                Console.WriteLine("İçerik: {0}", item.Icerik);
                Console.WriteLine("Atanan Kişi: {0}", TeamName(item.Teamid));
                Console.WriteLine("Büyüklük: {0}", item.Size);
                Console.WriteLine("-");
            }
        }
    }
}
