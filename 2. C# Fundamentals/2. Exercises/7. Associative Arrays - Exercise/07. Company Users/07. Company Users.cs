class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> companysInformation = new Dictionary<string, List<string>>();

        while (true)
        {
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (command[0] == "End") { break; }

            string companyName = command[0];
            string userId = command[2];

            if (companysInformation.ContainsKey(companyName))
            {
                bool isFirst = true;

                for (int i = 0; i < companysInformation[companyName].Count; i++)
                {
                    if (userId == companysInformation[companyName][i])
                    {
                        isFirst = false;
                    }
                }

                if (isFirst)
                {
                    companysInformation[companyName].Add(userId);
                }
            }
            else
            {
                companysInformation.Add(companyName, new List<string>() { userId });
            }
        }

        foreach (var company in companysInformation)
        {
            Console.WriteLine($"{company.Key} \n-- {string.Join("\n-- ", company.Value)}");
        }
    }
}