class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        char[,] symbols = new char[size, size];

        bool isFound = false;

        for (int i = 0; i < size; i++)
        {
            char[] chars = Console.ReadLine()
                .ToCharArray();

            for (int j = 0; j < size; j++)
            {
                symbols[i, j] = chars[j];
            }
        }

        char symbolToMatch = char.Parse(Console.ReadLine());

        for (int i = 0;i < size; i++)
        {
            for (int j = 0;j < size; j++)
            {
                if (symbols[i, j] == symbolToMatch)
                {
                    Console.WriteLine($"({i}, {j})");
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                break;
            }
        }

        if (isFound == false)
        {
            Console.WriteLine($"{symbolToMatch} does not occur in the matrix");
        }
    }
}