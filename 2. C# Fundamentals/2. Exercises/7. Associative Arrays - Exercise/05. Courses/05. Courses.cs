class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

        while (true)
        {
            string[] command = Console.ReadLine()
                .Split(" : ")
                .ToArray();

            string courseName = command[0];

            if (courseName == "end")
            {
                break;
            }

            string student = command[1];

            if (courses.ContainsKey(courseName))
            {
                courses[courseName].Add(student);
            }
            else
            {
                courses.Add(courseName, new List<string>() { student });
            }
        }

        foreach (var course in courses)
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count} \n-- { string.Join("\n-- ", course.Value)}");
        }
    }
}