class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        OrderCalculation(product, quantity);
    }

    static void OrderCalculation(string product, int quantity)
    {
        double order = 0;

        switch (product)
        {
            case "coffee":
                order = 1.50 * quantity;
                break;
            case "water":
                order = 1 * quantity;
                break;
            case "coke":
                order = 1.40 * quantity;
                break;
            case "snacks":
                order = 2 * quantity;
                break;
        }

        Console.WriteLine($"{order:f2}");
    }
}