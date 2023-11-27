class Program
{
    static void Main(string[] args)
    {
        HashSet<string> regular = new HashSet<string>();
        HashSet<string> VIP = new HashSet<string>();

        string input = Console.ReadLine();

        while (input != "PARTY")
        {
            char[] typeOfInvite = input.ToCharArray();

            if (char.IsDigit(typeOfInvite[0]))
            {
                VIP.Add(input);
            }
            else
            {
                regular.Add(input);
            }

            input = Console.ReadLine();
        }

        input = Console.ReadLine();

        while (input != "END")
        {
            char[] typeOfInvite = input.ToCharArray();

            if (char.IsDigit(typeOfInvite[0]))
            {
                VIP.Remove(input);
            }
            else
            {
                regular.Remove(input);
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"{VIP.Count + regular.Count}");

        if (VIP.Any())
        {
            Console.WriteLine(string.Join("\n", VIP));
        }
        if (regular.Any())
        {
            Console.WriteLine(string.Join("\n", regular));
        }
    }
}