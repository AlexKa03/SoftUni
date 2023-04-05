class Program
{
    static void Main(string[] args)
    {
        double money = double.Parse(Console.ReadLine());
        List<int> drumsSet = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        string command = Console.ReadLine();

        List<int> drumsHealth = drumsSet.ToList();

        while (command != "Hit it again, Gabsy!")
        {
            int power = int.Parse(command);

            for (int i = 0; i < drumsHealth.Count; i++)
            {
                if (drumsHealth[i] - power <= 0)
                {
                    if (money >= drumsSet[i] * 3)
                    {
                        drumsHealth[i] = drumsSet[i];
                        money -= drumsSet[i] * 3;
                    }
                    else
                    {
                        drumsHealth.RemoveAt(i);
                        drumsSet.RemoveAt(i);
                        i--;
                    }
                }
                else
                {
                    drumsHealth[i] -= power;
                }
            }

            command = Console.ReadLine();
        }

        foreach (int drum in drumsHealth)
        {
            Console.Write($"{drum} ");
        }

        Console.WriteLine($"\nGabsy has {money:f2}lv.");
    }
}