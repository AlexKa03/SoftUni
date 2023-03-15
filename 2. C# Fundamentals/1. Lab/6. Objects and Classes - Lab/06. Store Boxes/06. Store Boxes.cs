using _06._Store_Boxes;

class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();

        List<Box> boxes = new List<Box>();

        while (command != "end")
        {
            string[] data = command
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int serialNumber = int.Parse(data[0]);
            string itemName = data[1];
            int itemQuantity = int.Parse(data[2]);
            double itemPrice = double.Parse(data[3]);
            double boxPrice = itemQuantity * itemPrice;

            Box box = new Box()
            {
                SerialNumber = serialNumber,
                ItemName = new Item()
                {
                    Name = itemName,
                    Price = itemPrice
                },
                ItemQuantity = itemQuantity,
                BoxPrice = boxPrice
            };

            boxes.Add(box);

            command = Console.ReadLine();
        }

        boxes = boxes
            .OrderByDescending(x => x.BoxPrice)
            .ToList();

        foreach (var box in boxes)
        {
            Console.WriteLine($"{box.SerialNumber}\n-- {box.ItemName.Name} - ${box.ItemName.Price:f2}: {box.ItemQuantity}\n-- ${box.BoxPrice:f2}");
        }
    }
}