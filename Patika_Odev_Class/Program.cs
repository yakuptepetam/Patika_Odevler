internal class Program
{
    static void Main(string[] args)
    {
        Calisan calisan1 = new Calisan();
        calisan1.Ad = "Yakup";
        calisan1.Soyad = "Tepetam";
        calisan1.No = 555;
        calisan1.Departman = "Yazılım";
        calisan1.CalisanBilgileri();

        Console.WriteLine("*********");

        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Fırat";
        calisan2.Soyad = "Günayer";
        calisan2.No = 540;
        calisan2.Departman = "Gazeteci";
        calisan2.CalisanBilgileri();
    }
}
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı: {0},", Ad);
        Console.WriteLine("Çalışan Soyadı: {0},", Soyad);
        Console.WriteLine("Çalışan Numarası: {0},", No);
        Console.WriteLine("Çalışan Departmanı: {0},", Departman);
    }
}