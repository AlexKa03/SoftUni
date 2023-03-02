class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();

        if (type == "string")
        {
            string valueOne = Console.ReadLine();
            string valueTwo = Console.ReadLine();

            string result = GetMaxString(valueOne, valueTwo);
            Console.WriteLine(result);
        }
        else if (type == "int")
        {
            int valueOne = int.Parse(Console.ReadLine());
            int valueTwo = int.Parse(Console.ReadLine());

            int result = GetMaxInt(valueOne, valueTwo);
            Console.WriteLine(result);
        }
        else if (type == "char")
        {
            char valueOne = char.Parse(Console.ReadLine());
            char valueTwo = char.Parse(Console.ReadLine());

            char result = GetMaxChar(valueOne, valueTwo);
            Console.WriteLine(result);
        }

    }

    static string GetMaxString(string valueOne, string valueTwo)
    {
        int comparison = valueOne.CompareTo(valueTwo);
        if (comparison > 0)
        {
            return valueOne;
        }
        else
        {
            return valueTwo;
        }
    }
    static int GetMaxInt(int valueOne, int valueTwo)
    {
        if (valueOne > valueTwo)
        {
            return valueOne;
        }
        else
        {
            return valueTwo;
        }
    }
    static char GetMaxChar(char valueOne, char valueTwo)
    {
        if (valueOne > valueTwo)
        {
            return valueOne;
        }
        else
        {
            return valueTwo;
        }
    }
}