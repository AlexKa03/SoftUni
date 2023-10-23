using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        var emialPattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";

        var emails = Regex.Matches(input, emialPattern);

        foreach (var email in emails)
        {
            Console.WriteLine(email);
        }
    }
}