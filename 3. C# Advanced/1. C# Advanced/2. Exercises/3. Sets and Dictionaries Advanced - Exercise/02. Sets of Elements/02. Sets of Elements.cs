class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        int m = numbers[0];
        int n = numbers[1];

        HashSet<int> setM = new HashSet<int>();
        HashSet<int> setN = new HashSet<int>();

        bool isFirstBiger = false;

        for (int i = 0; i < m; i++)
        {
            setM.Add(int.Parse(Console.ReadLine()));
        }

        for (int i = 0; i < n; i++)
        {
            setN.Add(int.Parse(Console.ReadLine()));
        }

        foreach (int number in setM)
        {         
            if (setN.Contains(number))
            {
                Console.Write($"{number} ");
            }
        }
    }
}