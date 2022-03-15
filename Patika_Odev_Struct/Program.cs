internal class Program
{
    static void Main(string[] args)
    {
        Dikdortgen dikdortgen = new Dikdortgen();
        dikdortgen.KisaKenar = 3;
        dikdortgen.UzunKenar = 5;
        Console.WriteLine(dikdortgen.AlanHesapla());

        Dikdortgen_Struct dikdortgen1 = new Dikdortgen_Struct();
        dikdortgen1.KisaKenar = 3;
        dikdortgen1.UzunKenar = 5;
        Console.WriteLine(dikdortgen1.AlanHesapla());

    }
}
class Dikdortgen
{
    public int KisaKenar;
    public int UzunKenar;

    public Dikdortgen()
    {
        KisaKenar = 5;
        UzunKenar = 10;
    }

    public long AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}
struct Dikdortgen_Struct
{
    public int KisaKenar;
    public int UzunKenar;

    public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
    {
        KisaKenar = kisaKenar;
        UzunKenar = uzunKenar;
    }

    public long AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}