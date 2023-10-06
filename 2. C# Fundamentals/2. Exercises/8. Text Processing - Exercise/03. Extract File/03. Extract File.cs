class Program
{
    static void Main(string[] args)
    {
        string[] filePath = Console.ReadLine()
            .Split("\\", StringSplitOptions.RemoveEmptyEntries);

        string[] file = filePath[filePath.Length - 1].Split(".", StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine($"File name: {file[0]}\nFile extension: {file[1]}");
    }
}