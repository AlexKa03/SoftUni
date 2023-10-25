using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            double term = double.Parse(Console.ReadLine());
            double yearlyPercent = double.Parse(Console.ReadLine());

            double interestYear = deposit * (yearlyPercent/100);
            double interestMonth = interestYear / 12;
            double total = deposit + term * interestMonth;

            Console.WriteLine(total);
        }
    }
}
