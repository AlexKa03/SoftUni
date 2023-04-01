class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int length = array.Length;
        int outsideElements = length / 4;

        int[] lineOne = new int[length / 2];
        int[] lineTwo = new int[length / 2];

        int counter = 0;

        for (int i = outsideElements - 1; i >= 0; i--)
        {
            if (i < outsideElements || i >= length - outsideElements)
            {
                lineOne[counter] = array[i];
                counter++;
            }
        }

        for (int i = length - 1; i >= length - outsideElements; i--)
        {
            if (i < outsideElements || i >= length - outsideElements)
            {
                lineOne[counter] = array[i];
                counter++;
            }
        }

        counter = 0;

        for (int i = outsideElements; i < length - outsideElements; i++)
        {
            lineTwo[counter] = array[i];
            counter++;
        }

        int[] linesSum = new int[length / 2];

        for (int i = 0; i < lineOne.Length; i++)
        {
            linesSum[i] = lineOne[i] + lineTwo[i];
        }

        foreach (var number in linesSum)
        {
            Console.Write($"{number} ");
        }
    }
}