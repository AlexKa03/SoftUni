namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();

            using (StreamReader wordsReader = new StreamReader(wordsFilePath))
            {
                using (StreamReader textReader = new StreamReader(textFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string[] words = wordsReader
                            .ReadLine()
                            .Split(" ");

                        foreach (string word in words)
                        {
                            output.Add(word, 0);
                        }

                        string[] separators = new string[] { " ", ".", ",", "!", "?", "…", "-" };

                        while (!textReader.EndOfStream)
                        {
                            string[] text = textReader
                                .ReadLine()
                                .ToLower()
                                .Split(separators, StringSplitOptions.RemoveEmptyEntries);

                            for (int i = 0; i < text.Length; i++)
                            {
                                for (int j = 0; j < words.Length; j++)
                                {
                                    if (text[i].StartsWith("-"))
                                    {
                                        text[i] = text[i].Substring(1);
                                    }

                                    if (text[i] == words[j])
                                    {
                                        output[words[j]]++;
                                    }
                                }
                            }
                        }

                        output = output
                            .OrderByDescending(x => x.Value)
                            .ToDictionary(y => y.Key, y => y.Value);

                        foreach (var (word, count) in output)
                        {
                            writer.WriteLine($"{word} - {count}");
                        }
                    }
                }
            }           
        }
    }
}
