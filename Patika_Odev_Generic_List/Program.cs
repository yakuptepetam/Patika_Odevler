internal class Program
{
    static void Main(string[] args)
    {
        //List<T>
        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(12);
        sayiListesi.Add(3);
        sayiListesi.Add(36);
        sayiListesi.Add(27);

        List<string> renkListesi = new List<string>();
        renkListesi.Add("Siyah");
        renkListesi.Add("Beyaz");
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Turuncu");

        //Count
        Console.WriteLine(sayiListesi.Count);
        Console.WriteLine(renkListesi.Count);

        //Foreach ve List.Foreach Elemanlara Erişim
        foreach (var item in sayiListesi)
        {
            Console.WriteLine(item);
        }

        foreach (var item in renkListesi)
        {
            Console.WriteLine(item);
        }

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

        //Listeden Eleman Çıkarma
        sayiListesi.Remove(27);
        renkListesi.Remove("Turuncu");

        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(0);

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(item => Console.WriteLine(item));

        //Liste İçerisinde Arama
        if (sayiListesi.Contains(15))
        {
            Console.WriteLine("Eleman bulundu");
        }

        //Eleman ile İndex'e Erişme
        Console.WriteLine(renkListesi.BinarySearch("Yeşil"));

        string[] hayvan = { "Kedi", "Köpek", "Kuş" };
        List<string> havyanListesi = new List<string>(hayvan);

        //Listeyi Temizleme
        havyanListesi.Clear();

        //Liste İçerisinde Nesne Tutma
        List<Kullanicilar> kullanici = new List<Kullanicilar>();
        Kullanicilar kullanici1 = new Kullanicilar();
        kullanici1.Isim = "Yakup";
        kullanici1.Soyisim = "Tepetam";
        kullanici1.Yas = 24;
        Kullanicilar kullanici2 = new Kullanicilar();
        kullanici2.Isim = "Mehmet";
        kullanici2.Soyisim = "Tatil";
        kullanici2.Yas = 23;

        kullanici.Add(kullanici1);
        kullanici.Add(kullanici2);

        List<Kullanicilar> yeniListe = new List<Kullanicilar>();
        yeniListe.Add(new Kullanicilar()
        {
            Isim = "Fırat",
            Soyisim = "Günayer",
            Yas = 35
        });

        foreach (var item in yeniListe)
        {
            Console.WriteLine(item.Isim);
        }

    }
}
class Kullanicilar
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}