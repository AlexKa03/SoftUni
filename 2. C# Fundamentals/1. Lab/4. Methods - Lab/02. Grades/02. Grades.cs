class Program
{
    static void Main(string[] args)
    {
        double grade = double.Parse(Console.ReadLine());

        string gradeLetters = string.Empty;

        CheckGrades(grade, gradeLetters);
    }

    static void CheckGrades(double grade, string gradeLetters)
    {
        if (grade >= 2 && grade < 3)
        {
            Console.WriteLine("Fail");
        }
        else if (grade >= 3 && grade < 3.50)
        {
            Console.WriteLine("Poor");
        }
        else if (grade >= 3.50 && grade < 4.50)
        {
            Console.WriteLine("Good");
        }
        else if (grade >= 4.50 && grade < 5.50)
        {
            Console.WriteLine("Very good");
        }
        else if (grade >= 5.50 && grade <= 6)
        {
            Console.WriteLine("Excellent");
        }
    }
}