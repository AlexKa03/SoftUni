using System;

namespace _08._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());
            int totalGroupMemebers = 0;

            double g1 = 0;
            double g2 = 0;
            double g3 = 0;
            double g4 = 0;
            double g5 = 0;

            for (int i = 0; i < groupsCount; i++)
            {
                int groupMembers = int.Parse(Console.ReadLine());
                totalGroupMemebers += groupMembers;

                if (groupMembers <= 5)
                {
                    g1 += groupMembers;
                }
                else if (groupMembers >= 6 && groupMembers <= 12)
                {
                    g2 += groupMembers;
                }
                else if (groupMembers >= 13 && groupMembers <= 25)
                {
                    g3 += groupMembers;
                }
                else if (groupMembers >= 26 && groupMembers <= 40)
                {
                    g4 += groupMembers;
                }
                else
                {
                    g5 += groupMembers;
                }
            }

            Console.WriteLine($"{(g1 / totalGroupMemebers) * 100:f2}%");
            Console.WriteLine($"{(g2 / totalGroupMemebers) * 100:f2}%");
            Console.WriteLine($"{(g3 / totalGroupMemebers) * 100:f2}%");
            Console.WriteLine($"{(g4 / totalGroupMemebers) * 100:f2}%");
            Console.WriteLine($"{(g5 / totalGroupMemebers) * 100:f2}%");
        }
    }
}
