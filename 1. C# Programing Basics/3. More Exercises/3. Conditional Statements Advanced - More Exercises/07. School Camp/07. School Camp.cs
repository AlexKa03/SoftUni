using System;

namespace _07._School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int overnightStays = int.Parse(Console.ReadLine());

            double total = 0.00;
            string sport = "";

            if (season == "Winter")
            {
                if (groupType == "mixed")
                {
                    total = studentsCount * (overnightStays * 10);
                    sport = "Ski";
                }
                else
                {
                    total = studentsCount * (overnightStays * 9.6);

                    if (groupType == "boys")
                    {
                        sport = "Judo";
                    }
                    else
                    {
                        sport = "Gymnastics";
                    }
                }
            }
            else if (season == "Spring")
            {
                if (groupType == "mixed")
                {
                    total = studentsCount * (overnightStays * 9.5);
                    sport = "Cycling";
                }
                else
                {
                    total = studentsCount * (overnightStays * 7.2);

                    if (groupType == "boys")
                    {
                        sport = "Tennis";
                    }
                    else
                    {
                        sport = "Athletics";
                    }
                }
            }
            else
            {
                if (groupType == "mixed")
                {
                    total = studentsCount * (overnightStays * 20);
                    sport = "Swimming";
                }
                else
                {
                    total = studentsCount * (overnightStays * 15);

                    if (groupType == "boys")
                    {
                        sport = "Football";
                    }
                    else
                    {
                        sport = "Volleyball";
                    }
                }
            }

            if (studentsCount >= 10 && studentsCount < 20)
            {
                total *= 0.95;
            }
            else if (studentsCount >= 20 && studentsCount < 50)
            {
                total *= 0.85;
            }
            else if (studentsCount >= 50)
            {
                total *= 0.5;
            }

            Console.WriteLine($"{sport} {total:f2} lv.");
        }
    }
}
