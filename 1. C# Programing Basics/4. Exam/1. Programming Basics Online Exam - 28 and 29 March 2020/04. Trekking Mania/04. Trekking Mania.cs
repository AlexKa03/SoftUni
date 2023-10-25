using System;

namespace _04._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            double counterMusala = 0;
            double counterMonblan = 0;
            double counterKilimanjaro = 0;
            double counterK2 = 0;
            double counterEverest = 0;
            double countPeoples = 0;

            for (int i = 1; i <= groups; i++)
            {
                int peoples = int.Parse(Console.ReadLine());

                countPeoples += peoples;

                if (peoples <= 5)
                {
                    counterMusala += peoples;
                }
                else if (peoples >= 6 && peoples <= 12)
                {
                    counterMonblan += peoples;
                }
                else if (peoples >= 13 && peoples <= 25)
                {
                    counterKilimanjaro += peoples;
                }
                else if (peoples >= 26 && peoples <= 40)
                {
                    counterK2 += peoples;
                }
                else if (peoples >= 41)
                {
                    counterEverest += peoples;
                }
            }

            Console.WriteLine($"{100 * (counterMusala / countPeoples):f2}%");
            Console.WriteLine($"{100 * (counterMonblan / countPeoples):f2}%");
            Console.WriteLine($"{100 * (counterKilimanjaro / countPeoples):f2}%");
            Console.WriteLine($"{100 * (counterK2 / countPeoples):f2}%");
            Console.WriteLine($"{100 * (counterEverest / countPeoples):f2}%");
        }
    }
}
