class Program
{
    static void Main(string[] args)
    {
        List<int> raceTimes = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        int finishLine = raceTimes.Count / 2;

        double leftTime = LeftRacer(raceTimes, finishLine);
        double rightTime = RightRacer(raceTimes, finishLine);

        string winner = string.Empty;
        double winnerTime = 0;

        if (leftTime > rightTime)
        {
            winner = "right";
            winnerTime = rightTime;
        }
        else
        {
            winner = "left";
            winnerTime = leftTime;
        }

        PrintWinner(winner, winnerTime);
    }

    static void PrintWinner(string winner, double winnerTime)
    {
        if (winnerTime % 1 == 0)
        {
            Console.WriteLine($"The winner is {winner} with total time: {winnerTime}");
        }
        else
        {
            Console.WriteLine($"The winner is {winner} with total time: {winnerTime:f1}");
        }
    }

    static double LeftRacer(List<int> raceTimes, double finishLine)
    {
        double time = 0;

        for (int i = 0; i < finishLine; i++)
        {
            time += raceTimes[i];

            if (raceTimes[i] == 0)
            {
                time *= 0.8;
            }
        }

        return time;
    }

    static double RightRacer(List<int> raceTimes, double finishLine)
    {
        double time = 0;

        for (int i = raceTimes.Count - 1; i > finishLine; i--)
        {
            time += raceTimes[i];

            if (raceTimes[i] == 0)
            {
                time *= 0.8;
            }
        }

        return time;
    }
}