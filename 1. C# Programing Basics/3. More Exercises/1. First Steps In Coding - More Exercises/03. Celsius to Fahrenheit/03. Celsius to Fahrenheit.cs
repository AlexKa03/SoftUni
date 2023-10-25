using System;

namespace _03._Celsius_to_Fahrenheit
{
    internal class Celsius_to_Fahrenheit
    {
        static void Main(string[] args)
        {
            // Input
            double temperatureC = double.Parse(Console.ReadLine());

            // Calculate
            double temperatureF = temperatureC * 9 / 5 + 32;

            // Output
            Console.WriteLine($"{temperatureF:f2}");
        }
    }
}
