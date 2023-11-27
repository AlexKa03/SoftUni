class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int[,] matrix = new int[size, size];

        int sumPrimary = 0;
        int sumSecondary = 0;

        int rowCounter = 0;

        for (int i = 0; i < size; i++)
        {
            int[] row = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            for (int j = 0; j < row.Length; j++)
            {
                matrix[i, j] = row[j];

                if (i == j)
                {
                    sumPrimary += matrix[i, j];
                }

                if (i == rowCounter && j == size - 1 - i)
                {
                    sumSecondary += matrix[i, j];
                }
            }

            rowCounter++;
        }

        Console.WriteLine(Math.Abs(sumPrimary - sumSecondary));
    }
}