class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        for (int row = 0; row <= size; row++)
        {
            Console.Write(new string(' ', size - row));
            Console.Write(new string('*', row));
            Console.Write(" | ");
            Console.Write(new string('*', row));
            Console.WriteLine(new string(' ', size - row));
        }
    }
}