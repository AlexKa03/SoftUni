class Program
{
    static void Main(string[] args)
    {
        string password = Console.ReadLine().ToLower();

        int check = 0;

        check = LengthChecker(password, check);
        check = LetersDigitsChecker(password, check);
        check = MinimumDigitsChecker(password, check);
        Check(check);
    }

    static int LengthChecker(string password, int check)
    {
        if (password.Length >= 6 && password.Length <= 10)
        {
            check++;
            return check;
        }
        else
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
            return check;
        }
    }

    static int LetersDigitsChecker(string password, int check)
    {
        for (int i = 0; i < password.Length; i++)
        {
            bool isntLetter = true;

            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                if (letter == password[i])
                {
                    isntLetter = false;
                    break;
                }
            }

            if (int.TryParse(password[i].ToString(), out int digit))
            {
            }
            else if (isntLetter)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return check;
            }
        }

        check++;
        return check;
    }

    static int MinimumDigitsChecker(string password, int check)
    {
        int counter = 0;

        for (int i = 0; i < password.Length; i++)
        {
            if (int.TryParse(password[i].ToString(), out int digit))
            {
                counter++;
            }
        }

        if (counter >= 2)
        {
            check++;
            return check;
        }
        else
        {
            Console.WriteLine("Password must have at least 2 digits");
        }

        return check;
    }

    static void Check(int check)
    {
        if (check >= 3)
        {
            Console.WriteLine("Password is valid");
        }
    }
}