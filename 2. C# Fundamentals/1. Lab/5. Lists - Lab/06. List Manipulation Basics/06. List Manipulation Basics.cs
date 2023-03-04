class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        string[] command = Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        while (command[0] != "end")
        {
            int number = 0;
            int index = 0;

            if (command[0] == "Add")
            {
                number = int.Parse(command[1]);

                numbers.Add(number);
            }
            else if (command[0] == "Remove")
            {
                number = int.Parse(command[1]);

                numbers.Remove(number);
            }
            else if (command[0] == "RemoveAt")
            {
                index = int.Parse(command[1]);

                numbers.RemoveAt(index);
            }
            else if (command[0] == "Insert")
            {
                number = int.Parse(command[1]);
                index = int.Parse(command[2]);

                numbers.Insert(index, number);
            }

            command = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}