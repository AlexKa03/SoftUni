class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();

        while (command != "END")
        {
            int number = int.Parse(command);

            bool isPalindrome = PalindromeChecker(number);
            PrintResult(isPalindrome);

            command = Console.ReadLine();
        }
    }

    static bool PalindromeChecker(int number)
    {
        string reversed = string.Empty;
        int original = number;

        while (number > 0)
        {
            reversed += number % 10;
            number /= 10;
        }

        int check = int.Parse(reversed);

        if (original == check)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void PrintResult(bool isPalindrome)
    {
        Console.WriteLine(isPalindrome.ToString().ToLower());
    }
}