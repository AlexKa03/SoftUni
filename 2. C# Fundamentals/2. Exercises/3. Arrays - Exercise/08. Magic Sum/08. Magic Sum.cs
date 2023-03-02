class Program
{
    static void Main()
    {
        {
            int[] numbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (j > i)
                    {
                        if (numbers[i] + numbers[j] == sum)
                        {
                            Console.WriteLine($"{numbers[i]} {numbers[j]}");
                        }
                    }
                }
            }
        }
    }
}
