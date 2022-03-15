internal class Program
{
    static void Main(string[] args)
    {
        Calisan calisan1 = new Calisan("Yakup", "Tepetam", 546, "Yazılım");
        calisan1.CalisanYazdir();
        Console.WriteLine("****************");
        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Fırat";
        calisan2.Soyad = "Günayer";
        calisan2.No = 747;
        calisan2.Departman = "Gazeteci";
        calisan2.CalisanYazdir();
        Console.WriteLine("****************");
        Calisan calisan3 = new Calisan("Mehmet", "Tatil",547,"Otel");
        calisan3.CalisanYazdir();
    }
}
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }
    public Calisan() { }
    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }
    public void CalisanYazdir()
    {
        Console.WriteLine("Çalışan Adı: {0}", Ad);
        Console.WriteLine("Çalışan Soyadıdı: {0}", Soyad);
        Console.WriteLine("Çalışan Numarası: {0}", No);
        Console.WriteLine("Çalışan Departmanı: {0}", Departman);
    }
}