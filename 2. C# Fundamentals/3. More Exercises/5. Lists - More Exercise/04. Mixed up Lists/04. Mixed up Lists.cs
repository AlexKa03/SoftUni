class Program
{
    static void Main(string[] args)
    {
        List<int> lineOne = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        List<int> lineTwo = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        List<int> combined = new List<int>();

        int lastIndex = Math.Min(lineOne.Count, lineTwo.Count);

        lineTwo.Reverse();

        for (int i = 0; i < lastIndex; i++)
        {
            combined.Add(lineOne[i]);
            combined.Add(lineTwo[i]);
        }

        combined.Sort();

        int smallestBorder = 1;
        int biggestBorder = 1;

        if (lineOne.Count > lineTwo.Count)
        {
            smallestBorder = Math.Min(lineOne[lineOne.Count - 1], lineOne[lineOne.Count - 2]);
            biggestBorder = Math.Max(lineOne[lineOne.Count - 1], lineOne[lineOne.Count - 2]);
        }
        else
        {
            smallestBorder = Math.Min(lineTwo[lineTwo.Count - 1], lineTwo[lineTwo.Count - 2]);
            biggestBorder = Math.Max(lineTwo[lineTwo.Count - 1], lineTwo[lineTwo.Count - 2]);
        }

        List<int> result = combined
            .Where(x => x > smallestBorder && x < biggestBorder)
            .ToList();

        foreach (var number in result)
        {
            Console.Write($"{number} ");
        }
    }
}