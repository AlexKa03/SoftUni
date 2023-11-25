class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int[,] matrix = new int[size, size];
        int diagonalSum = 0;

        for (int i = 0; i < size; i++)
        {
            int[] row = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = row[j];

                if (i == j)
                {
                    diagonalSum += matrix[i, j];
                }
            }
        }

        Console.WriteLine(diagonalSum);
    }
}