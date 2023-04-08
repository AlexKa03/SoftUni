class Program
{
    static void Main(string[] args)
    {
        int carsCount = int.Parse(Console.ReadLine());

        Car[] cars = new Car[carsCount];

        for (int i = 0; i < carsCount; i++)
        {
            string[] data = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string model = data[0];
            double fuelAmount = double.Parse(data[1]);
            double fuelConsuption = double.Parse(data[2]);

            cars[i] = new Car(model, fuelAmount, fuelConsuption);
        }

        string command = Console.ReadLine();

        while (command != "End")
        {
            string[] data = command.Split();

            string carModel = data[1];
            double distanceToTravel = double.Parse(data[2]);

            Car car = Array.Find(cars, x => x.Model == carModel);

            car.Drive(distanceToTravel);

            command = Console.ReadLine();
        }

        foreach (Car car in cars)
        {
            car.Printer();
        }
    }
}

class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsuption;
    private double distanceTraveled;

    public Car(string model, double fuelAmount, double fuelConsuption)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsuption = fuelConsuption;
        this.distanceTraveled = 0;
    }

    public string Model
    {
        get { return model; }
    }
    public double FuelAmount
    {
        get { return fuelAmount; }
    }

    public double DistanceTraveled
    {
        get { return distanceTraveled; }
    }

    public void Drive(double distanceToTravel)
    {
        double requiredFuel = distanceToTravel * fuelConsuption;

        if (requiredFuel <= fuelAmount)
        {
            fuelAmount -= requiredFuel;
            distanceTraveled += distanceToTravel;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

    public void Printer()
    {
        Console.WriteLine($"{model} {fuelAmount:F2} {distanceTraveled}");
    }
}