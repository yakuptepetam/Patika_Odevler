internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Binary Search Tree Ödevi");
        Console.WriteLine();
        Console.WriteLine("Dizi: [7,5,1,8,3,6,0,9,4,2]");
        Console.WriteLine();
        Console.WriteLine("Dizisinin Binary Search Tree aşamalarını yazınız.");
        Console.WriteLine("Örnek: root x'dir. root'un sağından y bulunur. Solunda z bulunur vb.");
        Console.WriteLine("Root: 7");
        Console.WriteLine();
        Console.WriteLine("                              7");
        Console.WriteLine(@"                            / \");
        Console.WriteLine("                            5   8");
        Console.WriteLine(@"                          / \   \");
        Console.WriteLine(@"                         1   6   9");
        Console.WriteLine(@"                        / \");
        Console.WriteLine("                        0   3");
        Console.WriteLine(@"                          / \");
        Console.WriteLine("                          2   4");
    }
}