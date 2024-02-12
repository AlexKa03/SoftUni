class Program
{
    static void Main(string[] args)
    {
        int firstMax = int.Parse(Console.ReadLine());
        int secondMax = int.Parse(Console.ReadLine());
        int thirdMax = int.Parse(Console.ReadLine());

        for (int i = 2; i <= firstMax; i += 2)
        {
            for (int j = 2; j <= secondMax; j++)
            {
                if (j == 2 || j == 3 || j == 5 || j == 7)
                {
                    for (int r = 2; r <= thirdMax; r += 2)
                    {
                        Console.WriteLine($"{i} {j} {r}");
                    }
                }
            }
        }
    }
}