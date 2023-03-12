class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        int[] bombPower = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == bombPower[0])
            {
                for (int j = 1; j <= bombPower[1]; j++)
                {
                    if (i - j < 0)
                    {
                        break;
                    }
                    else
                    {
                        numbers[i - j] = 0;
                    }
                }

                for (int j = 1; j <= bombPower[1]; j++)
                {
                    if (i + j > numbers.Count - 1)
                    {
                        break;
                    }
                    else
                    {
                        numbers[i + j] = 0;
                    }
                }

                numbers[i] = 0;
            }
        }

        Console.WriteLine(numbers.Sum());
    }
}