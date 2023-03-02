class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        CreateAndPrintMatrix(n);
    }

    static void CreateAndPrintMatrix(int n)
    {
        int[,] matrix = new int[n, n];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j] = n} ");
            }

            Console.WriteLine();
        }
    }
}