class Program
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        int[] encryptedMessages = new int[lines];

        for (int i = 0; i < lines; i++)
        {
            string word = Console.ReadLine();
            int sum = 0;

            for (int j = 0; j < word.Length; j++)
            {
                char letter = word[j];
                int letterCode = letter;

                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u'
                    || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                {
                    sum += letterCode * word.Length;
                }
                else
                {
                    sum += letterCode / word.Length;
                }
            }

            encryptedMessages[i] = sum;
        }

        Array.Sort(encryptedMessages);

        foreach (var message in encryptedMessages)
        {
            Console.WriteLine(message);
        }
    }
}