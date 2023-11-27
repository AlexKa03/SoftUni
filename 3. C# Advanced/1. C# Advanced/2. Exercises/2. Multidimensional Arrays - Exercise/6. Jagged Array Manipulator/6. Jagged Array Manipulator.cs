class Program
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());

        double[][] jaggedMatrix = new double[rows][];

        for (int i = 0; i < rows; i++)
        {
            int[] row = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            jaggedMatrix[i] = new double[row.Length];

            for (int j = 0; j < row.Length; j++)
            {
                jaggedMatrix[i][j] = row[j];
            }
        }

        for (int row = 0; row < rows - 1; row++)
        {
            if (jaggedMatrix[row].Length == jaggedMatrix[row + 1].Length)
            {
                for (int rowCurrent = row; rowCurrent <= row + 1; rowCurrent++)
                {
                    for (int col = 0; col < jaggedMatrix[rowCurrent].Length; col++)
                    {
                        jaggedMatrix[rowCurrent][col] = jaggedMatrix[rowCurrent][col] * 2;
                    }
                }
            }
            else
            {
                for (int rowCurrent = row; rowCurrent <= row + 1; rowCurrent++)
                {
                    for (int col = 0; col < jaggedMatrix[rowCurrent].Length; col++)
                    {
                        jaggedMatrix[rowCurrent][col] = jaggedMatrix[rowCurrent][col] / 2;
                    }
                }
            }
        }

        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] cmd = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (cmd.Length == 4)
            {
                int row = int.Parse(cmd[1]);
                int col = int.Parse(cmd[2]);
                int value = int.Parse(cmd[3]);

                if (cmd[0] == "Add" && row < rows && row >= 0 && col >= 0 && col < jaggedMatrix[row].Length)
                {
                    jaggedMatrix[row][col] += value;
                }
                else if (cmd[0] == "Subtract" && row < rows && row >= 0 && col >= 0 && col < jaggedMatrix[row].Length)
                {
                    jaggedMatrix[row][col] -= value;
                }
            }

            input = Console.ReadLine();
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < jaggedMatrix[row].Length; col++)
            {
                Console.Write($"{jaggedMatrix[row][col]} ");
            }
            Console.WriteLine();
        }
    }
}