using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();

            int booksCounter = 0;
            bool isBookFound = false;
            string nextBook = Console.ReadLine();

            while (nextBook != "No More Books")
            {
                if (nextBook == favoriteBook)
                {
                    isBookFound = true;
                    break;
                }

                booksCounter++;
                nextBook = Console.ReadLine();
            }

            if (isBookFound)
            {
                Console.WriteLine($"You checked {booksCounter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {booksCounter} books.");
            }
        }
    }
}
