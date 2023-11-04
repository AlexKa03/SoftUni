using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string rawPassword = Console.ReadLine();

        while (true)
        {
            string commandLine = Console.ReadLine();
            if (commandLine == "Done")
            {
                break;
            }

            string[] commandParts = commandLine.Split(' ');
            string command = commandParts[0];

            if (command == "TakeOdd")
            {
                char[] result = new char[rawPassword.Length / 2];
                for (int i = 1, j = 0; i < rawPassword.Length; i += 2, j++)
                {
                    result[j] = rawPassword[i];
                }
                rawPassword = new string(result);

                Console.WriteLine(rawPassword);
            }
            else if (command == "Cut")
            {
                int index = int.Parse(commandParts[1]);
                int length = int.Parse(commandParts[2]);

                string substring = rawPassword.Substring(index, length);
                int firstOccurrence = rawPassword.IndexOf(substring);
                if (firstOccurrence != -1)
                {
                    rawPassword = rawPassword.Remove(firstOccurrence, length);
                }
                Console.WriteLine(rawPassword);
            }
            else if (command == "Substitute")
            {
                string substring = commandParts[1];
                string substitute = commandParts[2];

                if (rawPassword.Contains(substring))
                {
                    rawPassword = rawPassword.Replace(substring, substitute);
                    Console.WriteLine(rawPassword);
                }
                else
                {
                    Console.WriteLine("Nothing to replace!");
                }
            }
        }

        Console.WriteLine($"Your password is: {rawPassword}");
    }
}