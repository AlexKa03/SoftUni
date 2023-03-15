using _03._Songs;

class Program
{
    static void Main(string[] args)
    {
        int nSongs = int.Parse(Console.ReadLine());

        List<Song> songs = new List<Song>();

        for (int i = 0; i < nSongs; i++)
        {
            string[] data = Console.ReadLine()
                .Split("_", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string type = data[0];
            string name = data[1];
            string time = data[2];

            Song song = new Song();

            song.Type = type;
            song.Name = name;
            song.Time = time;

            songs.Add(song);
        }

        string typeList = Console.ReadLine();

        if (typeList == "all")
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
        else
        {
            foreach (Song song in songs)
            {
                if (song.Type == typeList)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}