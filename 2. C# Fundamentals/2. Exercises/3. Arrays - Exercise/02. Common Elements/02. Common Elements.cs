class Program
{
    static void Main()
    {
        {
            string[] arrayOne = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] arrayTwo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < arrayOne.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    if (arrayOne[i] == arrayTwo[j])
                    {
                        Console.Write($"{arrayOne[i]} ");
                    }
                }
            }
        }
    }
}
