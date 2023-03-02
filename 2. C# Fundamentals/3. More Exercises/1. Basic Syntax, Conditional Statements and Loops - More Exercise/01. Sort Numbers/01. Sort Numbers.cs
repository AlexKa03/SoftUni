using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.MinValue;
            int numTwo = int.MinValue;
            int numThree = int.MinValue;

            for (int i = 1; i <= 3; i++)
            {
                int numberToCheck = int.Parse(Console.ReadLine());

                if (numberToCheck > numOne)
                {
                    numThree = numTwo;
                    numTwo = numOne;
                    numOne = numberToCheck;
                }
                else if (numberToCheck > numTwo)
                {
                    numThree = numTwo;
                    numTwo = numberToCheck;
                }
                else if (numberToCheck > numThree)
                {
                    numThree = numberToCheck;
                }
            }

            /*
            Console.WriteLine(numOne);
            Console.WriteLine(numTwo);
            Console.WriteLine(numThree);

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int largest = Math.Max(Math.Max(num1, num2), num3);
            int smallest = Math.Min(Math.Min(num1, num2), num3);
            int middle = (num1 + num2 + num3) - (largest + smallest);

            Console.WriteLine(largest);
            Console.WriteLine(middle);
            Console.WriteLine(smallest);
            */
        }
    }
}
