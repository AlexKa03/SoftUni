using _02._Articles;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split(", ");
        int numberOfComands = int.Parse(Console.ReadLine());

        Article article = new Article(input[0], input[1], input[2]);

        for (int i = 0; i < numberOfComands; i++)
        {
            string[] commands = Console.ReadLine()
                .Split(": ");

            string commandType = commands[0];
            string commandValue = commands[1];

            if (commandType == "Edit")
            {
                article.Edit(commandValue);
            }
            else if (commandType == "ChangeAuthor")
            {
                article.ChangeAuthor(commandValue);
            }
            else if (commandType == "Rename")
            {
                article.Rename(commandValue);
            }
        }

        Console.WriteLine(article);
    }
}