class Program
{
    static void Main()
    {
        byte centuries = byte.Parse(Console.ReadLine());

        ushort years = (ushort)(centuries * 100);
        double days = Math.Floor(years * 365.2422);
        uint hours = (uint)(days * 24);
        ulong minutes = hours * 60;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
    }
}