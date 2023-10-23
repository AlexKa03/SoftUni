using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string namePattern = @"[A-Za-z]+";
        Regex distancePattern = new Regex(@"\d");

        string command = Console.ReadLine();

        Dictionary<string, int> racers = new Dictionary<string, int>();

        for (int i = 0; i < names.Length; i++)
        {
            racers.Add(names[i], 0);
        }

        while (command != "end of race")
        {
            var nameMatch = Regex.Matches(command, namePattern)
                                 .Cast<Match>()
                                 .Select(x => x.Value)
                                 .Aggregate((a, b) => a + b);

            if (racers.ContainsKey(nameMatch))
            {
                MatchCollection matches = distancePattern.Matches(command);

                int distance = 0;

                foreach (Match match in matches)
                {
                    distance += int.Parse(match.Value);
                }


                racers[nameMatch] += distance;
            }

            command = Console.ReadLine();
        }

        var sortedDict = racers.OrderByDescending(x => x.Value)
                             .ToDictionary(x => x.Key, x => x.Value);

        int place = 1;

        foreach (var sd in sortedDict)
        {
            if (place > 3)
            {
                break;
            }

            switch (place)
            {
                case 1:
                    Console.Write("1st ");
                    break;
                case 2:
                    Console.Write("2nd ");
                    break;
                case 3:
                    Console.Write("3rd ");
                    break;
            }

            Console.WriteLine($"place: {sd.Key}");

            place++;
        }
    }
}