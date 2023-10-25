using System;

namespace _04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            double gradeTwo = 0;
            double gradeThree = 0;
            double gradeFour = 0;
            double gradeFive = 0;
            double gradeAverage = 0;

            for (int i = 1; i <= studentsCount; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 2 && grade <= 2.99)
                {
                    gradeTwo++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    gradeThree++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    gradeFour++;
                }
                else if (grade >= 5)
                {
                    gradeFive++;
                }

                gradeAverage += grade;
            }

            gradeTwo = 100 * (gradeTwo / studentsCount);
            gradeThree = 100 * (gradeThree / studentsCount);
            gradeFour = 100 * (gradeFour / studentsCount);
            gradeFive = 100 * (gradeFive / studentsCount);
            gradeAverage = gradeAverage / studentsCount;

            Console.WriteLine($"Top students: {gradeFive:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {gradeFour:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {gradeThree:f2}%");
            Console.WriteLine($"Fail: {gradeTwo:f2}%");
            Console.WriteLine($"Average: {gradeAverage:f2}");
        }
    }
}
