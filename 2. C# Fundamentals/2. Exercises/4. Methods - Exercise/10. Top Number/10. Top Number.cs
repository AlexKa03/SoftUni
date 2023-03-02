class Program
{
    static void Main(string[] args)
    {
        int endValue = int.Parse(Console.ReadLine());

        TopNumber(endValue);
    }

    static void TopNumber(int end)
    {
        for (int number = 17; number <= end; number++)
        {
            int counter = 0;

            counter = DivisibleSumValidator(number, counter);
            counter = AtLeastOneOddValidator(number, counter);

            if (counter == 2)
            {
                PrintTopNumber(number);
            }
        }
    }

    static int DivisibleSumValidator(int number, int counter)
    {
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        if (sum % 8 == 0)
        {
            counter++;
            return counter;
        }

        return counter;
    }

    static int AtLeastOneOddValidator(int number, int counter)
    {
        while (number > 0)
        {
            int digit = number % 10;

            if (digit % 2 == 1)
            {
                counter++;
                return counter;
            }
            number /= 10;
        }

        return counter;
    }

    static void PrintTopNumber(int number)
    {
        Console.WriteLine(number);
    }
}