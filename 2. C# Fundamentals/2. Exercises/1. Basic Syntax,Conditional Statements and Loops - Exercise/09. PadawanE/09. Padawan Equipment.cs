using System;

namespace _09._PadawanE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double studentsCount = double.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double lightsabers = studentsCount + Math.Ceiling(studentsCount * 0.1);
            double robes = studentsCount;
            double belts = studentsCount - Math.Floor(studentsCount / 6);

            double total = (lightsabers * lightsaberPrice) + (robes * robesPrice) + (belts * beltsPrice);

            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - money:f2}lv more.");
            }
        }
    }
}
