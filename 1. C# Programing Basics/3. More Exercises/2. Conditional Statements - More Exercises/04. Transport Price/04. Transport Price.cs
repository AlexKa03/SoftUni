using System;

namespace _04._Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string when = Console.ReadLine();
            double bestPrice = 0.00;

            if (when == "day")
            {            
                if (distance < 20)
                {
                    bestPrice = 0.7 + (distance * 0.79);
                }            
                else if (distance < 100)
                {
                        bestPrice = distance * 0.09;

                }               
                else
                {
                    bestPrice = distance * 0.06;
                }
            }

            else if (when == "night")
            {
                if (distance < 20)
                {
                    bestPrice = 0.7 + (distance * 0.90);
                }
                else if (distance < 100)
                {
                    bestPrice = distance * 0.09;

                }
                else
                {
                    bestPrice = distance * 0.06;
                }
            }

            Console.WriteLine($"{bestPrice:f2}");
        }
    }
}
