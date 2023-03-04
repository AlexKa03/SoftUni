class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

        int end = numbers.Count / 2;

        for (int i = 0; i < end; i++)
        {
            numbers[i] += numbers[numbers.Count - 1];
            numbers.Remove(numbers[numbers.Count - 1]);
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}