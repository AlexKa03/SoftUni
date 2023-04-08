class Program
{
    static void Main(string[] args)
    {
        List<string> shoppingList = Console.ReadLine()
            .Split("!", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string command = Console.ReadLine();

        while (command != "Go Shopping!")
        {
            string[] data = command
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

            string action = data[0];
            string item = data[1];

            switch (action)
            {
                case "Urgent":
                    if (!shoppingList.Contains(item))
                    {
                        shoppingList.Insert(0, item);
                    }
                    break;

                case "Unnecessary":
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                    }
                    break;

                case "Correct":
                    if (shoppingList.Contains(item))
                    {
                        string newItem = data[2];
                        int index = shoppingList.IndexOf(item);
                        shoppingList[index] = newItem;

                        // no need of if statement: if (index != -1), in the
                        // condition of task it's guaranteed to be there
                    }
                    break;

                case "Rearrange":
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                        shoppingList.Add(item);
                    }
                    break;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(", ", shoppingList));
    }
}