﻿class Program
{
    static void Main(string[] args)
    {
        string key = Console.ReadLine();
        string word = Console.ReadLine();

        while (true)
        {
            int index = word.IndexOf(key);

            if (index == -1)
            {
                break;
            }

            word = word.Remove(index, key.Length);
        }

        Console.WriteLine(word);
    }
}