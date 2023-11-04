using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();

        Queue<string> customersQueue = new Queue<string>();

        while (command != "End")
        {
            if (command == "Paid")
            {
                foreach (var custumer in customersQueue)
                {
                    Console.WriteLine(custumer);
                }

                customersQueue.Clear();
            }
            else
            {
                customersQueue.Enqueue(command);
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"{customersQueue.Count} people remaining.");
    }
}