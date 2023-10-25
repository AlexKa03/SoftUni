using System;

namespace _04._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1Counter = 0;
            double p2Counter = 0;
            double p3Counter = 0;
            double p4Counter = 0;
            double p5Counter = 0;           

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1Counter++;
                }
                else if (number >= 200 && number <= 399)
                {
                    p2Counter++;
                }
                else if (number >= 400 && number <= 599)
                {
                    p3Counter++;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4Counter++;
                }
                else
                {
                    p5Counter++;
                }
            }

            double p1 = (p1Counter / n) * 100;
            double p2 = (p2Counter / n) * 100;
            double p3 = (p3Counter / n) * 100;
            double p4 = (p4Counter / n) * 100;
            double p5 = (p5Counter / n) * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
