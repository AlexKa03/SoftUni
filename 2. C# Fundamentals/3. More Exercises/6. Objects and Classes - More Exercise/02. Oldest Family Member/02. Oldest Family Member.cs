class Program
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        Family familyMembers = new Family();

        for (int i = 0; i < lines; i++)
        {
            string[] data = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string name = data[0];
            int age = int.Parse(data[1]);

            Person person = new Person { Name = name, Age = age };
            familyMembers.AddMember(person);
        }

        Person oldestMember = familyMembers.GetOldestMember();

        Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
    }
}

class Family
{
    private List<Person> persons = new List<Person>();

    public void AddMember(Person person)
    {
        persons.Add(person);
    }

    public Person GetOldestMember()
    {
        Person oldestMember = persons[0];

        foreach(Person memeber in persons)
        {
            if (memeber.Age > oldestMember.Age)
            {
                oldestMember = memeber;
            }
        }

        return oldestMember;
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}