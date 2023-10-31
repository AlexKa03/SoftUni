class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}