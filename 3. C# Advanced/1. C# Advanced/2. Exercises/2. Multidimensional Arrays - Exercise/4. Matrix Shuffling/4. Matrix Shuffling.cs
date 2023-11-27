class Program
{
    static void Invalid()
    {
        Console.WriteLine("Invalid input!");
    }
    static void Main(string[] args)
    {
        int[] size = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToArray();

        int rows = size[0];
        int cols = size[1];

        string[,] matrix = new string[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            string[] row = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = row[j];
            }
        }

        string action = Console.ReadLine();

        while (action != "END")
        {
            string[] cmd = action.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (cmd[0] == "swap" && cmd.Length == 5)
            {
                int x1 = int.Parse(cmd[1]);
                int y1 = int.Parse(cmd[2]);

                int x2 = int.Parse(cmd[3]);
                int y2 = int.Parse(cmd[4]);

                if (x1 < rows && y1 < cols && x2 < rows && y2 < cols)
                {
                    string buffer = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = buffer;

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write($"{matrix[i, j]} ");
                        }

                        Console.WriteLine();
                    }
                }
                else { Invalid(); }
            }
            else { Invalid(); }

            action = Console.ReadLine();
        }
    }
}