class Program
{
    static void Main()
    {
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                int temp = nums[0];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    nums[i] = nums[i + 1];
                }
                nums[nums.Length - 1] = temp;
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
