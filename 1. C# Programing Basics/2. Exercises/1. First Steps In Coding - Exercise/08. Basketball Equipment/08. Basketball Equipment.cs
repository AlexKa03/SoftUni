using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trainingTax = int.Parse(Console.ReadLine());

            double shoes = trainingTax - (trainingTax * 0.4);
            double equipment = shoes - (shoes * 0.2);
            double ball = equipment / 4;
            double accessories = ball / 5;
            double total = trainingTax + shoes + equipment + ball + accessories;

            Console.WriteLine(total);
        }
    }
}
