class Program
{
    static void Main()
    {
        {
            string[] array = Console.ReadLine()
                .Split();

            string[] reversedArray = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[(array.Length - 1) - i] + " ");
            }
        }
    }
}