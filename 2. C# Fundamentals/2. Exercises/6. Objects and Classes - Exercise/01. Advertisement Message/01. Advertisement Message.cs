class Program
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        string[] phrase = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };

        string[] events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

        string[] author = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

        string[] city = new string[]
        {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

        Random rnd = new Random();

        for (int i = 1; i <= lines; i++)
        {
            int phraseIndex = rnd.Next(0, phrase.Length);
            int eventsIndex = rnd.Next(0, events.Length);
            int authorIndex = rnd.Next(0, author.Length);
            int cityIndex = rnd.Next(0, city.Length);

            Console.WriteLine($"{phrase[phraseIndex]} {events[eventsIndex]} {author[authorIndex]} - {city[cityIndex]}");
        }
    }
}