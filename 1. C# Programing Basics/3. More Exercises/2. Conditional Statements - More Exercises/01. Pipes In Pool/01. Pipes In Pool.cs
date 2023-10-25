using System;

namespace _01._Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int pipeOne = int.Parse(Console.ReadLine());
            int pipeTwo = int.Parse(Console.ReadLine());
            double hoursOut = double.Parse(Console.ReadLine());

            double fillOne = pipeOne * hoursOut;
            double fillTwo = pipeTwo * hoursOut;
            double fillTotal = fillOne + fillTwo;

            if (volume >= fillTotal)
            {
                double percentageFill = (fillTotal / volume) * 100;
                double percentagePipeOne = (fillOne / fillTotal) * 100;
                double percentagePipeTwo = (fillTwo / fillTotal) * 100;

                Console.WriteLine($"The pool is {percentageFill:f2}% full. Pipe 1: {percentagePipeOne:f2}%. Pipe 2: {percentagePipeTwo:f2}%.");
            }
            else
            {
                double litersOver = fillTotal - volume;

                Console.WriteLine($"For {hoursOut} hours the pool overflows with {litersOver:f2} liters.");
            }
        }
    }
}
