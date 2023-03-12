class Program
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        string output = "BALANCED";

        int openCounter = 0;
        int closeCounter = 0;

        for (int i = 1; i <= lines; i++)
        {
            string symbols = Console.ReadLine();

            if (symbols == ")")
            {
                closeCounter++;

                if (openCounter - closeCounter != 0)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
            else if (symbols == "(")
            {
                openCounter++;
            }
        }

        if (openCounter == closeCounter)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}