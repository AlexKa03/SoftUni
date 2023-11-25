class Program
{
    static void Main(string[] args)
    {
        int foodForDay = int.Parse(Console.ReadLine());

        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Queue<int> orders = new Queue<int>(input);
        Console.WriteLine(orders.Max());

        while (orders.Count > 0)
        {
            int currentOrder = orders.Peek();
            if (foodForDay >= currentOrder)
            {
                orders.Dequeue();
                foodForDay -= currentOrder;
            }
            else
            {
                break;
            }
        }

        if (orders.Count == 0)
        {
            Console.WriteLine("Orders complete");
        }
        else
        {
            Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
        }
    }
}