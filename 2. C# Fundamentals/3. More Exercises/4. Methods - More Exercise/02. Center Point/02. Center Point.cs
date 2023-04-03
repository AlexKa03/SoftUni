class Program
{
    static void Main(string[] args)
    {
        double xOne = double.Parse(Console.ReadLine());
        double yOne = double.Parse(Console.ReadLine());
        double xTwo = double.Parse(Console.ReadLine());
        double yTwo = double.Parse(Console.ReadLine());

        CloserToCenter(xOne, xTwo, yOne, yTwo);
    }

    static void CloserToCenter(double xOne, double xTwo, double yOne, double yTwo)
    {
        double distanceOne = Math.Sqrt((xOne * xOne) + (yOne * yOne));
        double distanceTwo = Math.Sqrt((xTwo * xTwo) + (yTwo * yTwo));

        Printer(distanceOne, distanceTwo, xOne, xTwo, yOne, yTwo);
    }

    static void Printer(double distanceOne, double distanceTwo,
                        double xOne, double xTwo, double yOne, double yTwo)
    {
        Console.WriteLine(distanceTwo < distanceOne ? $"({xTwo}, {yTwo})" :
                          distanceOne < distanceTwo ? $"({xOne}, {yOne})" :
                                                      $"({xOne}, {yOne})");
    }
}