using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var pattern = @"(?<firstName>\b[A-Z][a-z]+) (?<secondName>\b[A-Z][a-z+]+)";
        Regex regex = new Regex(pattern);

        string text = Console.ReadLine();
        var matches = regex.Matches(text);

        Console.WriteLine(string.Join(' ', matches));
    }
}