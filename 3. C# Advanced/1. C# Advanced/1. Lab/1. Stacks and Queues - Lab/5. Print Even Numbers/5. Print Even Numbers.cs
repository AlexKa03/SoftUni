class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Queue<int> numberQueue = new Queue<int>(input);

        int count = numberQueue.Count;

        for (int i = 0; i < count; i++)
        {
            int currentNumber = numberQueue.Dequeue();

            if (currentNumber % 2 == 0)
            {
                numberQueue.Enqueue(currentNumber);
            }
        }

        Console.WriteLine(string.Join(", ", numberQueue));
    }
}