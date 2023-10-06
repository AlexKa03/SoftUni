class Program
{
    static void Main(string[] args)
    { 
        string input = Console.ReadLine();

        char[] symbols = input.ToCharArray();

        char repeats = '\0';

        foreach (char c in symbols)
        {
            if (c != repeats)
            {
                repeats = c;
                Console.Write(c);
            }
        }
    }
}