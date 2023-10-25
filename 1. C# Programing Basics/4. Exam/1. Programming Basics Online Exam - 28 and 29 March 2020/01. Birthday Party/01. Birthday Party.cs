using System;

namespace _01._Birthday_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hallRent = double.Parse(Console.ReadLine());

            double cake = hallRent * 0.2;
            double drinks = cake - (cake * 0.45);
            double animator = hallRent / 3;

            Console.WriteLine(hallRent + cake + drinks + animator);
        }
    }
}
