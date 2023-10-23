using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        int messagesCount = int.Parse(Console.ReadLine());

        string starPattern = @"[starSTAR]";
        string namePattern = @"@(?<name>[A-Za-z]+)[^@:!\->]*:(?<population>\d+)[^@:!\->]*!(?<command>[AD])![^@:!\->]*\->(?<soldier>\d+)";

        string result = string.Empty;

        List<string> attackedPlanets = new List<string>();
        List<string> destroyedPlanets = new List<string>();

        for (int i = 0; i < messagesCount; i++)
        {
            string message = Console.ReadLine();

            int count = Regex.Matches(message, starPattern)
                             .Count();

            char[] decyphering = message.ToCharArray();

            for (int j = 0; j < message.Length; j++)
            {
                decyphering[j] = (char)(decyphering[j] - count);
            }

            result = new string(decyphering);

            var matches = Regex.Match(result, namePattern);
            string name = matches.Groups["name"].Value;
            string typeOfAttack = matches.Groups["command"].Value;

            if (typeOfAttack == "A")
            {
                attackedPlanets.Add(name);
            }
            else if (typeOfAttack == "D")
            {
                destroyedPlanets.Add(name);
            }
        }

        attackedPlanets = attackedPlanets.OrderBy(x => x).ToList();
        destroyedPlanets = destroyedPlanets.OrderBy(x => x).ToList();

        Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
        for (int i = 0; i < attackedPlanets.Count; i++)
        {
            Console.WriteLine($"-> {attackedPlanets[i]}");
        }

        Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
        for (int i = 0; i < destroyedPlanets.Count; i++)
        {
            Console.WriteLine($"-> {destroyedPlanets[i]}");
        }
    }
}