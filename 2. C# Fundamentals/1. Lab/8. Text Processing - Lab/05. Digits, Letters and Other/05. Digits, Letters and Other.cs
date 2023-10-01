class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string numbers = string.Empty;
        string letters = string.Empty;
        string symbols = string.Empty;

        foreach (var symbol in input)
        {
            if (char.IsDigit(symbol))
            {
                numbers += symbol;
            }
            else if (char.IsLetter(symbol))
            {
                letters += symbol;
            }
            else
            {
                symbols += symbol;
            }
        }

        Console.WriteLine($"{numbers}\n{letters}\n{symbols}");
    }
}