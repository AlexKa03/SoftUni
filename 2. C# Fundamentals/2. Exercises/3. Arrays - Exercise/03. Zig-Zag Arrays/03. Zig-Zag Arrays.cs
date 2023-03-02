class Program
{
    static void Main()
    {
        {
            int lines = int.Parse(Console.ReadLine());

            int[] arrayOne = new int[lines];
            int[] arrayTwo = new int[lines];

            for (int i = 1; i <= lines; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 1)
                {
                    arrayOne[i - 1] = input[0];
                    arrayTwo[i- 1] = input[1];
                }
                else
                {
                    arrayOne[i - 1] = input[1];
                    arrayTwo[i - 1] = input[0];
                }
            }

            Console.WriteLine(String.Join(" ", arrayOne));
            Console.WriteLine(String.Join(" ", arrayTwo));
        }
    }
}
