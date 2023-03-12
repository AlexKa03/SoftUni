class Program
{
    static void Main(string[] args)
    {
         List<int> train = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        int maxCapacity = int.Parse(Console.ReadLine());

        string[] command = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        while (command[0] != "end")
        {
            int passengers = 0;

            if (command[0] == "Add")
            {
                passengers = int.Parse(command[1]);

                train.Add(passengers);
            }
            else
            {
                passengers = int.Parse(command[0]);

                for (int i = 0; i < train.Count; i++)
                {
                    if (maxCapacity - train[i] >= passengers)
                    {
                        train[i] += passengers;
                        break;
                    }
                }
            }

            command = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        }

        Console.WriteLine(string.Join(" ", train));
    }
}