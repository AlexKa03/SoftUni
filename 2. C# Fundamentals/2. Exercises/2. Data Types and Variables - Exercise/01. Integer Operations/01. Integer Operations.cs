class Program
{
    static void Main()
    {
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());

            int sum = ((numOne + numTwo) / numThree) * numFour;

            Console.WriteLine(sum);
        }
    }
}
