using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double total = 0.00;

            for (int i = 1; i <= orders; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                double orderTotal = capsulePrice * (days * capsuleCount);
                total += orderTotal;

                Console.WriteLine($"The price for the coffee is: ${orderTotal:f2}");
            }

            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
