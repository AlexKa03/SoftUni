using System;

namespace _03._Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLoads = int.Parse(Console.ReadLine());

            double tonsTotal = 0;
            double tonsVan = 0;
            double tonsTruck = 0;
            double tonsTrain = 0;

            for (int i = 0; i < numberOfLoads; i++)
            {
                int loadTons = int.Parse(Console.ReadLine());

                tonsTotal += loadTons;

                if (loadTons <= 3)
                {
                    tonsVan += loadTons;
                }
                else if (loadTons <= 11)
                {
                    tonsTruck += loadTons;
                }
                else 
                { 
                    tonsTrain += loadTons;
                }
            }

            double averagePrice = (tonsVan * 200 + tonsTruck * 175 + tonsTrain * 120) / tonsTotal;
            tonsVan = 100 * (tonsVan / tonsTotal);
            tonsTruck = 100 * (tonsTruck / tonsTotal);
            tonsTrain = 100 * (tonsTrain / tonsTotal);

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{tonsVan:f2}%");
            Console.WriteLine($"{tonsTruck:f2}%");
            Console.WriteLine($"{tonsTrain:f2}%");
        }
    }
}
