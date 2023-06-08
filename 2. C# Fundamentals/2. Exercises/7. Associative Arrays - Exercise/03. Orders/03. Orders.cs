class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<double>> information = new Dictionary<string, List<double>>();

        while (true)
        {
            string[] productInformation = Console.ReadLine()
                .Split(" ")
                .ToArray();

            string product = productInformation[0];

            if (product == "buy")
            {
                break;
            }

            double price = double.Parse(productInformation[1]);
            int quantity = int.Parse(productInformation[2]);

            if (information.ContainsKey(product))
            {
                information[product][0] = price;
                information[product][1] += quantity;
            }
            else
            {
                information.Add(product, new List<double>() { price, quantity });
            }
        }

        foreach (var product in information)
        {
            Console.WriteLine($"{product.Key} -> {product.Value[0] * product.Value[1]:f2}");
        }
    }
}