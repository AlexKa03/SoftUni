class Program
{
    static void Main(string[] args)
    {
        int clients = int.Parse(Console.ReadLine());

        Dictionary<string, string> parking = new Dictionary<string, string>();

        for (int i = 0; i < clients; i++)
        {
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries) .ToArray();

            string action = command[0];
            string username = command[1];

            if (action == "register")
            {
                string plate = command[2];

                if (parking.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {plate}");
                }
                else
                {
                    parking.Add(username, plate);
                    Console.WriteLine($"{username} registered {plate} successfully");
                }
            }
            else
            {
                if (parking.ContainsKey(username))
                {
                    Console.WriteLine($"{username} unregistered successfully");

                    parking.Remove(username);
                }
                else
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                }
            }
        }

        foreach (var user in parking)
        {
            Console.WriteLine($"{user.Key} => {user.Value}");
        }
    }
}