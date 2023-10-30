class Stats
{
    public int HitPoints { get; set; }
    public int ManaPoints { get; set; }

    public Stats(int hitPoints, int manaPoints)
    {
        HitPoints = hitPoints;
        ManaPoints = manaPoints;
    }
}
class program
{
    static void Main(string[] args)
    {
        int countHeroes = int.Parse(Console.ReadLine());

        Dictionary<string, List<Stats>> heroesStats = new Dictionary<string, List<Stats>>();

        for (int i = 0; i < countHeroes; i++)
        {
            string[] hero = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            heroesStats[hero[0]] = new List<Stats>();

            int hitPoints = int.Parse(hero[1]);
            int manaPoints = int.Parse(hero[2]);

            if (hitPoints > 100)
            {
                hitPoints = 100;
            }
            if (manaPoints > 200)
            {
                manaPoints = 200;
            }

            heroesStats[hero[0]].Add(new Stats(hitPoints, manaPoints));
        }

        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] command = input
                .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

            switch (command[0])
            {
                case "CastSpell":
                    {
                        foreach (var pair in heroesStats)
                        {
                            foreach (var hero in pair.Value)
                            {
                                if (pair.Key == command[1])
                                {
                                    if (int.Parse(command[2]) <= hero.ManaPoints)
                                    {
                                        hero.ManaPoints -= int.Parse(command[2]);

                                        Console.WriteLine($"{command[1]} has successfully cast {command[3]} and now has {hero.ManaPoints} MP!");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{pair.Key} does not have enough MP to cast {command[3]}!");
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                    break;

                case "TakeDamage":
                    {
                        foreach (var pair in heroesStats)
                        {
                            foreach (var hero in pair.Value)
                            {
                                if (pair.Key == command[1])
                                {
                                    hero.HitPoints -= int.Parse(command[2]);

                                    if (hero.HitPoints > 0)
                                    {
                                        Console.WriteLine($"{command[1]} was hit for {command[2]} HP by {command[3]} and now has {hero.HitPoints} HP left!");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{command[1]} has been killed by {command[3]}!");
                                        heroesStats.Remove(pair.Key);
                                    }
                                }
                            }
                        }

                    }
                    break;

                case "Recharge":
                    {
                        foreach (var pair in heroesStats)
                        {
                            foreach (var hero in pair.Value)
                            {

                                if (pair.Key == command[1])
                                {
                                    int oldManaPoints = hero.ManaPoints;
                                    hero.ManaPoints += int.Parse(command[2]);

                                    if (hero.ManaPoints > 200)
                                    {
                                        hero.ManaPoints = 200;

                                        Console.WriteLine($"{command[1]} recharged for {200 - oldManaPoints} MP!");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{command[1]} recharged for {command[2]} MP!");
                                    }
                                }
                            }
                        }
                    }
                    break;

                case "Heal":
                    {
                        foreach (var pair in heroesStats)
                        {
                            foreach (var hero in pair.Value)
                            {
                                if (pair.Key == command[1])
                                {
                                    int oldHitPoints = hero.HitPoints;
                                    hero.HitPoints += int.Parse(command[2]);

                                    if (hero.HitPoints > 100)
                                    {
                                        hero.HitPoints = 100;

                                        Console.WriteLine($"{command[1]} healed for {100 - oldHitPoints} HP!");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{command[1]} healed for {int.Parse(command[2])} HP!");
                                    }

                                    break;
                                }
                            }
                        }
                    }
                    break;
            }

            input = Console.ReadLine();
        }

        foreach (var pair in heroesStats)
        {
            foreach (var hero in pair.Value)
            {
                Console.WriteLine(pair.Key);
                Console.WriteLine($"  HP: {hero.HitPoints}");
                Console.WriteLine($"  MP: {hero.ManaPoints}");
            }
        }
    }


}