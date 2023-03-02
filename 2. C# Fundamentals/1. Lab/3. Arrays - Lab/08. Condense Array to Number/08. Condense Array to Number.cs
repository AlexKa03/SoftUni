class Program
{
    static void Main()
    {
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            int condensed = array.Length - 1;

            if (array.Length == 1)
            {
                Console.WriteLine(array[0]);
                return;
            }

            for (int i = 0; i < condensed; i++)
            {
                int[] modifiedArray = new int[array.Length - 1];

                for (int j = 0; j < modifiedArray.Length; j++)
                {
                    modifiedArray[j] = array[j] + array[j + 1];
                }

                array = modifiedArray;
                sum = modifiedArray[0];
            }

            Console.WriteLine(sum);
        }
    }
}
