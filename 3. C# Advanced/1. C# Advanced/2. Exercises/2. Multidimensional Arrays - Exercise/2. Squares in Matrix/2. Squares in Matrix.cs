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

        char[,] matrix = new char[rows, cols];

        int counter = 0;

        for (int i = 0; i < rows; i++)
        {
            char[] row = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(char.Parse)
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
                char leftTop = matrix[i, j];
                char rightTop = matrix[i, j + 1];
                char leftBottom = matrix[i + 1, j];
                char rightBottom = matrix[i + 1, j + 1];

                if (leftTop == leftBottom && rightTop == rightBottom && leftTop == rightTop)
                {
                    counter++;
                }
            }
        }

        Console.WriteLine(counter);
    }
}