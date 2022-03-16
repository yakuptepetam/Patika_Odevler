internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Merge Sort Ödevi");
        Console.WriteLine();
        Console.WriteLine("Dizi: [16,21,11,8,12,22]");
        Console.WriteLine();
        Console.WriteLine("1. Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.");
        Console.WriteLine();
        Console.WriteLine("                             [16,21,11,8,12,22]");
        Console.WriteLine(@"                            /                \");
        Console.WriteLine("                   [16,21,11]                 [8,12,22]");
        Console.WriteLine(@"                    /     \                   /     \");
        Console.WriteLine(@"               [16,21]    [11]           [8,12]    [22]");
        Console.WriteLine(@"                /   \      |             /   \      |");
        Console.WriteLine("             [16]   [21]  [11]          [8]   [12]  [22]");
        Console.WriteLine(@"              \    /       |            \    /       |");
        Console.WriteLine(@"               [16,21]    [11]           [8,12]    [22]");
        Console.WriteLine(@"                   \       /                \       /");
        Console.WriteLine(@"                  [11,16,21]                [8,12,22]");
        Console.WriteLine(@"                          \                  /");
        Console.WriteLine("                            [8,11,12,16,21,22]");
        Console.WriteLine();
        Console.WriteLine("2. Big-O gösterimini yazınız.");
        Console.WriteLine();
        Console.WriteLine("O(nlogn)");
    }
}