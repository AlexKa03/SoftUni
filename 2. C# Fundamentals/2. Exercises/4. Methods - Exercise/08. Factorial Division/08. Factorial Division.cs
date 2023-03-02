class Program
{
    static void Main(string[] args)
    {
        double numberOne = double.Parse(Console.ReadLine());
        double numberTwo = double.Parse(Console.ReadLine());

        double factorialOne = CalculateFactorial(numberOne);
        double factorialTwo = CalculateFactorial(numberTwo);

        double result = DivideFactorials(factorialOne, factorialTwo);

        PrintResult(result);
    }

    static double CalculateFactorial(double number)
    {
        double factorial = 1;

        for (double i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    static double DivideFactorials(double factorialOne, double factorialTwo)
    {
        return factorialOne / factorialTwo;
    }

    static void PrintResult(double result)
    {
        Console.WriteLine($"{result:f2}");
    }
}