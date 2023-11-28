class Program
{
    static void Main(string[] args)
    {
        var followers = new Dictionary<string, HashSet<string>>();

        var following = new Dictionary<string, HashSet<string>>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Statistics")
            {
                break;
            }

            string[] cmd = input.Split(" ");
            string vlogger = cmd[0];
            string action = cmd[1];

            if (action == "joined")
            {
                if (!followers.ContainsKey(vlogger))
                {
                    followers[vlogger] = new HashSet<string>();
                    following[vlogger] = new HashSet<string>();
                }
            }
            else if (action == "followed")
            {
                string followed = cmd[2];

                if (vlogger != followed && followers.ContainsKey(vlogger) && followers.ContainsKey(followed))
                {
                    if (!followers[followed].Contains(vlogger))
                    {
                        followers[followed].Add(vlogger);
                        following[vlogger].Add(followed);
                    }
                }
            }
        }

        Console.WriteLine($"The V-Logger has a total of {followers.Count} vloggers in its logs.");

        int count = 1;
        foreach (var vlogger in followers.OrderByDescending(v => v.Value.Count).ThenBy(v => following[v.Key].Count))
        {
            Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value.Count} followers, {following[vlogger.Key].Count} following");

            if (count == 1)
            {
                foreach (var follower in vlogger.Value.OrderBy(f => f))
                {
                    Console.WriteLine($"*  {follower}");
                }
            }

            count++;
        }
    }
}