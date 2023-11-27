class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<decimal>> gradeBook = new Dictionary<string, List<decimal>>();

        int iterations = int.Parse(Console.ReadLine());

        for (int i = 0; i < iterations; i++)
        {
            string[] input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

            string name = input[0];
            decimal grade = decimal.Parse(input[1]);

            if (!gradeBook.ContainsKey(name))
            {
                gradeBook.Add(name, new List<decimal>());
            }

            gradeBook[name].Add(grade);
        }

        foreach (var student in gradeBook)
        {
            decimal gradesTotal = 0;
            int counter = 0;

            Console.Write($"{student.Key} -> ");

            foreach (var grade in student.Value)
            {
                Console.Write($"{grade:f2} ");

                gradesTotal += grade;
                counter++;
            }

            Console.WriteLine($"(avg: {gradesTotal / counter :f2})");
        }
    }
}