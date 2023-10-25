using System;

namespace _04._Food_for_Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double dogEaten = 0.0;
            double catEaten = 0.0;
            double biscuits = 0.0;

            for (int i = 1; i <= days; i++)
            {
                double dogEat = double.Parse(Console.ReadLine());
                double catEat = double.Parse(Console.ReadLine());

                dogEaten += dogEat;
                catEaten += catEat;

                if (i % 3 == 0)
                {
                    biscuits += 0.1 * (dogEat + catEat);
                }
            }

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{((catEaten + dogEaten) / food) * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{(dogEaten / (catEaten + dogEaten)) * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{(catEaten / (catEaten + dogEaten)) * 100:f2}% eaten from the cat.");
        }
    }
}
