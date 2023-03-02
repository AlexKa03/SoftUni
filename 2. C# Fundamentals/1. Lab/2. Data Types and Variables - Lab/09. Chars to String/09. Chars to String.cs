class Program
{
    static void Main()
    {
        char lineOne = char.Parse(Console.ReadLine());
        char lineTwo = char.Parse(Console.ReadLine());
        char lineThree = char.Parse(Console.ReadLine());

        Console.WriteLine(lineOne.ToString() + lineTwo.ToString() + lineThree.ToString());
    }
}