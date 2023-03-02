class Program
{
    static void Main(string[] args)
    {
        int numberOne = int.Parse(Console.ReadLine());
        string symbol = Console.ReadLine();
        int numberTwo = int.Parse(Console.ReadLine());

        double result = Calculate(numberOne, numberTwo, symbol);
        Console.WriteLine(result);
    }

    static double Calculate(int  a, int b, string symbol)
    {
        double result = 0;

        switch (symbol)
        {
            case "*":
                result = a * b;
                break;
            case "+":
                result = a + b;
                break;
            case "/":
                result = a / b;
                break;
            case "-":
                result = a - b;
                break;
        }

        return result;
    }
}