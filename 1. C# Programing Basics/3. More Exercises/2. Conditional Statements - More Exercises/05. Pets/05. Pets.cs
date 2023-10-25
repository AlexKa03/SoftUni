using System;

namespace _05._Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodKg = int.Parse(Console.ReadLine());
            double dogFoodKg = double.Parse(Console.ReadLine());
            double catFoodKg = double.Parse(Console.ReadLine());
            double turtleFoodGr = double.Parse(Console.ReadLine());

            double dogTotal = days * dogFoodKg;
            double catTotal = days * catFoodKg;
            double turtleTotal = days * (turtleFoodGr / 1000);

            double foodEaten = dogTotal + catTotal + turtleTotal;

            if (foodEaten < foodKg)
            {
                Console.WriteLine($"{Math.Floor(foodKg - foodEaten)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodEaten - foodKg)} more kilos of food are needed.");
            }
        }
    }
}
