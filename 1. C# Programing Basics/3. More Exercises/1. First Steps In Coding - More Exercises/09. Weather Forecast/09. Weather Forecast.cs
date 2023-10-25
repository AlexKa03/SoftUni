using System;

namespace _09._Weather_Forecast
{
    internal class Weather_Forecast
    {
        static void Main(string[] args)
        {
            string wether = Console.ReadLine();

            if (wether != "sunny")
            {
                Console.WriteLine("It's cold outside!");
            }
            else
            {
                Console.WriteLine("It's warm outside!");               
            }

        }
    }
}
