using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int paintThinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nylonMoney = (nylon + 2) * 1.50;
            double paintMoney = (paint * 1.1) * 14.50;
            int paintThinnerMoney = paintThinner * 5;
            double materialsMoney = nylonMoney + paintMoney + paintThinnerMoney + 0.40;
            double workersPay = (materialsMoney * 0.3) * 8;
            double total = materialsMoney + workersPay;

            Console.WriteLine(total);
        }
    }
}
