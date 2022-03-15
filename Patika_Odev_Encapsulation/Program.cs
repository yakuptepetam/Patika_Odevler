internal class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim = "Yakup";
        ogrenci.Soyisim = "Tepetam";
        ogrenci.OgrenciNo = 18290674;
        ogrenci.Sinif = 3;
        ogrenci.OgrenciBilgileriniGetir();
        ogrenci.SınıfAtlat();
        ogrenci.OgrenciBilgileriniGetir();

        Ogrenci ogrenci2 = new Ogrenci("Fırat", "Günayer", 547, 1);
        ogrenci2.OgrenciBilgileriniGetir();
        ogrenci2.SınıfDusur();
        ogrenci2.OgrenciBilgileriniGetir();

    }
}
class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif { get => sinif; set { if (value < 1) { Console.WriteLine("Sınıf En Az 1 Olmalıdır."); sinif = 1; } else { sinif = value; } } }

    public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = ısim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public Ogrenci() { }

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("******** Ogrenci Bilgileri **********");
        Console.WriteLine("Öğrenci Adı: {0}", this.Isim);
        Console.WriteLine("Öğrenci Soyadı: {0}", this.Soyisim);
        Console.WriteLine("Öğrenci Numarası: {0}", this.OgrenciNo);
        Console.WriteLine("Öğrenci Sınıfı: {0}", this.Sinif);
    }

    public void SınıfAtlat()
    {
        this.Sinif += 1;
    }
    public void SınıfDusur()
    {
        this.Sinif -= 1;
    }

}