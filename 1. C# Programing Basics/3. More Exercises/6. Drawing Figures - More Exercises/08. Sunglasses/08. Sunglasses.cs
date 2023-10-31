class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));

        for (int row = 1; row <= n - 2; row++)
        {
            Console.Write('*' + new string('/', 2 * n - 2) + '*');

            if (row == (n - 1) / 2)
            {
                Console.Write(new string('|', n));
            }
            else
            {
                Console.Write(new string(' ', n));
            }

            Console.Write('*' + new string('/', 2 * n - 2) + '*');
            Console.WriteLine();
        }

        Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
    }
}