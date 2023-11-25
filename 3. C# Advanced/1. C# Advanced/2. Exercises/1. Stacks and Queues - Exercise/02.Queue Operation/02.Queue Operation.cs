class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int numbersDeque = input[1];
        int numbersLookFor = input[2];

        Queue<int> numbers = new Queue<int>(
            Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse));

        for (int i = 0; i < numbersDeque; i++)
        {
            numbers.Dequeue();
        }

        if (numbers.Contains(numbersLookFor))
        {
            Console.WriteLine("true");
        }
        else
        {
            if (numbers.Any())
            {
                Console.WriteLine(numbers.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}