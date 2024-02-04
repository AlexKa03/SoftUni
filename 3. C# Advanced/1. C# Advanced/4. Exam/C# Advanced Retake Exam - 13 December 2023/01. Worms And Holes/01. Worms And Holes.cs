class Program
{
    static void Main()
    {
        Stack<int> worms = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
        Queue<int> holes = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));

        int initialWormCount = worms.Count;
        int matchesCount = 0;

        while (worms.Count > 0 && holes.Count > 0)
        {
            int currentWorm = worms.Peek();
            int currentHole = holes.Peek();

            if (currentWorm == currentHole)
            {
                matchesCount++;
                worms.Pop();
                holes.Dequeue();
            }
            else
            {
                worms.Push(worms.Pop() - 3);

                if (worms.Peek() <= 0)
                {
                    worms.Pop();
                }
                holes.Dequeue();
            }
        }

        Console.WriteLine(matchesCount > 0 ? $"Matches: {matchesCount}" : "There are no matches.");

        if (worms.Count == 0)
        {
            if (matchesCount == initialWormCount)
            {
                Console.WriteLine("Every worm found a suitable hole!");
            }
            else
            {
                Console.WriteLine("Worms left: none");
            }
        }
        else
        {
            Console.WriteLine("Worms left: " + string.Join(", ", worms));
        }

        Console.WriteLine(holes.Count > 0 ? "Holes left: " + string.Join(", ", holes) : "Holes left: none");
    }
}


//class Program
//{
//    static void Main()
//    {
//        Stack<int> worms = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
//        Queue<int> holes = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));

//        int initialWormCount = holes.Count;

//        int matchesCount = 0;

//        while (worms.Count > 0 && holes.Count > 0)
//        {
//            int currentWorm = worms.Peek();
//            int currentHole = holes.Peek();

//            if (currentWorm == currentHole)
//            {
//                matchesCount++;
//                worms.Pop();
//                holes.Dequeue();
//            }
//            else
//            {
//                worms.Push(worms.Pop() - 3);

//                if (worms.Peek() <= 0)
//                {
//                    worms.Pop();
//                }
//                holes.Dequeue();
//            }
//        }

//        if (matchesCount > 0)
//        {
//            Console.WriteLine($"Matches: {matchesCount}");
//        }
//        else
//        {
//            Console.WriteLine("There are no matches.");
//        }


//        if (worms.Count == 0 && matchesCount == initialWormCount)
//        {
//            Console.WriteLine("Every worm found a suitable hole!");
//        }
//        else if (worms.Count > 0)
//        {
//            Console.WriteLine("Worms left: " + string.Join(", ", worms));
//        }
//        else
//        {
//            Console.WriteLine("Worms left: none");
//        }

//        if (holes.Count > 0)
//        {
//            Console.WriteLine("Holes left: " + string.Join(", ", holes));
//        }
//        else
//        {
//            Console.WriteLine("Holes left: none");
//        }
//    }
//}