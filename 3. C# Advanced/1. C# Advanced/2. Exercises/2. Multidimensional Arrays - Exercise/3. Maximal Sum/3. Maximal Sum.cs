class Program
{
    static void Main(string[] args)
    {
        int[] size = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToArray();

        int rows = size[0];
        int cols = size[1];

        int[,] matrix = new int[rows, cols];

        int x = 0;
        int y = 0;
        int biggestSum = int.MinValue;

        for (int i = 0; i < rows; i++)
        {
            int[] row = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = row[j];
            }
        }

        for (int i = 0; i < rows - 2; i++)
        {
            for (int j = 0; j < cols - 2; j++)
            {
                int leftTop = matrix[i, j];
                int centerTop = matrix[i, j + 1];
                int rightTop = matrix[i, j + 2];

                int leftMid = matrix[i + 1, j];
                int centerMid = matrix[i + 1, j + 1];
                int rightMid = matrix[i + 1, j + 2];

                int leftBottom = matrix[i + 2, j];
                int centerBottom = matrix[i + 2, j + 1];
                int rightBottom = matrix[i + 2, j + 2];

                int sum = leftTop + centerTop + rightTop + leftMid + centerMid + rightMid + leftBottom + centerBottom + rightBottom;

                if (sum > biggestSum)
                {
                    biggestSum = sum;

                    x = i;
                    y = j;
                }
            }
        }

        Console.WriteLine($"Sum = {biggestSum}");
        Console.WriteLine($"{matrix[x, y]} {matrix[x, y + 1]} {matrix[x, y + 2]}\n{matrix[x + 1, y]} {matrix[x + 1, y + 1]} {matrix[x + 1, y + 2]}\n{matrix[x + 2, y]} {matrix[x + 2, y + 1]} {matrix[x + 2, y + 2]}");
    }
}