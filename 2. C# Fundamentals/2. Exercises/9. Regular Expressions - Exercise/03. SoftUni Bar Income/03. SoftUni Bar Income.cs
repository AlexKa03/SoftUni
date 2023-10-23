using System.Text.RegularExpressions;

class Program
{
    class ProductAndPrice
    {
        public string Product { get; set; }
        public double Price { get; set; }

        public ProductAndPrice(string product, double price)
        {
            Product = product;
            Price = price;
        }
    }

    static void Main(string[] args)
    {
        var pattern = @"%(?<customer>[A-Z][a-z]*)%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<count>\d+)\|[^|$%.]*?(?<price>[0-9]+(\.[0-9]+)?)\$";

        var command = Console.ReadLine();

        Dictionary<string, List<ProductAndPrice>> summary = new Dictionary<string, List<ProductAndPrice>>();

        while (command != "end of shift")
        {
            var report = Regex.Match(command, pattern);

            if (report.Success)
            {
                string customer = report.Groups["customer"].Value;
                string product = report.Groups["product"].Value;
                double price = double.Parse(report.Groups["price"].Value) * int.Parse(report.Groups["count"].Value);

                if (!summary.ContainsKey(customer))
                {
                    summary[customer] = new List<ProductAndPrice>();
                }

                summary[customer].Add(new ProductAndPrice(product, price));
            }

            command = Console.ReadLine();
        }

        double total = 0;

        foreach (var result in summary)
        {
            foreach (var valuePair in result.Value)
            {
                Console.WriteLine($"{result.Key}: {valuePair.Product} - {valuePair.Price:f2}");
                total += valuePair.Price;
            }
        }

        Console.WriteLine($"Total income: {total:f2}");
    }
}