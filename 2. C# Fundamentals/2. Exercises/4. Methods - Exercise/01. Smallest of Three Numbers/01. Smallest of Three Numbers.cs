class Program
{
    static void Main(string[] args)
    {
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        int numberThree = int.Parse(Console.ReadLine());

        SmallestNumber(numberOne, numberTwo, numberThree);
    }

    static void SmallestNumber(int a,  int b, int c)
    {
        int smallest = Math.Min(a, Math.Min(b, c));
        Console.WriteLine(smallest);
    }
}