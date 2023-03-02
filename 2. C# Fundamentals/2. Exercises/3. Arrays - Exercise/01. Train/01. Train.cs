class Program
{
    static void Main()
    {
        {
            int[] passengers = new int[int.Parse(Console.ReadLine())];

            int sum = 0;

            for (int i = 0; i < passengers.Length; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                sum += passengers[i];
            }

            Console.Write(string.Join(' ', passengers));
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
