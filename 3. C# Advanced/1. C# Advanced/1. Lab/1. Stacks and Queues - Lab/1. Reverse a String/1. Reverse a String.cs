class Program
{
    static void Main(string[] args)
    {
        Stack<char> input = new Stack<char>(Console.ReadLine());

        foreach (char character in input)
        {
            Console.Write(character);
        }
    }
}