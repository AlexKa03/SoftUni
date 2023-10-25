using System;

namespace _08._Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelLiters = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double result;


            if (fuelType == "Diesel")
            {
                if (clubCard == "Yes")
                {
                    if (fuelLiters >= 20 && fuelLiters <= 25)
                    {
                        result = (2.33 - 0.12) * fuelLiters;
                        result = result - (result * 0.08);
                    }
                    else if (fuelLiters > 25)
                    {
                        result = (2.33 - 0.12) * fuelLiters;
                        result = result - (result * 0.1);
                    }
                    else
                    {
                        result = (2.33 - 0.12) * fuelLiters;
                    }
                }
                else
                {
                    if (fuelLiters >= 20 && fuelLiters <= 25)
                    {
                        result = 2.33 * fuelLiters;
                        result = result - (result * 0.08);
                    }
                    else if (fuelLiters > 25)
                    {
                        result = 2.33 * fuelLiters;
                        result = result - (result * 0.1);
                    }
                    else
                    {
                        result = 2.33 * fuelLiters;
                    }
                }
            }
            else if (fuelType == "Gasoline")
            {
                if (clubCard == "Yes")
                {
                    if (fuelLiters >= 20 && fuelLiters <= 25)
                    {
                        result = (2.22 - 0.18) * fuelLiters;
                        result = result - (result * 0.08);
                    }
                    else if (fuelLiters > 25)
                    {
                        result = (2.22 - 0.18) * fuelLiters;
                        result = result - (result * 0.1);
                    }
                    else
                    {
                        result = (2.22 - 0.18) * fuelLiters;
                    }
                }
                else
                {
                    if (fuelLiters >= 20 && fuelLiters <= 25)
                    {
                        result = 2.22 * fuelLiters;
                        result = result - (result * 0.08);
                    }
                    else if (fuelLiters > 25)
                    {
                        result = 2.22 * fuelLiters;
                        result = result - (result * 0.1);
                    }
                    else
                    {
                        result = 2.22 * fuelLiters;
                    }
                }
            }
            else
            {
                if (clubCard == "Yes")
                {
                    if (fuelLiters >= 20 && fuelLiters <= 25)
                    {
                        result = (0.93 - 0.08) * fuelLiters;
                        result = result - (result * 0.08);
                    }
                    else if (fuelLiters > 25)
                    {
                        result = (0.93 - 0.08) * fuelLiters;
                        result = result - (result * 0.1);
                    }
                    else
                    {
                        result = (0.93 - 0.08) * fuelLiters;
                    }
                }
                else
                {
                    if (fuelLiters >= 20 && fuelLiters <= 25)
                    {
                        result = 0.93 * fuelLiters;
                        result = result - (result * 0.08);
                    }
                    else if (fuelLiters > 25)
                    {
                        result = 0.93 * fuelLiters;
                        result = result - (result * 0.1);
                    }
                    else
                    {
                        result = 0.93 * fuelLiters;
                    }
                }
            }

            Console.WriteLine($"{result:f2} lv.");
        }
    }
}
