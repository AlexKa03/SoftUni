class Program
{
    static void Main()
    {
        {
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i <= 96 + n; i++)
            {
                for (char j = 'a'; j <= 96 + n; j++)
                {
                    for (char k = 'a'; k <= 96 + n; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}

