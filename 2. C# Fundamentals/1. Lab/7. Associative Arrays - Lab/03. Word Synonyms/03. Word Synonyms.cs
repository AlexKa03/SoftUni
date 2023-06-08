class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string word = Console.ReadLine();
            string synonym = Console.ReadLine();

            if (words.ContainsKey(word) == false)
            {
                words.Add(word, new List<string>());
            }

            words[word].Add(synonym);
        }

        foreach (var word in words)
        {
            Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
        }
    }
}