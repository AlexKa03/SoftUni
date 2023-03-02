class Program
{
    static void Main(string[] args)
    {
        string action = Console.ReadLine();
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());

        switch (action) 
        {
            case "add":
                Add(numOne, numTwo);
                break;
            case "multiply":
                Multiply(numOne, numTwo);
                break;
            case "subtract":
                Subtract(numOne, numTwo);
                break;
            case "divide":
                Divide(numOne, numTwo);
                break;
        }
    }

    static void Add(int numOne, int numTwo)
    {
        Console.WriteLine(numOne + numTwo);
    }
    static void Multiply(int numOne, int numTwo)
    {
        Console.WriteLine(numOne * numTwo);
    }
    static void Subtract(int numOne, int numTwo)
    {
        Console.WriteLine(numOne - numTwo);
    }
    static void Divide(int numOne, int numTwo)
    {
        Console.WriteLine(numOne / numTwo);
    }
}