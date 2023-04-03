using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());
        int numThree = int.Parse(Console.ReadLine());

        int result = MultiplyWithFor(numOne, numTwo, numThree);
        Printer(result);
    }

    static int MultiplyWithFor(int numOne, int numTwo, int numThree)
    {
        int result = 0;

        for (int i = 0; i < numOne; i++)
        {
            for (int j = 0; j < numTwo; j++)
            {
                result += numThree;
            }
        }

        return result;
    }

    static void Printer(int result)
    {
        if (result >= 0)
        {
            Console.WriteLine("positive");
        }
        else
        {
            Console.WriteLine("negative");
        }
    }
}