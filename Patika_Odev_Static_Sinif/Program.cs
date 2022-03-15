internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

        Calisan calisan1 = new Calisan("Yakup", "Tepetam", "Yazılım");
        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
        Calisan calisan2 = new Calisan("Yakup", "Tepetam", "Yazılım");
        Calisan calisan3 = new Calisan("Yakup", "Tepetam", "Yazılım");
        Calisan calisan4 = new Calisan("Yakup", "Tepetam", "Yazılım");
        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

        Console.WriteLine("Toplama İşlemi Sonucu: {0}", Islemler.Topla(2, 5));
        Console.WriteLine("Çıkarma İşlemi Sonucu: {0}", Islemler.Cikar(12, 5));
    }
}
class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    private string Isim;
    private string Soyisim;
    private string Departman;

    static Calisan()
    {
        calisanSayisi = 0;
    }

    public Calisan(string ısim, string soyisim, string departman)
    {
        Isim = ısim;
        Soyisim = soyisim;
        Departman = departman;
        calisanSayisi++;
    }


}
static class Islemler
{
    public static int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public static int Cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}