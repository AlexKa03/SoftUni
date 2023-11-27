class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, double>> storesInformation = new Dictionary<string, Dictionary<string, double>>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Revision")
            {
                break;
            }

            string[] information = input
                .Split(", ")
                .ToArray();

            string store = information[0];
            string product = information[1];
            double price = double.Parse(information[2]);

            if (!storesInformation.ContainsKey(store))
            {
                storesInformation.Add(store, new Dictionary<string, double>());
            }

            storesInformation[store].Add(product, price);
        }

        storesInformation = storesInformation
            .OrderBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var (store, productInfo) in storesInformation)
        {
            Console.WriteLine($"{store}->");

            foreach (var (product, price) in productInfo)
            {
                Console.WriteLine($"Product: {product}, Price: {price}");
            }
        }
    }
}