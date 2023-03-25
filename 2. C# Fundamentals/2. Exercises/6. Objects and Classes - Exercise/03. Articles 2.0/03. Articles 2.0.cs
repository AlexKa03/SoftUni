using _03._Articles_2._0;

class Program
{
    static void Main(string[] args)
    {
        int numberOfArticles = int.Parse(Console.ReadLine());

        List<Article> list = new List<Article>();
        Article article = new Article();

        for (int i = 0; i < numberOfArticles; i++)
        {
            string[] data = Console.ReadLine()
            .Split(", ");

            article = new Article()
            {
                Title = data[0],
                Content = data[1],
                Author = data[2]
            };

            list.Add(article);
        }

        foreach (var item in list)
        {
            Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
        }
    }
}