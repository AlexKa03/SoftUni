using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int number = 1; number <= n; number++)
        {
            int sumOfDigits = 0;
            int digits = number;

            while (digits > 0)
            {
                sumOfDigits += digits % 10;
                digits = digits / 10;
            }

            bool isSpecial = (sumOfDigits == 5) ||
                       (sumOfDigits == 7) ||
                       (sumOfDigits == 11);

            Console.WriteLine($"{number} -> {isSpecial}");
        }
    }
}
