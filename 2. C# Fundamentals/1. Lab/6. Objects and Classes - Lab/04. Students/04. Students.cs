using _04._Students;

class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();

        List<Student> students = new List<Student>();

        while (command != "end")
        {
            string[] data = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstname = data[0];
            string lastName = data[1];
            int age = int.Parse(data[2]);
            string homeTown = data[3];

            Student student = new Student()
            {
                FirstName = firstname,
                LastName = lastName,
                Age = age,
                HomeTown = homeTown
            };

            students.Add(student);

            command = Console.ReadLine();
        }

        string town = Console.ReadLine();

        foreach (var student in students)
        {
            if (student.HomeTown == town)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}