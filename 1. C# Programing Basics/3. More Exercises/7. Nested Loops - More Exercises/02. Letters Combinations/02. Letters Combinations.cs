class Program
{
    static void Main(string[] args)
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char lastLetter = char.Parse(Console.ReadLine());
        char skipLetter = char.Parse(Console.ReadLine());

        int count = 0;

        for (char i = firstLetter; i <= lastLetter; i++)
        {
            if (i != skipLetter)
            {
                for (char j = firstLetter; j <= lastLetter; j++)
                {
                    if (j != skipLetter)
                    {
                        for (char k = firstLetter; k <= lastLetter; k++)
                        {
                            if (k != skipLetter)
                            {
                                Console.Write($"{i}{j}{k} ");
                                count++;
                            }
                        }
                    }
                }
            }
        }

        Console.Write(count);
    }
}