class Program
{
    static void Main(string[] args)
    {
        Stack<int> boxes = new Stack<int>(
            Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse));

        int rackCapacity = int.Parse(Console.ReadLine());

        int rackCurrent = 0;
        int rackCount = 1;

        while (boxes.Any())
        {
            int currentBox = boxes.Peek();
            boxes.Pop();

            if (rackCurrent + currentBox <= rackCapacity)
            {
                rackCurrent += currentBox;
            }
            else
            {
                rackCount++;
                rackCurrent = currentBox;
            }
        }

        Console.WriteLine(rackCount);
    }
}