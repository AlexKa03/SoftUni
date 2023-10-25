using System;

namespace _06._Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double elTotal = 0.00;
            double others = 0.00;

            for (int i = 0; i < months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());

                elTotal += electricity;
                others += 1.2 * (electricity + 20 + 15);
            }

            Console.WriteLine($"Electricity: {elTotal:f2} lv");
            Console.WriteLine($"Water: {months * 20:f2} lv");
            Console.WriteLine($"Internet: {months * 15:f2} lv");
            Console.WriteLine($"Others: {others:f2} lv");
            Console.WriteLine($"Average: {(elTotal + (months * 35) + others) / months:f2} lv");
        }
    }
}
