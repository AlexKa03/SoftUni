class Program
{
    static void Main(string[] args)
    {
        List<int> neighborhood = Console.ReadLine()
            .Split("@", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        int activeHouse = 0;
        int lastHouse = neighborhood.Count - 1;

        string command = Console.ReadLine();

        while (command != "Love!")
        {
            string[] data = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int jumpWith = int.Parse(data[1]);           

            activeHouse += jumpWith;

            if (activeHouse > lastHouse)
            {
                activeHouse = 0;
            }

            if (neighborhood[activeHouse] == 0)
            {
                string status = "already had";
                ValentinesDayStatus(activeHouse, status);
            }
            else if (neighborhood[activeHouse] == 2)
            {
                neighborhood[activeHouse] -= 2;
                string status = "has";

                ValentinesDayStatus(activeHouse, status);
            }
            else
            {
                neighborhood[activeHouse] -= 2;
            }

            command = Console.ReadLine();
        }

        Printer(activeHouse, neighborhood);
    }

    static void Printer(int lastHouse, List<int> hearts)
    {
        Console.WriteLine($"Cupid's last position was {lastHouse}.");

        bool isSuccessful = true;
        int counterFails = 0;

        for (int i = 0; i < hearts.Count; i++)
        {
            if (hearts[i] == 0)
            { 
                continue; 
            }
            else
            {
                isSuccessful = false;
                counterFails++;
            }
        }

        if (isSuccessful)
        {
            Console.WriteLine("Mission was successful.");
        }
        else
        {
            Console.WriteLine($"Cupid has failed {counterFails} places.");
        }
    }

    static void ValentinesDayStatus(int activeHouse, string status)
    {
        Console.WriteLine($"Place {activeHouse} {status} Valentine's day.");
    }
}