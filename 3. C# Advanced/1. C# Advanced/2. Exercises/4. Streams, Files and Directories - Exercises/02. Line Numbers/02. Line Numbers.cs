namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string punctuationPattern = @"[^\w\s]";
            string lettersPattern = @"[\w]";

            Regex punctuation = new Regex(punctuationPattern);
            Regex letters = new Regex(lettersPattern);

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int counter = 1;

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        var punctMatches = punctuation.Matches(line);
                        var lettersMatches = letters.Matches(line);


                        writer.WriteLine($"Line {counter}: {line} ({lettersMatches.Count})({punctMatches.Count})");

                        counter++;
                    }
                }
            }
        }
    }
}
