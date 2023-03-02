class Program
{
    static void Main(string[] args)
    {
        char inputOne = char.Parse(Console.ReadLine());
        char inputTwo = char.Parse(Console.ReadLine());

        CharsBetween(inputOne, inputTwo);
    }

    static void CharsBetween(char inputOne, char inputTwo)
    {
        if (inputOne < inputTwo)
        {
            for (int @char = inputOne + 1; @char < inputTwo; @char++)
            {
                Console.Write($"{(char)@char} ");
            }
        }
        else
        {
            for (int @char = inputTwo + 1; @char < inputOne; @char++)
            {
                Console.Write($"{(char)@char} ");
            }
        }
    }
}