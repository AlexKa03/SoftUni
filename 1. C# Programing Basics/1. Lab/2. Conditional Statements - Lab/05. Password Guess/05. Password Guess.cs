using System;

namespace _05._Password_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            if (pass != "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Wrong password!");
            }
            else
            {
                Console.WriteLine("Welcome");
            }

        }
    }
}
