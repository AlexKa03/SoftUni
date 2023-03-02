using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int repeat = int.Parse(Console.ReadLine());

        string result = RepeatingString(input, repeat);
        Console.WriteLine(result);
    }
    
    static string RepeatingString (string input, int repeat)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < repeat; i++)
        {
            result.Append(input);
        }

        return result.ToString();
    }
}