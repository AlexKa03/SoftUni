class Program
{
    static void Main(string[] args)
    {
        int key = int.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());

        string[] message = new string[lines];

        for (int i = 0; i < lines; i++)
        {
            char letter = char.Parse(Console.ReadLine());

            int number = letter + key;
            char newLetter = (char)number;

            message[i] = newLetter.ToString();
        }

        foreach (var symbol in message)
        {
            Console.Write(symbol);
        }
        Console.WriteLine();
    }
}