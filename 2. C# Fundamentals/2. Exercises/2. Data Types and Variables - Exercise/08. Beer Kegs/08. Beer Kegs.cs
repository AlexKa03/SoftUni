class Program
{
    static void Main()
    {
        {
            int numberOfKegs = int.Parse(Console.ReadLine());

            string biggestName = "";
            double biggestVolume = 0.00;

            for (int i = 1; i <= numberOfKegs; i++)
            {
                string kegName = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestName = kegName;
                }
            }

            Console.WriteLine(biggestName);
        }
    }
}