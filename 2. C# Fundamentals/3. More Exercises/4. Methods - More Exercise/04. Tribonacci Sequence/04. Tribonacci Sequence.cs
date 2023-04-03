class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        int[] numbers = new int[num];
        int sum = 0;

        for (int i = 0; i < num; i++)
        {
            numbers[i] = Tribonacci(i, numbers, sum);
        }

        Printer(numbers);
    }

    static int Tribonacci(int i, int[] numbers, int sum)
    {
        if (i <= 1)
        {
            return sum = 1;
        }
        if (i == 2)
        {
            return sum = numbers[i - 1] + numbers[i - 2];
        }

        return sum = numbers[i - 1] + numbers[i - 2] + numbers[i - 3];
    }

    static void Printer(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
    }
}