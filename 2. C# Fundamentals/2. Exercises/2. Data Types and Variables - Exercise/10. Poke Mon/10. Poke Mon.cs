class Program
{
    static void Main()
    {
        {
            uint power = uint.Parse(Console.ReadLine());
            uint distance = uint.Parse(Console.ReadLine());
            byte exhaustion = byte.Parse(Console.ReadLine());

            uint originalPower = power;
            ushort targets = 0;

            while (power >= distance)
            {
                power -= distance;
                targets++;

                if ((originalPower * 0.5 == power) && exhaustion != 0)
                {
                    power = power / exhaustion;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(targets);
        }
    }
}