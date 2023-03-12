class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        string[] command = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        while (command[0].ToUpper() != "END")
        {
            int element = int.Parse(command[1]);

            if (command[0].ToUpper() == "DELETE")
            {
                numbers.RemoveAll(x => x== element);
            }
            else if (command[0].ToUpper() == "INSERT")
            {
                int index = int.Parse(command[2]);

                numbers.Insert(index, element);
            }

            command = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}