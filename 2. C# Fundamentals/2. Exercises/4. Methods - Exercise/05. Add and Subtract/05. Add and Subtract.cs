class Program
{
    static void Main(string[] args)
    {
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());
        int numThree = int.Parse(Console.ReadLine());

        int sum = Sum(numOne, numTwo);
        int subtract = Subtract(sum, numThree);

        Console.WriteLine(subtract);
    }

    static int Sum(int a, int b)
    {
        return (a + b);
    }

    static int Subtract(int sum, int c)
    {
        return sum - c;
    }
}