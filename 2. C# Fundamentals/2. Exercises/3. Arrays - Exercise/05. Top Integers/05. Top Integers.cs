class Program
{
    static void Main()
    {
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write($"{array[i]} ");
                }
                else if (array[i] > array[i + 1])
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
