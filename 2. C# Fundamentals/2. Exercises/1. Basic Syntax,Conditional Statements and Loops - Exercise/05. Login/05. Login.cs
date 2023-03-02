using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            for (int i = 1; i <= 4; i++)
            {
                string input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }
}
