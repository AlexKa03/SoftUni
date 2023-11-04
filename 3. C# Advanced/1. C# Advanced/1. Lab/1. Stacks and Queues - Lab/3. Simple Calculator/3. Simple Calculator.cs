class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        Stack<string> expression = new Stack<string>(input.Reverse());

        int result = int.Parse(expression.Pop());

        while (expression.Any())
        {
            string sign = expression.Pop();
            int number = int.Parse(expression.Pop());

            if (sign == "+")
            {
                result += number;
            }
            else if (sign == "-")
            {
                result -= number;
            }
        }

        Console.WriteLine(result);
    }
}