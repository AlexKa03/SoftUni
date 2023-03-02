class Program
{
    static void Main(string[] args)
    {
        double baseNumber = double.Parse(Console.ReadLine());
        int powerNumber = int.Parse(Console.ReadLine());

        double result = ToThePower(baseNumber, powerNumber);
        Console.WriteLine(result);
    }

    static double ToThePower(double baseNumber, int powerNumber)
    {
        return Math.Pow(baseNumber, powerNumber);
    }
}