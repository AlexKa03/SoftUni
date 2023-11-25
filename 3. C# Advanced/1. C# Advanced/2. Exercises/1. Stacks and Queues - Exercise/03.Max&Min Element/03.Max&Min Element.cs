class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Stack<int> elements = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            int[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (command[0] == 1)
            {
                elements.Push(command[1]);
            }
            else if (command[0] == 2)
            {
                if (elements.Any())
                {
                    elements.Pop();
                }
            }
            else if (command[0] == 3)
            {
                if (elements.Any())
                {
                    Console.WriteLine(elements.Max());
                }
            }
            else if (command[0] == 4)
            {
                if (elements.Any())
                {
                    Console.WriteLine(elements.Min());
                }
            }
        }

        Console.WriteLine(string.Join(", ", elements));
    }
}