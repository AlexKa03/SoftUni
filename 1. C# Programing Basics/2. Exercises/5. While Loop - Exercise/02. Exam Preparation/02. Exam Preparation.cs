using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxPoorGrades = int.Parse(Console.ReadLine());

            double avgGrade = 0.00;
            int poorGradesCounter = 0;
            int problemsCounter = 0;
            string lastProblem = "";
            bool isFailed = false;

            while (maxPoorGrades > poorGradesCounter)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isFailed = true;
                    break;
                }
                double grade = double.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    poorGradesCounter++;
                }

                avgGrade += grade;
                problemsCounter++;
                lastProblem = problemName;
            }

            if (isFailed)
            {
                Console.WriteLine($"Average score: {avgGrade / problemsCounter:f2}");
                Console.WriteLine($"Number of problems: {problemsCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {maxPoorGrades} poor grades.");
            }
        }
    }
}
