class Program
{
    static void Main(string[] args)
    {
        double numberOne = double.Parse(Console.ReadLine());
        double numberTwo = double.Parse(Console.ReadLine());

        if (Math.Abs(numberOne - numberTwo) < 0.000001)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}