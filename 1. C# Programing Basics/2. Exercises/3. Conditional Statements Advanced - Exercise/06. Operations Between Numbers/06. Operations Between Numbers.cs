using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operand = Console.ReadLine();
            double result = 0.00;
            string oddOrEven = "";


            if (n2 != 0)
            {
                if (operand == "+" || operand == "-" || operand == "*")
                {
                    if (operand == "+")
                    {
                        result = n1 + n2;
                        if (result % 2 == 0)
                        {
                            oddOrEven = "even";
                        }
                        else
                        {
                            oddOrEven = "odd";
                        }
                    }
                    else if (operand == "-")
                    {
                        result = n1 - n2;
                        if (result % 2 == 0)
                        {
                            oddOrEven = "even";
                        }
                        else
                        {
                            oddOrEven = "odd";
                        }
                    }
                    else if (operand == "*")
                    {
                        result = n1 * n2;
                        if (result % 2 == 0)
                        {
                            oddOrEven = "even";
                        }
                        else
                        {
                            oddOrEven = "odd";
                        }
                    }

                    Console.WriteLine($"{n1} {operand} {n2} = {result} - {oddOrEven}");
                }
                else if (operand == "/")
                {
                    result = n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
                else
                {
                    result = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
            }
            else
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
        }
    }
}
