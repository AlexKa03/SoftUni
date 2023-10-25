using System;

namespace _01._Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyInherited = double.Parse(Console.ReadLine());
            int yearToStay = int.Parse(Console.ReadLine());

            int age = 18;

            for (int i = 1800; i <= yearToStay; i++)
            {
                if (i % 2 == 0)
                {
                    moneyInherited -= 12000;
                }
                else
                {
                    moneyInherited -= 12000 + (50 * age);
                }

                age++;
            }

            if (moneyInherited >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyInherited:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(moneyInherited):f2} dollars to survive.");
            }
        }
    }
}
