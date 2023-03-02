using System;
using System.Linq;

namespace _04._Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            Console.WriteLine(reversed);

            /*
            string normalString = Console.ReadLine();
            string reversedString = new string(normalString
                .Reverse()
                .ToArray());
            Console.WriteLine(reversedString);
            */
        }
    }
}
