class Program
{
    static void Main(string[] args)
    {
        string[] usernames = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries);
        bool isValid = false;

        foreach (string username in usernames)
        {
            if (username.Length >= 3 && username.Length <= 16)
            {
                foreach(char c in username)
                {
                    if (char.IsDigit(c)) { isValid = true; }
                    else if (char.IsLetter(c)) { isValid = true; }
                    else if (c == '_') { isValid = true; }
                    else if (c == '-') { isValid = true; }
                    else 
                    { 
                        isValid = false;
                        break; 
                    }
                }

                if (isValid)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}