class Program
{
    static void Main(string[] args)
    {
        int times = int.Parse(Console.ReadLine());

        Dictionary<int, int> counter = new Dictionary<int, int>();

        for (int i = 0; i < times; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (!counter.ContainsKey(number))
            {
                counter.Add(number, 0);
            }

            counter[number]++;
        }

        foreach (var (number, repeated) in counter)
        {
            if (repeated % 2 == 0)
            {
                Console.WriteLine(number);

                break;
            }
        }
    }
}