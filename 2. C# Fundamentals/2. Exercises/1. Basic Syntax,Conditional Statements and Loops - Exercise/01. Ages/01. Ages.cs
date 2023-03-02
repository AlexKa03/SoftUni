using System;

namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            string ageGroup = "";

            if (age >= 0 && age <= 2)
            {
                ageGroup = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                ageGroup = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                ageGroup = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                ageGroup = "adult";
            }
            else if (age >= 66)
            {
                ageGroup = "elder";
            }

            Console.WriteLine(ageGroup);
        }
    }
}
