class Program
{
    static void Main(string[] args)
    {
        Dictionary<double, int> counter = new Dictionary<double, int>();

        double[] input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        for (int i = 0; i < input.Length; i++)
        {
            if (counter.ContainsKey(input[i]))
            {
                counter[input[i]]++;
            }
            else
            {
                counter.Add(input[i], 1);
            }
        }

        foreach (var number in counter)
        {
            Console.WriteLine($"{number.Key} - {number.Value} times");
        }
    }
}