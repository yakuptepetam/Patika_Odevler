using System.Collections;

internal class Program
{
    static void Main(string[] args)
    {
        ArrayList liste = new ArrayList();
        liste.Add("Yakup");
        liste.Add(24);

        //Liste içerisindeki elemanlara erişim
        Console.WriteLine(liste[1]);

        foreach (var i in liste)
        {
            Console.WriteLine(i);
        }

        //AddRange
        string[] renkler = { "Siyah", "Beyaz", "Kırmızı" };
        List<int> sayilar = new List<int> { 3, 45, 23, 132, 534 };
        liste.AddRange(renkler);
        liste.AddRange(sayilar);

        foreach (var i in liste)
        {
            Console.WriteLine(i);
        }
        liste.Clear();
        liste.AddRange(sayilar);
        //Sort
        liste.Sort();

        foreach (var i in liste)
        {
            Console.WriteLine(i);
        }

        //Binary Search
        Console.WriteLine(liste.BinarySearch(14));

        //Reverse
        liste.Reverse();
        foreach (var i in liste)
        {
            Console.WriteLine(i);
        }

        //Clear
        liste.Clear();
    }
}