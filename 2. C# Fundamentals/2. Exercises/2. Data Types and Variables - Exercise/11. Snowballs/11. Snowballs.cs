using System.Numerics;

class Program
{
    static void Main()
    {
        {
            byte snowballs = byte.Parse(Console.ReadLine());

            BigInteger bestValue = 0;

            ushort beestSnow = 0;
            ushort bestTime = 0;
            ushort bestQuality = 0;

            for (int i = 1; i <= snowballs; i++)
            {
                ushort snowballSnow = ushort.Parse(Console.ReadLine());
                ushort snowballTime = ushort.Parse(Console.ReadLine());
                ushort snowballQuality = ushort.Parse(Console.ReadLine());
                /*
                   Well done SoftUni, never presented how BigInteger
                   works and didn't say in the exercise description
                   that we should be looking for something like that :)
                */
                BigInteger value = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (value >= bestValue)
                {
                    bestValue = value;
                    beestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{beestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}