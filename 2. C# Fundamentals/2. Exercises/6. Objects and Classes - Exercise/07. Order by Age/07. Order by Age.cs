using _07._Order_by_Age;

class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();

        List<Person> person = new List<Person>();

        while (command != "End")
        {
            string[] data = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string name = data[0];
            string id = data[1];
            int age = int.Parse(data[2]);

            Person currentPerson = new Person(name, id, age);

            foreach (var human in person)
            {
                if (human.ID == id)
                {
                    person.Remove(human);
                }
            }

            person.Add(currentPerson);

            command = Console.ReadLine();
        }

        foreach (var human in person
            .OrderBy(x => x.Age))
        {
            Console.WriteLine($"{human.Name} with ID: {human.ID} is {human.Age} years old.");
        }
    }
}