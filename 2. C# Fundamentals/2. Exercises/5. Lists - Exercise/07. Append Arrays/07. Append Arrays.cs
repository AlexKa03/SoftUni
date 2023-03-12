class Program
{
    static void Main(string[] args)
    {
        List<string> numbersString = Console.ReadLine()
            .Split("|", StringSplitOptions.RemoveEmptyEntries)
            .Reverse()
            .ToList();

        List<int> numbers = new List<int>();

        foreach (string str in numbersString)
        {
            numbers.AddRange(str
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}