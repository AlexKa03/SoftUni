class Program
{
    static void Main()
    {
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (numbers[i] == 0 || numbers[i] == -0)
                {
                    numbers[i] = 0;
                }
                else
                {
                    numbers[i] = numbers[i];
                }
            }

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}