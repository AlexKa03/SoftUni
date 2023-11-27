class Program
{
    static void Main(string[] args)
    {
        HashSet<string> parkingLot = new HashSet<string>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "END")
            {
                break;
            }

            string[] cmd = input
                .Split(", ");

            string action = cmd[0];
            string number = cmd[1];

            if (action == "IN")
            {
                parkingLot.Add(number);
            }
            else if (action == "OUT")
            {
                parkingLot.Remove(number);
            }
        }

        if (parkingLot.Any())
        {
            Console.WriteLine(string.Join("\n", parkingLot));
        }
        else
        {
            Console.WriteLine("Parking Lot is Empty");
        }
    }
}