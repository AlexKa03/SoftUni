class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] board = new char[n, n];
        int gamblerAmount = 100;
        (int, int) gamblerPosition = (-1, -1);

        for (int i = 0; i < n; i++)
        {
            string row = Console.ReadLine();
            for (int j = 0; j < n; j++)
            {
                board[i, j] = row[j];
                if (board[i, j] == 'G')
                {
                    gamblerPosition = (i, j);
                }
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            MoveGambler(ref board, ref gamblerPosition, ref gamblerAmount, command, n);
            if (gamblerAmount <= 0)
            {
                Console.WriteLine("Game over! You lost everything!");
                return;
            }
            if (board[gamblerPosition.Item1, gamblerPosition.Item2] == 'J')
            {
                Console.WriteLine("You win the Jackpot!\nEnd of the game. Total amount: {0}$", gamblerAmount);
                return;
            }
        }

        Console.WriteLine("End of the game. Total amount: {0}$", gamblerAmount);
        PrintBoard(board, n);
    }

    static void MoveGambler(ref char[,] board, ref (int, int) position, ref int amount, string direction, int n)
    {
        board[position.Item1, position.Item2] = '-';
        switch (direction)
        {
            case "up":
                position.Item1--;
                break;
            case "down":
                position.Item1++;
                break;
            case "left":
                position.Item2--;
                break;
            case "right":
                position.Item2++;
                break;
        }

        if (position.Item1 < 0 || position.Item1 >= n || position.Item2 < 0 || position.Item2 >= n)
        {
            amount = 0;
            return;
        }

        char cell = board[position.Item1, position.Item2];
        switch (cell)
        {
            case 'W':
                amount += 100;
                break;
            case 'P':
                amount -= 200;
                break;
            case 'J':
                amount += 100000;
                break;
        }
        board[position.Item1, position.Item2] = 'G';
    }

    static void PrintBoard(char[,] board, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(board[i, j]);
            }
            Console.WriteLine();
        }
    }
}