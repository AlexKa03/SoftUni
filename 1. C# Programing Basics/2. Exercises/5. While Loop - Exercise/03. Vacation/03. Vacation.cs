using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int counterDays = 0;
            int counterSpend = 0;

            while (availableMoney < tripMoney && counterSpend < 5)
            {
                string activity = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                counterDays++;

                if (activity == "spend")
                {
                    counterSpend++;
                    if (counterSpend == 5)
                    {
                        break;
                    }
                    availableMoney -= sum;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
                else
                {
                    counterSpend = 0;
                    availableMoney += sum;
                }

                if (availableMoney >= tripMoney)
                {
                    break;
                }
            }

            if (counterSpend == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(counterDays);
            }
            else
            {
                Console.WriteLine($"You saved the money for {counterDays} days.");
            }
        }
    }
}
