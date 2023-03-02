using System;

namespace _05._Month_Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthNumber = int.Parse(Console.ReadLine());
            string monthLetters;

            switch (monthNumber) 
            {
                case 1:
                    monthLetters = "January";
                    break;
                case 2:
                    monthLetters = "February";
                    break;
                case 3:
                    monthLetters = "March";
                    break;
                case 4:
                    monthLetters = "April";
                    break;
                case 5:
                    monthLetters = "May";
                    break;
                case 6:
                    monthLetters = "June";
                    break;
                case 7:
                    monthLetters = "July";
                    break;
                case 8:
                    monthLetters = "August";
                    break;
                case 9:
                    monthLetters = "September";
                    break;
                case 10:
                    monthLetters = "October";
                    break;
                case 11:
                    monthLetters = "November";
                    break;
                case 12:
                    monthLetters = "December";
                    break;
                default:
                    monthLetters = "Error!";
                    break;
            }

            Console.WriteLine(monthLetters);
        }
    }
}
