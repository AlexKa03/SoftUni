class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        PrintTriangle(number);
    }

    static void PrintTriangle(int number)
    {
        for (int lineUp = 1; lineUp <= number; lineUp++)
        {
            PrintLine(1, lineUp);
        }
        for (int lineDown = number - 1; lineDown >= 1; lineDown--)
        {
            PrintLine(1, lineDown);
        }
    }

    static void PrintLine (int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write("{0} ", i);
        }

        Console.WriteLine();
    }
}