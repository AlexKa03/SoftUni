class Program
{
    static void Main(string[] args)
    {
        Stack<int> stackOfNmbers = new Stack<int>
            (Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray());

        string command = Console.ReadLine().ToLower();

        while (command != "end")
        {
            string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (commandInfo[0] == "add")
            {
                int[] numbers = commandInfo
                            .Skip(1)
                            .Select(int.Parse)
                            .ToArray();

                foreach (int number in numbers)
                {
                    stackOfNmbers.Push(number);
                }
            }
            else if (commandInfo[0] == "remove")
            {
                int number = int.Parse(commandInfo[1]);

                while (number > 0 && number <= stackOfNmbers.Count())
                {
                    stackOfNmbers.Pop();
                    number--;
                }
            }

            command = Console.ReadLine().ToLower();
        }

        Console.WriteLine($"Sum: {stackOfNmbers.Sum()}");
    }
}