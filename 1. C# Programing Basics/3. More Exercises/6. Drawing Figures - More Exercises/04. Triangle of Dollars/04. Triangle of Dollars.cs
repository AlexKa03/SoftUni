class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                Console.Write("$ ");
            }

            Console.WriteLine();
        }
    }
}