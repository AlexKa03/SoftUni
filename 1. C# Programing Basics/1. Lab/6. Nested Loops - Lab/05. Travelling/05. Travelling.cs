
using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string whereToGo = Console.ReadLine();

                if (whereToGo == "End")
                {
                    break;
                }

                double requiredBudget = double.Parse(Console.ReadLine());
                double savings = 0;

                while (savings < requiredBudget)
                {
                    double sum = double.Parse(Console.ReadLine());

                    savings += sum;
                }

                Console.WriteLine($"Going to {whereToGo}!");
            }
        }
    }
}
