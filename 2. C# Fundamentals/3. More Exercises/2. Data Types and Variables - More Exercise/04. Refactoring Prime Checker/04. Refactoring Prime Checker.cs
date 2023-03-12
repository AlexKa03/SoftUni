class Program
{
    static void Main(string[] args)
    {
        int endIndex = int.Parse(Console.ReadLine());

        for (int number = 2; number <= endIndex; number++)
        {
            string isPrime = "true";

            for (int numberCheck = 2; numberCheck < number; numberCheck++)
            {
                if (number % numberCheck == 0)
                {
                    isPrime = "false";
                    break;
                }
            }

            Console.WriteLine($"{number} -> {isPrime}");
        }

    }
}