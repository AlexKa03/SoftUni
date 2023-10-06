class Program
{
    static void Main(string[] args)
    {
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double[] numbers = new double[input.Length];

            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char[] symbols = input[i].ToCharArray();
                string number = string.Empty;
                for (int j = 1; j < input[i].Length - 1; j++)
                {
                    number += symbols[j].ToString();
                }

                numbers[i] = int.Parse(number);

                if (char.IsUpper(symbols[0]))
                {
                    numbers[i] /= symbols[0] - 64;
                }
                else if (char.IsLower(symbols[0]))
                {
                    symbols[0] = char.ToUpper(symbols[0]);
                    numbers[i] *= symbols[0] - 64;
                }

                int lastIndex = symbols.Length - 1;

                if (char.IsUpper(symbols[lastIndex]))
                {
                    numbers[i] -= symbols[lastIndex] - 64;
                }
                else if (char.IsLower(symbols[lastIndex]))
                {
                    symbols[lastIndex] = char.ToUpper(symbols[lastIndex]);
                    numbers[i] += symbols[lastIndex] - 64;
                }

                sum += numbers[i];
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}