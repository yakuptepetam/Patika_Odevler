internal class Program
{
    static void Main(string[] args)
    {
        //Dictionary
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(1, "Yakup");
        dic.Add(2, "Tepetam");

        //Elemanlara Erişim
        foreach (int key in dic.Keys)
        {
            Console.WriteLine(key);
        }

        //Count
        Console.WriteLine(dic.Count);

        //Contains
        Console.WriteLine(dic.ContainsValue("Yakup"));
        Console.WriteLine(dic.ContainsKey(2));

        //Remove
        dic.Remove(2);
    }
}