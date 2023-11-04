class Program
{
    static void Main(string[] args)
    {
        string[] inputNames = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        int rotations = int.Parse(Console.ReadLine());

        Queue<string> peopleQueue = new Queue<string>(inputNames);

        while (peopleQueue.Count > 1)
        {
           for (int i = 0; i < rotations - 1; i++)
            {
                peopleQueue.Enqueue(peopleQueue.Dequeue());
            }

           Console.WriteLine($"Removed {peopleQueue.Dequeue()}");
        }

        Console.WriteLine($"Last is {peopleQueue.Peek()}");
    }
}