using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        int greenLightLength = int.Parse(Console.ReadLine());

        string command = Console.ReadLine();
        int passedCars = 0;
        Queue<string> customersQueue = new Queue<string>();

        while (command != "end")
        {
            if (command == "green")
            {
                int counter = greenLightLength;

                while (counter > 0 && customersQueue.Count > 0)
                {
                    Console.WriteLine($"{customersQueue.Dequeue()} passed!");
                    passedCars++;
                    counter--;
                }
            }
            else
            {
                customersQueue.Enqueue(command);
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"{passedCars} cars passed the crossroads.");
    }
}