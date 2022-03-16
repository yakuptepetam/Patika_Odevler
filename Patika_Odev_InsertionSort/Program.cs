internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insertion Sort Ödevi");
        Console.WriteLine();
        Console.WriteLine("Dizi: [22,27,16,2,18,6]");
        Console.WriteLine();
        Console.WriteLine("1. Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.");
        Console.WriteLine();
        Console.WriteLine("1. Adım: [2,27,16,22,18,6]");
        Console.WriteLine("2. Adım: [2,6,16,22,18,27]");
        Console.WriteLine("3. Adım: [2,6,16,22,18,27]");
        Console.WriteLine("4. Adım: [2,6,16,18,22,27]");
        Console.WriteLine("5. Adım: [2,6,16,18,22,27]");
        Console.WriteLine();
        Console.WriteLine("2. Big-O gösterimini yazınız.");
        Console.WriteLine();
        Console.WriteLine("O(n^2)");
        Console.WriteLine();
        Console.WriteLine("3. Time Complexity: Average case: Aradığımız sayının ortada olması,Worst case: Aradığımız sayının sonda olması, Best case: Aradığımız sayının dizinin en başında olması.");
        Console.WriteLine();
        Console.WriteLine("Average case: O(n^2)");
        Console.WriteLine("Worst case: O(n^2)");
        Console.WriteLine("Best case: O(n)");
        Console.WriteLine();
        Console.WriteLine("4. Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer? Yazınız.");
        Console.WriteLine();
        Console.WriteLine("Average case");
        Console.WriteLine();
        Console.WriteLine("[7,3,5,8,2,9,4,15,6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.");
        Console.WriteLine();
        Console.WriteLine("1. Adım: [2,3,5,8,7,9,4,15,6]");
        Console.WriteLine("2. Adım: [2,3,5,8,7,9,4,15,6]");
        Console.WriteLine("3. Adım: [2,3,4,8,7,9,5,15,6]");
        Console.WriteLine("4. Adım: [2,3,4,5,7,9,8,15,6]");
    }
}