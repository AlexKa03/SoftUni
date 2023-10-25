using System;

namespace _07._Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            string output;

            if (hour >= 10 && hour <= 18)
            {
                switch (day)
                {                   
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":
                        output = "open";
                        break;
                    default:
                        output = "closed";
                        break;
                }
            }
            else
            {
                output = "closed";
            }

            Console.WriteLine(output);
        }
    }
}
