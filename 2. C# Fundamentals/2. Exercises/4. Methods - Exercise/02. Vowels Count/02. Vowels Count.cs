class Program
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine().ToLower();

        VowelsCount(word);
    }

    static void VowelsCount(string word)
    {
        int counter = 0;

        for (int i = 0; i < word.Length; i++)
        {
            switch (word[i])
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                    counter++;
                    break;
            }
        }

        Console.WriteLine(counter);
    }
}