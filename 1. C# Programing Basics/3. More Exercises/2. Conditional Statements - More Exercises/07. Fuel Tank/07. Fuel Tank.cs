using System;

namespace _07._Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine().ToLower();
            int fuelLiters = int.Parse(Console.ReadLine());
            string output = "";

            if (fuelType == "diesel" || fuelType == "gasoline" || fuelType == "gas")
            {
                if (fuelLiters >= 25)
                {
                    output = $"You have enough {fuelType}.";
                }
                else if (fuelLiters < 25)
                {
                    output = $"Fill your tank with {fuelType}!";
                }
            }
            else
            {
                output = "Invalid fuel!";
            }

            Console.WriteLine(output);
        }
    }
}
