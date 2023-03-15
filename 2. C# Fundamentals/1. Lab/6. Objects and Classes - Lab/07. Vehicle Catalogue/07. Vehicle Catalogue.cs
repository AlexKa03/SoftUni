using _07._Vehicle_Catalogue;

class Program
{
    static void Main(string[] args)
    {
        VehicleCatalog vehicleCatalog = new VehicleCatalog();

        string command = Console.ReadLine();

        while (command != "end")
        {
            string[] data = command
                .Split("/", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string type = data[0];
            string brand = data[1];
            string model = data[2];

            if (type == "Car")
            {
                int horsePower = int.Parse(data[3]);

                Car car = new Car()
                {
                    Brand = brand,
                    Model = model,
                    HoursePower = horsePower
                };

                vehicleCatalog.Cars.Add(car);
            }
            else
            {
                int weight = int.Parse(data[3]);

                Truck truck = new Truck
                {
                    Brand = brand,
                    Model = model,
                    Weight = weight
                };

                vehicleCatalog.Trucks.Add(truck);
            }

            command = Console.ReadLine();
        }

        if (vehicleCatalog.Cars.Count > 0)
        {
            Console.WriteLine("Cars:");

            foreach (Car car in vehicleCatalog.Cars.OrderBy(car => car.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HoursePower}hp");
            }
        }
        if (vehicleCatalog.Trucks.Count > 0)
        {
            Console.WriteLine("Trucks:");

            foreach (Truck truck in vehicleCatalog.Trucks.OrderBy(truck => truck.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}