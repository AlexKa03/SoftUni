class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        MiddleCharacter(input);
    }

    static void MiddleCharacter(string input)
    {
        if (input.Length % 2 == 1)
        {
            int i = input.Length / 2;

            Console.WriteLine($"{input[i]}");
        }
        else 
        {
            int i = (input.Length / 2) - 1;
            int j = i + 1;

            Console.WriteLine($"{input[i]}{input[j]}");
        }
    }
}