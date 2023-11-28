class Program
{
    static void Main(string[] args)
    {
        char[] symbols = Console.ReadLine()
            .ToCharArray();

        SortedDictionary<char, int> symbolsCounter = new SortedDictionary<char, int>();

        foreach (char symbol in symbols)
        {
            if (!symbolsCounter.ContainsKey(symbol))
            {
                symbolsCounter.Add(symbol, 0);
            }

            symbolsCounter[symbol]++;
        }

        foreach (var (symbol, times) in symbolsCounter)
        {
            Console.WriteLine($"{symbol}: {times} time/s");
        }
    }
}