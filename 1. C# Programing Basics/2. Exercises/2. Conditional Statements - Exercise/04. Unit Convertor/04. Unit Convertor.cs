using System;

namespace _04._Unit_Convertor
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            double n = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            // my if / else if loops are most of the time stupidproof

            if (inputUnit == "m")
            {
                if (outputUnit == "cm")
                {
                    Console.WriteLine($"{n * 100:f3}");
                }
                else if (outputUnit == "mm")
                {
                    Console.WriteLine($"{n * 1000:f3}");
                }
            }
            else if (inputUnit == "cm")
            {
                if (outputUnit == "m")
                {
                    Console.WriteLine($"{n / 100:f3}");
                }
                else if (outputUnit == "mm")
                {
                    Console.WriteLine($"{n * 10:f3}");
                }
            }
            else if (inputUnit == "mm")
            {
                if (outputUnit == "m")
                {
                    Console.WriteLine($"{n / 1000:f3}");
                }
                else if (outputUnit == "cm")
                {
                    Console.WriteLine($"{n / 10:f3}");
                }
            }
        }
    }
}
