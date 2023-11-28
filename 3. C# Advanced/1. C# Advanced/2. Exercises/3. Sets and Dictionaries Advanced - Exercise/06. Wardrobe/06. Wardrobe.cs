class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

        int counter = int.Parse(Console.ReadLine());

        for (int i = 0; i < counter; i++)
        {
            string[] newColorClothes = Console.ReadLine()
                .Split(" -> ");

            string[] newClothes = newColorClothes[1]
                .Split(",");

            if (!wardrobe.ContainsKey(newColorClothes[0]))
            {
                wardrobe.Add(newColorClothes[0], new Dictionary<string, int>());
            }

            foreach (var cloth in newClothes)
            {
                if (!wardrobe[newColorClothes[0]].ContainsKey(cloth))
                {
                    wardrobe[newColorClothes[0]].Add(cloth, 0);
                }

                wardrobe[newColorClothes[0]][cloth]++;
            }
        }

        string[] outfitWanted = Console.ReadLine()
                .Split(" ");

        foreach (var (color, clothing) in wardrobe)
        {
            Console.WriteLine($"{color} clothes:");

            foreach (var (cloth, count) in clothing)
            {
                Console.Write($"* {cloth} - {count}");

                if (color == outfitWanted[0] && cloth == outfitWanted[1])
                {
                    Console.Write(" (found!)");
                }

                Console.WriteLine();
            }
        }
    }
}