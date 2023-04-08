class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string[] carInfo = Console.ReadLine().Split();
            string model = carInfo[0];
            int engineSpeed = int.Parse(carInfo[1]);
            int enginePower = int.Parse(carInfo[2]);
            int cargoWeight = int.Parse(carInfo[3]);
            string cargoType = carInfo[4];

            Engine engine = new Engine(engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoWeight, cargoType);

            Car car = new Car(model, engine, cargo);
            cars.Add(car);
        }

        string command = Console.ReadLine();

        if (command == "fragile")
        {
            foreach (var car in cars)
            {
                if (car.Cargo.Type == "fragile" && car.Cargo.Weight < 1000)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
        else if (command == "flamable")
        {
            foreach (var car in cars)
            {
                if (car.Cargo.Type == "flamable" && car.Engine.Power > 250)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}

class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }

    public Car(string model, Engine engine, Cargo cargo)
    {
        Model = model;
        Engine = engine;
        Cargo = cargo;
    }
}

class Engine
{
    public int Speed { get; set; }
    public int Power { get; set; }

    public Engine(int speed, int power)
    {
        Speed = speed;
        Power = power;
    }
}

class Cargo
{
    public int Weight { get; set; }
    public string Type { get; set; }

    public Cargo(int weight, string type)
    {
        Weight = weight;
        Type = type;
    }
}