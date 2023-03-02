class Program
{
    static void Main()
    {
        {
            int peoples = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling((double)peoples / capacity);

            Console.WriteLine(courses);
        }
    }
}
