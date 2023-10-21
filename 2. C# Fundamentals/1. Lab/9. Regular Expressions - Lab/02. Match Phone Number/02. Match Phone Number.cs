using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var pattern = @"(?<versionOne>\+359 2 [0-9]{3} [0-9]{4}\b)|(?<versionTwo>\+359-2-[0-9]{3}-[0-9]{4}\b)";

        string phones = Console.ReadLine();

        var matches = Regex.Matches(phones, pattern);

        Console.WriteLine(string.Join(", ", matches));
    }
}