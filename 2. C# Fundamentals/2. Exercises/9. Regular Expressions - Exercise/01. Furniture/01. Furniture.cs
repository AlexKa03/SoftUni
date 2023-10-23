using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var pattern = @">>(?<furniture>[A-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";

        double sum = 0.00;
        List<string> furniture = new List<string>();

        var command = Console.ReadLine();

        while (command != "Purchase")
        {
            var match = Regex.Match(command, pattern);

            if (match.Success)
            {
                furniture.Add(match.Groups["furniture"].Value);

                double price = double.Parse(match.Groups["price"].Value);
                int quantity = int.Parse(match.Groups["quantity"].Value);

                sum += price * quantity;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine("Bought furniture:");
        foreach (var item in furniture)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Total money spend: {sum:f2}");
    }
}