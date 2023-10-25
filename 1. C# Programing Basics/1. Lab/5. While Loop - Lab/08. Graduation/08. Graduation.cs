using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double avgGrade = 0.00;
            int clas = 0;

            while (clas < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                clas++;
                if (grade < 4)
                {
                    break;
                }

                avgGrade += grade;
            }

            avgGrade = avgGrade / 12;

            if (clas >= 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {avgGrade:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {clas} grade");
            }
        }
    }
}
