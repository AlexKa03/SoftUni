using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaningPreparation = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double penMoney = pen * 5.80;
            double markersMoney = markers * 7.20;
            double cleaningPreMoney = cleaningPreparation * 1.20;
            double total = penMoney + markersMoney + cleaningPreMoney;
            double totalDiscount = total - (total * (discount / 100));

            Console.WriteLine(totalDiscount);
        }
    }
}
