class Program
{
    static void Main(string[] args)
    {
        List<int> listOne = Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        List<int> listTwo = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        List<int> result = new List<int>();

        for (int i = 0; i < Math.Min(listOne.Count, listTwo.Count); i++)
        {
            result.Add(listOne[i]);
            result.Add(listTwo[i]);
        }

        for (int j = Math.Min(listOne.Count, listTwo.Count); j < Math.Max(listOne.Count, listTwo.Count); j++)
        {
            if (j >= listOne.Count)
            {
                result.Add(listTwo[j]);
            }
            else
            {
                result.Add(listOne[j]);
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}