class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        for (int upperSide = 0; upperSide < size; upperSide++)
        {
            Console.WriteLine(new string(' ', size - 1 - upperSide) +
                              string.Join(" ", new string('*', upperSide + 1).ToCharArray()));
        }

        for (int downSide = size - 2; downSide >= 0; downSide--)
        {
            Console.WriteLine(new string(' ', size - 1 - downSide) +
                              string.Join(" ", new string('*', downSide + 1).ToCharArray()));
        }
    }
}