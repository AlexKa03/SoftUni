class Program
{
    static void Main(string[] args)
    {
        double xOne = double.Parse(Console.ReadLine());
        double yOne = double.Parse(Console.ReadLine());
        double xTwo = double.Parse(Console.ReadLine());
        double yTwo = double.Parse(Console.ReadLine());

        double xThree = double.Parse(Console.ReadLine());
        double yThree = double.Parse(Console.ReadLine());
        double xFour = double.Parse(Console.ReadLine());
        double yFour = double.Parse(Console.ReadLine());

        double lineOne = GetDistance(xOne, yOne, xTwo, yTwo);
        double lineTwo = GetDistance(xThree, yThree, xFour, yFour);

        if (lineOne >= lineTwo)
        {
            bool pointCloserToZero = CloserToZero(xOne, yOne, xTwo, yTwo);

            if (pointCloserToZero)
            {
                Console.WriteLine($"({xOne}, {yOne})({xTwo}, {yTwo})");
            }
            else
            {
                Console.WriteLine($"({xTwo}, {yTwo})({xOne}, {yOne})");
            }
        }
        else
        {
            bool pointCloserToZero = CloserToZero(xThree, yThree, xFour, yFour);

            if (pointCloserToZero)
            {
                Console.WriteLine($"({xThree}, {yThree})({xFour}, {yFour})");
            }
            else
            {
                Console.WriteLine($"({xFour}, {yFour})({xThree}, {yThree})");
            }
        }
    }

    static double GetDistance(double xOne, double yOne, double xTwo, double yTwo)
    {
        double sideOne = Math.Abs(xOne - xTwo);
        double sideTwo = Math.Abs(yOne - yTwo);

        return Math.Sqrt((sideOne * sideOne) + (sideTwo * sideTwo));
    }

    static bool CloserToZero(double xOne, double yOne, double xTwo, double yTwo)
    {
        double hypotenuseOne = CalculateHypotenuse(xOne, yOne);
        double hypotenuseTwo = CalculateHypotenuse(xTwo, yTwo);

        if (hypotenuseOne > hypotenuseTwo)
        {
            return false;
        }

        return true;
    }

    static double CalculateHypotenuse(double a, double b)
    {
        return Math.Sqrt((a * a) + (b * b));
    }
}
