class Program
{
    static void Invalid()
    {
        Console.WriteLine("Invalid coordinates");
    }

    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int[][] jaggedMatrix = new int[size][];

        for (int i = 0; i < size; i++)
        {
            int[] row = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            jaggedMatrix[i] = new int[row.Length];

            for (int j = 0; j < row.Length; j++)
            {
                jaggedMatrix[i][j] = row[j];
            }
        }

        string action = Console.ReadLine();

        while (action != "END")
        {
            string[] command = action
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int row = int.Parse(command[1]);
            int col = int.Parse(command[2]);
            int value = int.Parse(command[3]);

            if (row >= 0 && col >= 0)
            {
                if (jaggedMatrix.Length > row && jaggedMatrix[row].Length > col)
                {
                    if (command[0] == "Add")
                    {
                        jaggedMatrix[row][col] += value;
                    }
                    else if (command[0] == "Subtract")
                    {
                        jaggedMatrix[row][col] -= value;
                    }
                    else
                    {
                        Invalid();
                    }
                }
                else
                {
                    Invalid();
                }
            }
            else
            {
                Invalid();
            }

            action = Console.ReadLine();
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < jaggedMatrix[i].Length; j++)
            {
                Console.Write($"{jaggedMatrix[i][j]} ");
            }

            Console.WriteLine();
        }
    }
}