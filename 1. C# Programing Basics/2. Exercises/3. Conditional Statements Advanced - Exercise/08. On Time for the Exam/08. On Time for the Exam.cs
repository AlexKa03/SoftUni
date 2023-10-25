using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minuteArrive = int.Parse(Console.ReadLine());

            int examTime = (hourExam * 60) + minuteExam;
            int arriveTime = (hourArrive * 60) + minuteArrive;
            int diff = 0;

            if (arriveTime > examTime)
            {
                diff = arriveTime - examTime;
                if (diff > 0 && diff < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{diff} minutes after the start");
                }
                else
                {
                    int hour = diff / 60;
                    int minutes = diff % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hour}:{minutes:00} hours after the start");
                }
            }
            else if (examTime - arriveTime >= 0 && examTime - arriveTime <= 30)
            {
                diff = examTime - arriveTime;
                if (diff == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{diff} minutes before the start");
                }
            }
            else
            {
                diff = examTime - arriveTime;
                if (diff > 30 && diff < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{diff} minutes before the start");
                }
                else
                {
                    int hour = diff / 60;
                    int minutes = diff % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hour}:{minutes:00} hours before the start");
                }
            }
        }
    }
}
