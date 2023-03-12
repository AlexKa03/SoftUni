class Program
{
    static void Main(string[] args)
    {
        int numberCommands = int.Parse(Console.ReadLine());

        List<string> partyList = new List<string>(numberCommands);

        for (int i = 0; i < numberCommands; i++)
        {
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string name = command[0];

            if (command[2] != "not")
            {
                if (partyList.Contains(name))
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else
                {
                    partyList.Add(name);
                }
            }
            else
            {
                if (partyList.Contains(name))
                {
                    partyList.Remove(name);
                }
                else
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
            }
        }

        foreach (string guest in partyList)
        {
            Console.WriteLine(guest);
        }
    }
}