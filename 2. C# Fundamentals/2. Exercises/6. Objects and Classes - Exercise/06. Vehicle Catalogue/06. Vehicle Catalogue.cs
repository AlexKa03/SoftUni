using _06._Vehicle_Catalogue;

class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();

        List<Catalogue> vehicle = new List<Catalogue>();

        while (command != "End")
        {
            string[] data = command
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string vehicleType = data[0];
            string model = data[1];
            string color = data[2];
            int horsePower = int.Parse(data[3]);

            Catalogue currentVehicle = new Catalogue(vehicleType, model, color, horsePower);

            vehicle.Add(currentVehicle);

            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        while (command != "Close the Catalogue")
        {
            string brand = command;

            List<Catalogue> selectedVehicle = vehicle
                .Where(x => x.Model == brand)
                .ToList();

            foreach (var auto in selectedVehicle)
            {
                string capitalized = char.ToUpper(auto.VehicleType[0]) + auto.VehicleType.Substring(1);

                Console.WriteLine($"Type: {capitalized}\nModel: {auto.Model}\nColor: {auto.Color}\nHorsepower: {auto.HorsePower}");
            }

            command = Console.ReadLine();
        }

        List<Catalogue> cars = vehicle
            .Where(x => x.VehicleType == "car")
            .ToList();
        double carsHP = 0;
        double carsCounter = 0;

        foreach (var car in cars)
        {
            carsHP += car.HorsePower;
            carsCounter++;
        }
        carsHP /= carsCounter;

        List<Catalogue> trucks = vehicle
            .Where(x => x.VehicleType == "truck")
            .ToList();
        double trucksHP = 0;
        double trucksCounter = 0;

        foreach (var truck in trucks)
        {
            trucksHP += truck.HorsePower;
            trucksCounter++;
        }
        trucksHP /= trucksCounter;


        if (carsHP > 0)
        {
            Console.WriteLine($"Cars have average horsepower of: {carsHP:f2}.");
        }
        else
        {
            Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
        }

        if (trucksHP > 0)
        {
            Console.WriteLine($"Trucks have average horsepower of: {trucksHP:f2}.");
        }
        else
        {
            Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
        }
    }
}