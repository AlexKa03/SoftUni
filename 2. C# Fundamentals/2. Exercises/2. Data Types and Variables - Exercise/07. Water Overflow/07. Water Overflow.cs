class Program
{
    static void Main()
    {
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 255;

            for (int i = 1; i <= n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (liters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    capacity -= liters;
                }
            }

            Console.WriteLine(255 - capacity);
        }
    }
}