class Program
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Where(x => x.Length % 2 == 0)
            .ToArray();

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}