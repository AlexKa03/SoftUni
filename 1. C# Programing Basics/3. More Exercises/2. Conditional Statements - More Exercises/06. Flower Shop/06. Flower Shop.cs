using System;

namespace _06._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cacti = int.Parse(Console.ReadLine());
            double giftPice = double.Parse(Console.ReadLine());

            double sum = (magnolias * 3.25) + (hyacinths * 4) + (roses * 3.5) + (cacti * 8);
            sum = sum - (sum * 0.05);

            if (sum >= giftPice)
            {
                Console.WriteLine($"She is left with {Math.Floor(sum - giftPice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPice - sum)} leva.");
            }
        }
    }
}
