class Program
{
    static void Main(string[] args)
    {
        string[] strings = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string first = strings[0];
        string second = strings[1];

        int longest = int.Max(first.Length, second.Length);
        int shortest = int.Min(first.Length, second.Length);

        int sum = 0;

        for (int i = 0; i < shortest; i++)
        {
            sum += first[i] * second[i];
        }

        if (first.Length != second.Length)
        {
            string longestString = first.Length > second.Length ? longestString = first : longestString = second;

            for (int i = shortest;i < longest; i++)
            {
                sum += longestString[i];
            }
        }

        Console.WriteLine(sum);
    }
}