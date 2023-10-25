using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            double seats = double.Parse(Console.ReadLine());

            double counterPerMovie = 0.0;
            double counterTotal = 0.0;
            double counterStudent = 0.0;
            double counterStandard = 0.0;
            double counterKid = 0.0;

            while (movieName != "Finish")
            {
                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {
                    counterPerMovie++;
                    counterTotal++;            

                    if (ticketType == "student")
                    {
                        counterStudent++;
                    }
                    else if (ticketType == "standard")
                    {
                        counterStandard++;
                    }
                    else
                    {
                        counterKid++;
                    }

                    if (counterPerMovie == seats)
                    {
                        break;
                    }

                    ticketType = Console.ReadLine();
                }

                Console.WriteLine($"{movieName} - {(counterPerMovie / seats) * 100:f2}% full.");

                counterPerMovie = 0;
                movieName = Console.ReadLine();

                if (movieName == "Finish")
                {
                    break;
                }

                seats = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Total tickets: {counterTotal}");
            Console.WriteLine($"{(counterStudent / counterTotal) * 100:f2}% student tickets.");
            Console.WriteLine($"{(counterStandard / counterTotal) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(counterKid / counterTotal) * 100:f2}% kids tickets.");
        }
    }
}
