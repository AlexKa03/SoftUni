﻿using System;

namespace _06._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < tabs; i++)
            {
                if (salary > 0)
                {
                    string tab = Console.ReadLine();
                    switch (tab)
                    {
                        case "Facebook":
                            salary -= 150;
                            break;
                        case "Instagram":
                            salary -= 100;
                            break;
                        case "Reddit":
                            salary -= 50;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
        }
    }
}
