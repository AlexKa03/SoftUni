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

        int[,] matrix = new int[rows, cols];

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

        for (int i = 0;i < cols; i++)
        {
            int sum = 0;

            for (int j = 0;j < rows; j++)
            {
                sum += matrix[j, i];
            }

            Console.WriteLine(sum);
        }
    }
}