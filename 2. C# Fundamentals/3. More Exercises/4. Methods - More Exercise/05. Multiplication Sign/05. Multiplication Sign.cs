class Program
{
    static void Main(string[] args)
    {
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());
        int numThree = int.Parse(Console.ReadLine());

        int[] numbers = { numOne, numTwo, numThree };

        bool isPsoitive = SignChecker(numOne, numTwo, numThree, numbers);

        if (numbers.All (n => n != 0))
        {
            Printer(isPsoitive);
        }
    }

    static bool SignChecker(int numOne, int numTwo, int numThree, int[] numbers)
    {
        bool isPositive = false;
        int negativeCounter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                negativeCounter++;
            }
            else if (numbers[i] == 0)
            {
                Console.WriteLine("zero");
                break;
            }
            else
            {
                isPositive = true;
            }
        }

        if (negativeCounter == 2)
        {
            isPositive = true;
        }
        else if (negativeCounter % 2 == 1)
        {
            isPositive = false;
        }

        return isPositive;
    }

    static void Printer(bool isPositive)
    {
        if (isPositive)
        {
            Console.WriteLine("positive");
        }
        else
        {
            Console.WriteLine("negative");
        }
    }
}