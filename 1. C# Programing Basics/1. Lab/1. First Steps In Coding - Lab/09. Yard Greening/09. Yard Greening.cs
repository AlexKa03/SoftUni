class Program
{
    static void Main(string[] args)
    {
        double space = double.Parse(Console.ReadLine());

        double total = space * 7.61;

        double discount = total * 0.18;

        Console.WriteLine($"The final price is: {total - discount} lv.\nThe discount is: {discount} lv.");
    }
}