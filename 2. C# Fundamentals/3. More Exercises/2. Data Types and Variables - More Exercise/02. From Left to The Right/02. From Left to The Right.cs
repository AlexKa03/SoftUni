class Program
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        for (int i = 1; i <= lines; i++)
        {
            string[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            long numberOne = long.Parse(numbers[0]);
            long numberTwo = long.Parse(numbers[1]);

            int sum = 0;

            if (numberOne > numberTwo)
            {
                while (numberOne != 0)
                {
                    sum += (int)(numberOne % 10);
                    numberOne /= 10;
                }

                Console.WriteLine(Math.Abs(sum));
            }
            else
            {
                while (numberTwo != 0)
                {
                    sum += (int)(numberTwo % 10);
                    numberTwo /= 10;
                }

                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}