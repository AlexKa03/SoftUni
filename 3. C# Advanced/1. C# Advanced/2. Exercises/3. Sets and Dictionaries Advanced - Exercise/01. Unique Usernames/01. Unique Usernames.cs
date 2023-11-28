class Program
{
    static void Main(string[] args)
    {
        int counter = int.Parse(Console.ReadLine());

        HashSet<string> set = new HashSet<string>();

        for (int i = 0; i < counter; i++)
        {
            set.Add(Console.ReadLine());
        }

        Console.WriteLine(string.Join("\n", set));
    }
}