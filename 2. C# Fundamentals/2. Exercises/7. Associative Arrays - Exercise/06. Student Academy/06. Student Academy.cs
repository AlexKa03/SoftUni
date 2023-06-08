class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<double>> academy = new Dictionary<string, List<double>>();

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string student = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            if (academy.ContainsKey(student))
            {
                academy[student][0]++;
                academy[student][1] += grade;
            }
            else
            {
                academy.Add(student, new List<double>() { 1, grade });
            }
        }

        foreach (var student in academy)
        {
            if (student.Value[1] / student.Value[0] >= 4.5)
            {
                Console.WriteLine($"{student.Key} -> {student.Value[1] / student.Value[0]:f2}");
            }
        }
    }
}