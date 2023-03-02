class Program
{
    static void Main()
    {
        char givenChar = char.Parse(Console.ReadLine());

        bool isUpper = true;

        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            if (letter == givenChar)
            {
                Console.WriteLine("lower-case");
                isUpper = false;
                break;
            }
        }

        if (isUpper)
        {
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                if (letter == givenChar)
                {
                    Console.WriteLine("upper-case");
                    break;
                }
            }
        }
    }
}