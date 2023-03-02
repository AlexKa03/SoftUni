class Program
{
    static void Main()
    {
        {
            int number = int.Parse(Console.ReadLine());

            int digits = number;
            int sum = 0;
              
            while (number > 0) 
            {
                digits = number % 10;
                number /= 10;
                sum += digits;
            }

            Console.WriteLine(sum);
        }
    }
}
