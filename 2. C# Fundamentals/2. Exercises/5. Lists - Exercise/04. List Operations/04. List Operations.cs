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
            int number = 0;
            int index = 0;
            string position = string.Empty;

            switch (command[0].ToUpper())
            {
                case "ADD":
                    number = int.Parse(command[1]);

                    numbers.Add(number);
                    break;

                case "INSERT":
                    index = int.Parse(command[2]);

                    if (index < numbers.Count && index >= 0)
                    {
                        number = int.Parse(command[1]);

                        numbers.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;

                case "REMOVE":
                    index = int.Parse(command[1]);

                    if (index < numbers.Count && index >= 0)
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;

                case "SHIFT":
                    position = command[1];
                    number = int.Parse(command[2]);

                    if (position == "left")
                    {
                        for (int i = 1; i <= number; i++)
                        {
                            int num = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(num);
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= number; i++)
                        {
                            int num = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, num);
                        }
                    }
                    break;
            }

            command = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}