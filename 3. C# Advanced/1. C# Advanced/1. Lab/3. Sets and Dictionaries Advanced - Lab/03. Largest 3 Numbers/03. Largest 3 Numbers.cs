class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        int[] largestNumbers = numbers.OrderByDescending(x => x)
            .Take(3)
            .ToArray();

        Console.WriteLine(string.Join(" ", largestNumbers));
    }
}