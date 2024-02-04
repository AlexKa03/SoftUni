namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder result = new StringBuilder();

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                
                int row = 0;
                string line = string.Empty;

                while ((line = reader.ReadLine()) != null)
                {
                    if (row % 2 == 0)
                    {
                        line = ReplaceSymbols(line);
                        string reversed = ReverseWords(line);
                        result.AppendLine(reversed);
                    }

                    row++;
                }
            }


            return result.ToString();
        }

        public static string ReplaceSymbols(string line)
        {
            return line.Replace("-", "@")
                       .Replace(",", "@")
                       .Replace(".", "@")
                       .Replace("!", "@")
                       .Replace("?", "@");
        }

        public static string ReverseWords(string line)
        {
            var words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
