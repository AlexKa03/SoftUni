using System;

namespace _01._Change_Bureau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double chineseYuan = double.Parse(Console.ReadLine());
            double fee = double.Parse(Console.ReadLine());

            fee = fee / 100;
            double total = 0;
            total += bitcoins * 1168;
            total += (chineseYuan * 0.15) * 1.76;
            total -= total * fee;
            total /= 1.95;


            Console.WriteLine($"{total:f2}");
        }
    }
}
