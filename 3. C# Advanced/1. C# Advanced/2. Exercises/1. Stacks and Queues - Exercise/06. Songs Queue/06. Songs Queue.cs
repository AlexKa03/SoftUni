class Program
{
    static void Main(string[] args)
    {
        Queue<string> playlist = new Queue<string>(
            Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries));

        while (playlist.Any())
        {
            string cmd = Console.ReadLine();

            if (cmd == "Play")
            {
                playlist.Dequeue();
            }
            else if (cmd.StartsWith("Add"))
            {
                string song = cmd.Substring(4);

                if (playlist.Contains(song))
                {
                    Console.WriteLine($"{song} is already contained!");
                }
                else
                {
                    playlist.Enqueue(song);
                }
            }
            else if (cmd.StartsWith("Show"))
            {
                Console.WriteLine(string.Join(", ", playlist));
            }
        }

        Console.WriteLine("No more songs!");
    }
}