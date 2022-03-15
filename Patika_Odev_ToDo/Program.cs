using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_Odev_ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamList.Team.Add(new Team(1, "Ali"));
            TeamList.Team.Add(new Team(2, "Sude"));
            TeamList.Team.Add(new Team(3, "Aylin"));
            TeamList.Team.Add(new Team(4, "Fırat"));
            TeamList.Team.Add(new Team(5, "Yakup"));


            Board.Card.Add(new Card("Beşiktaş", "Futbol", 5, Size.CardSize.XL.ToString()));
            Board.Card.Add(new Card("Galatasaray", "Yüzme", 3, Size.CardSize.L.ToString()));
            Board.Card.Add(new Card("Fenerbahçe", "Basketbol", 2, Size.CardSize.M.ToString()));
            Board.Card.Add(new Card("Trabzon", "Takım", 4, Size.CardSize.S.ToString()));

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz ");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Board'da Kart Taşımak");
            int secim = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (secim == 1)
            {
                Islemler.Board_Listele();
            }
            else if (secim == 2)
            {
                Islemler.Board_Kaydet();
            }
            else if (secim == 3)
            {
                Islemler.Board_Sil();
            }
            else if (secim == 4)
            {
                //Islemler.Board_Listele();
            }
            else
            {
                Console.WriteLine("1-4 Aralığı Dışında Bir Sayı Girdiniz, Lütfen Tekrar Deneyiniz.");
            }
        }
    }
}