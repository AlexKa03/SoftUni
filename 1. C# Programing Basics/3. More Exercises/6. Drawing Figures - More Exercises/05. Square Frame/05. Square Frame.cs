class program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if ((i == 0 & j == 0) |
                    (i == 0 & j == size - 1) |
                    (i == size - 1 & j == 0) |
                    (i == size - 1 & j == size - 1))
                {
                    Console.Write("+ ");
                }
                else if (j == 0 | j == size - 1)
                {
                    Console.Write("| ");
                }
                else
                {
                    Console.Write("- ");
                }
            }

            Console.WriteLine();
        }
    }
}