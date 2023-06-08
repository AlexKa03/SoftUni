class Program
{
    static void Main(string[] args)
    {
        string symbols = Console.ReadLine();

        Dictionary<char, int> counts = new Dictionary<char, int>();

        foreach (char symbol in symbols)
        {
            if (symbol != ' ')
            {
                if (counts.ContainsKey(symbol))
                {
                    counts[symbol]++;
                }
                else
                {
                    counts.Add(symbol, 1);
                }
            } 
        }

        foreach (var count in counts)
        {
            Console.WriteLine($"{count.Key} -> {count.Value}");
        }
    }
}