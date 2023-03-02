class Program
{
    static void Main()
    {
        {
            int source = int.Parse(Console.ReadLine());

            int total = 0;
            int counter = 0;

            for (int i = source; i >= 100; i -= 10)
            {
                total += i - 26;
                counter++;
            }

            if (counter > 0)
            {
                total -= 26;
            }

            Console.WriteLine(counter);
            Console.WriteLine(total);
        }
    }
}