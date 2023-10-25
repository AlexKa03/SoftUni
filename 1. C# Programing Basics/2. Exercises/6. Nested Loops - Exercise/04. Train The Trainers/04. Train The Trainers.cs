using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();

            double gradeAvg = 0.00;
            int gradeCounter = 0;

            while (presentationName != "Finish")
            {
                double gradePresentation = 0.00;
                for (int i = 1; i <= judges; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeAvg += grade;
                    gradePresentation += grade;
                    gradeCounter++;
                }

                Console.WriteLine($"{presentationName} - {gradePresentation / judges:f2}.");

                presentationName = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {gradeAvg / gradeCounter:f2}.");
        }
    }
}
