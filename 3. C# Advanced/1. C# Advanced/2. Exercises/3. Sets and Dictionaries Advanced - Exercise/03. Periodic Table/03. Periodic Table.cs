class Program
{
    static void Main(string[] args)
    {
        int counter = int.Parse(Console.ReadLine());

        SortedSet<string> elements = new SortedSet<string>();

        for (int i = 0; i < counter; i++)
        {
            string[] elementsToPut = Console.ReadLine()
                .Split(" ")
                .ToArray();

            for (int j = 0; j < elementsToPut.Length; j++)
            {
                elements.Add(elementsToPut[j]);
            }
        }

        Console.WriteLine(string.Join(" ", elements));
    }
}