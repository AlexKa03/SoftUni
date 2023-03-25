using _04._Students;

class Program
{
    static void Main(string[] args)
    {
        int studentsTotal = int.Parse(Console.ReadLine());

        List<Student> students = new List<Student>();

        for (int i = 0; i < studentsTotal; i++)
        {
            string[] data = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string firstName = data[0];
            string lastName = data[1];
            double grade = double.Parse(data[2]);

            var student = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                Grade = grade
            };

            students.Add(student);
        }

        foreach (Student student in students.OrderByDescending(x => x.Grade))
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
        }
    }
}