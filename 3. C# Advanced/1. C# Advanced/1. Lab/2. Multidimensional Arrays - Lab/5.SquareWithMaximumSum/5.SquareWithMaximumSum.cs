class Program
{
    static void Main(string[] args)
    {
        int[] size = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int rows = size[0];
        int cols = size[1];

        int bigestSum = 0;
        int[] cords = new int[2];

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            int[] row = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = row[j];
            }
        }

        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                int sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                if (sum > bigestSum)
                {
                    bigestSum = sum;

                    cords[0] = i;
                    cords[1] = j;
                }
            }
        }

        Console.WriteLine($"{matrix[cords[0], cords[1]]} {matrix[cords[0], cords[1] + 1]}\n{matrix[cords[0] + 1, cords[1]]} {matrix[cords[0] + 1, cords[1] + 1]}");
        Console.WriteLine(bigestSum);
    }
}