class Program
{
    static void Main(string[] args)
    {
        // 1. Soru: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
        // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

        Console.WriteLine("1. Soruya Hoşgeldiniz...");

        Console.Write("Lütfen Kaç Adet Sayı Girmek İstediğinizi Yazınız: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i <= sayi1; i++)
        {
            Console.Write("Lütfen {0}. Sayıyı Giriniz: ", i);
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi2 % 2 == 0)
            {
                Console.WriteLine(sayi2 + " Çift Bir Sayıdır");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(sayi2 + " Çift Bir Sayı Değildir.");
                Console.WriteLine();
            }
        }

        // 2. Soru: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
        // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

        Console.WriteLine("2. Soruya Hoşgeldiniz...");

        Console.Write("Lütfen Kaç Adet Sayı Girmek İstediğinizi Yazınız: ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Lütfen Bölen Sayıyı Yazınız: ");
        int sayi4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i <= sayi3; i++)
        {
            Console.Write("Lütfen {0}. Sayıyı Giriniz ({1} Sayısından Büyük Olmak Zorunda): ", i, sayi4);
            int sayi5 = Convert.ToInt32(Console.ReadLine());
            if (sayi5 % sayi4 == 0)
            {
                Console.WriteLine(sayi5 + " " + sayi4 + " Sayısına Tam Bölünüyor.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(sayi5 + " " + sayi4 + " Sayısına Tam Bölünmüyor.");
                Console.WriteLine();
            }
        }

        // 3. Soru: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
        // Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

        Console.WriteLine("3. Soruya Hoşgeldiniz...");
        Console.Write("Lütfen Kaç Adet Kelime Girmek İstediğinizi Yazınız: ");
        int sayi6 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        string[] kelimeler = new string[sayi6];
        for (int i = 0; i < sayi6; i++)
        {
            Console.Write("Lütfen {0}. Kelimeyi Giriniz: ", i + 1);
            kelimeler[i] = Console.ReadLine();
        }
        Console.WriteLine();
        for (int i = sayi6 - 1; i >= 0; i--)
        {
            Console.Write(kelimeler[i] + " ");
        }
        Console.WriteLine();

        // 4. Soru: Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

        Console.WriteLine("4. Soruya Hoşgeldiniz...");
        Console.Write("Lütfen Bir Cümle Giriniz: ");
        string cumle = Console.ReadLine();
        Console.WriteLine();
        string harfliste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                       + "abcçdefgğhiıjklmnoöprsştuüvyz"
                       + "0123456789";
        string[] kelime = cumle.Split(" ");
        int sayac = 0;
        for (int i = 0; i < cumle.Length; i++)
        {
            if (harfliste.Contains(cumle[i]))
            {
                sayac++;
            }
        }
        Console.WriteLine("Cümlede Toplam {0} Tane Harf / Rakam Vardır.", sayac);
        Console.WriteLine("Cümlede Toplam {0} Tane Kelime Vardır.", kelime.Length);
    }
}