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

        bool isChanged = false;

        while (command[0] != "end")
        {
            int number = 0;
            string condition = string.Empty;

            switch (command[0])
            {
                case "Add":
                    numbers.Add(int.Parse(command[1]));
                    isChanged = true;
                    break;

                case "Remove":
                    numbers.Remove(int.Parse(command[1]));
                    isChanged = true;
                    break;

                case "RemoveAt":
                    numbers.RemoveAt(int.Parse(command[1]));
                    isChanged = true;
                    break;

                case "Insert":
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    isChanged = true;
                    break;

                case "Contains":
                    Console.WriteLine(numbers.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
                    break;

                case "PrintEven":
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                    break;

                case "PrintOdd":
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 1)));
                    break;

                case "GetSum":
                    Console.WriteLine(numbers.Sum());
                    break;

                case "Filter":
                    condition = command[1];
                    number = int.Parse(command[2]);

                    switch (condition)
                    {
                        case "<":
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n < number)));
                            break;

                        case ">":
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n > number)));
                            break;

                        case "<=":
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n <= number)));
                            break;

                        case ">=":
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n >= number)));
                            break;
                    }
                    break;
            }

            command = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        }

        if (isChanged)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}