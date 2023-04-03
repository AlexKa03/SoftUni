class Program
{
    static void Main(string[] args)
    {
        string variable = Console.ReadLine();
        string data = Console.ReadLine();

        int numberI = 0;
        double numberD = 0.00;

        switch (variable)
        {
            case "int":
                numberI = int.Parse(data);
                Printer(EditData(numberI));
                break;

            case "real":
                numberD = double.Parse(data);
                Printer(EditData(numberD));
                break;

            case "string":
                Printer(data); 
                break;
        }   
    }
    static void Printer(int number)
    {
        Console.WriteLine(number);
    }
    static void Printer(double number)
    {
        Console.WriteLine($"{number:f2}");
    }
    static void Printer(string text)
    {
        Console.WriteLine($"${text}$");
    }

    static int EditData(int number)
    {
        return number * 2;
    }

    static double EditData(double number)
    {
        return number * 1.5;
    }
}