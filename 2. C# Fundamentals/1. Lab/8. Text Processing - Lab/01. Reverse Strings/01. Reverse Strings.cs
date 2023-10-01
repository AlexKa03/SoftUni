class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string word = Console.ReadLine();

            if (word == "end")
            {
                break;
            }

            string reversed = new string(word.Reverse()
                                              .ToArray());

            Console.WriteLine($"{word} = {reversed}");
        }
    }
}