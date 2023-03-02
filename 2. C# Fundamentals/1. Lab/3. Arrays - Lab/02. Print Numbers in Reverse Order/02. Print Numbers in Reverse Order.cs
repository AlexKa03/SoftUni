class Program
{
    static void Main()
    {
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i <= n - 1; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                Console.Write(numbers[(numbers.Length - 1) - i] + " ");
            }
        }
    }
}