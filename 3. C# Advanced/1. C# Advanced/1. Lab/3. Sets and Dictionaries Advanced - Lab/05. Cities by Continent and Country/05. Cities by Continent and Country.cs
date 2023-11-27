class Program
{
    static void Main(string[] args)
    {
        int counter = int.Parse(Console.ReadLine());

        Dictionary<string, Dictionary<string, List<string>>> mapInformation = new Dictionary<string, Dictionary<string, List<string>>>();

        for (int i = 0; i < counter; i++)
        {
            string[] information = Console.ReadLine()
                .Split();

            string continent = information[0];
            string country = information[1];
            string city = information[2];

            if (!mapInformation.ContainsKey(continent))
            {
                mapInformation.Add(continent, new Dictionary<string, List<string>>());
            }
            if (!mapInformation[continent].ContainsKey(country))
            {
                mapInformation[continent].Add(country, new List<string>());
            }

            mapInformation[continent][country].Add(city);
        }

        foreach (var (continent, countryInfo) in mapInformation)
        {
            Console.WriteLine($"{continent}:");

            foreach (var (country, city) in countryInfo)
            {
                Console.WriteLine($"  {country} -> {string.Join(", ", city)}");
            }
        }
    }
}