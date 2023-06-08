class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> information = new Dictionary<string, int>();

        while (true)
        {
            string resource = Console.ReadLine();

            if (resource == "stop")
            {
                break;
            }

            int quantities = int.Parse(Console.ReadLine());      

            if (information.ContainsKey(resource))
            {
                information[resource] += quantities;
            }
            else
            {
                information.Add(resource, quantities);
            }
        }

        foreach (var item in information)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}