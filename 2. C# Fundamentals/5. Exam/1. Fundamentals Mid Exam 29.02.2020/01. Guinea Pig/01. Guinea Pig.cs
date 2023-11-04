class Ptogram
{
    static void Main(string[] args)
    {
        double quantityFood = double.Parse(Console.ReadLine());
        double quantityHay = double.Parse(Console.ReadLine());
        double quantityCover = double.Parse(Console.ReadLine());
        double guineaWeight = double.Parse(Console.ReadLine());

        quantityFood *= 1000;
        quantityHay *= 1000;
        quantityCover *= 1000;
        guineaWeight *= 1000;


        for (int i = 1; i <= 30; i++)
        {
            if (quantityFood - 300 > 0)
            {
                quantityFood -= 300;
            }
            else
            {
                NotEnough();
            }

            if (i % 2 == 0)
            {
                if (quantityHay - (quantityFood * 0.05) > 0)
                {
                    quantityHay -= quantityFood * 0.05;
                }
                else
                {
                    NotEnough();
                }
            }
            if (i % 3 == 0)
            {
                if (quantityCover - (guineaWeight / 3) > 0)
                {
                    quantityCover -= guineaWeight / 3;
                }
                else
                {
                    NotEnough();
                }
            }
        }

        EverythingEnough(quantityFood, quantityHay, quantityCover);
    }

    static void EverythingEnough(double food, double hay, double cover)
    {
        Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food / 1000:f2}, Hay: {hay / 1000:f2}, Cover: {cover / 1000:f2}.");
    }

    static void NotEnough()
    {
        Console.WriteLine("Merry must go to the pet store!");
        Environment.Exit(0);
    }
}