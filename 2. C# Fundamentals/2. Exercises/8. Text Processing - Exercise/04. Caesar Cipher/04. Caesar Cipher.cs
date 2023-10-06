class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            char symbol = input[i];
            int asciiCode = (int)symbol + 3;
            char newSymbol = (char)asciiCode;

            Console.Write(newSymbol);
        }
    }
}