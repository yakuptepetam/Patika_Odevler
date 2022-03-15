using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // 1. Soru: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

        Console.WriteLine("1. Soruya Hoşgeldiniz...");
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanSayilar = new ArrayList();
        int sayi = 0;
        int kontrol = 0;
        int asalSayilarToplam = 0;
        int asalSayilarCount = 0;
        double asalSayilarAverage = 0;
        int asalOlmayanSayilarToplam = 0;
        int asalOlmayanSayilarCount = 0;
        double asalOlmayanSayilarAverage = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("{0}. Sayı Girniz: ", i + 1);
            sayi = Convert.ToInt32(Console.ReadLine());
            kontrol = 0;
            if (sayi == 1 || sayi == 0)
            {
                asalOlmayanSayilar.Add(sayi);

            }
            else
            {
                for (int j = 2; j <= sayi / 2; j++)
                {
                    if (sayi % j == 0)
                    {
                        kontrol++;
                        break;
                    }


                }

                if (kontrol != 0)
                {
                    asalOlmayanSayilar.Add(sayi);
                }

                else
                {
                    asalSayilar.Add(sayi);
                }

            }
        }
        Console.WriteLine();
        Console.Write("Asal Sayılar: ");
        foreach (var item in asalSayilar)
        {
            Console.Write(item + " ");
            asalSayilarToplam += Convert.ToInt32(item);
        }
        Console.WriteLine();
        Console.Write("Asal Olmayan Sayılar: ");
        foreach (var item2 in asalOlmayanSayilar)
        {
            Console.Write(item2 + " ");
            asalOlmayanSayilarToplam += Convert.ToInt32(item2);
        }
        Console.WriteLine();
        asalSayilarCount = asalSayilar.Count;
        asalOlmayanSayilarCount = asalOlmayanSayilar.Count;
        asalSayilarAverage = asalSayilarToplam / asalSayilarCount;
        asalOlmayanSayilarAverage = asalOlmayanSayilarToplam / asalOlmayanSayilarCount;
        Console.WriteLine("Asal Olan Listenin Eleman Sayısı: {0} Toplamı: {1} Ortalaması: {2}", asalSayilarCount.ToString(), asalSayilarToplam, asalSayilarAverage.ToString());
        Console.WriteLine("Asal Olmayan Listenin Eleman Sayısı: {0} Toplamı: {1} Ortalaması: {2}", asalOlmayanSayilarCount.ToString(), asalOlmayanSayilarToplam, asalOlmayanSayilarAverage.ToString());

        // 2. Soru: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan
        // ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

        Console.WriteLine("2. Soruya Hoşgeldiniz...");
        int[] sayilar = new int[5];
        int[] kb = new int[5];
        int[] bk = new int[5];
        int fark = 0;
        int kToplam = 0;
        int kAverage = 0;
        int bToplam = 0;
        int bAverage = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("{0}. Sayı Giriniz: ", i + 1);
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Array.Sort(sayilar);
        kb = sayilar;
        fark = kb.Count() - 3;
        Console.Write("Küçükten Büyüğe: ");
        for (int i = 0; i < kb.Count() - fark; i++)
        {
            Console.Write(kb[i] + " ");
            kToplam += kb[i];
        }
        Console.WriteLine();
        Array.Reverse(sayilar);
        bk = sayilar;
        fark = bk.Count() - 3;
        Console.Write("Büyükten Küçüğe: ");
        for (int i = 0; i < bk.Count() - fark; i++)
        {
            Console.Write(bk[i] + " ");
            bToplam += bk[i];
        }
        Console.WriteLine();
        kAverage = kToplam / 3;
        bAverage = bToplam / 3;
        Console.WriteLine("Küçükten Büyüğe Sayıların Toplamı: {0} Ortalaması: {1}", kToplam.ToString(), kAverage.ToString());
        Console.WriteLine("Büyükten Küçüğe Sayıların Toplamı: {0} Ortalaması: {1}", bToplam.ToString(), bAverage.ToString());


        // Soru 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

        Console.WriteLine("3. Soruya Hoşgeldiniz...");
        Console.Write("Lütfen Bir Cümle Giriniz: ");
        string cumle = Console.ReadLine();
        int count = cumle.Length;
        char[] sesliharfler = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
        char[] kelimeler = cumle.ToCharArray();
        ArrayList cumleSesliHarfler = new ArrayList();
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < sesliharfler.Length; j++)
            {
                if (kelimeler[i] == sesliharfler[j])
                {
                    cumleSesliHarfler.Add(sesliharfler[j]);
                    break;
                }
            }
        }
        cumleSesliHarfler.Sort();
        Console.Write("Cümledeki Sesli Harfler: ");
        foreach (char item in cumleSesliHarfler)
        {
            Console.Write(item + " ");
        }
    }
}
