class Program
{
    static void Main()
    {
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEven += numbers[i];
                }
                else
                {
                    sumOdd+= numbers[i];
                }
            }

            Console.WriteLine(sumEven - sumOdd);
        }
    }
}