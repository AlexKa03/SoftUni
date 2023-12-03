namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using(StreamReader firstFile = new StreamReader(firstInputFilePath))
            {
                using(StreamReader secondFile = new StreamReader(secondInputFilePath))
                {
                    using(StreamWriter output = new StreamWriter(outputFilePath))
                    {
                        while (!firstFile.EndOfStream && !secondFile.EndOfStream)
                        {
                            if (firstFile.EndOfStream)
                            {
                                output.WriteLine(secondFile.ReadLine());
                            }
                            else if (secondFile.EndOfStream)
                            {
                                output.WriteLine(firstFile.ReadLine());
                            }
                            else
                            {
                                output.WriteLine(firstFile.ReadLine());
                                output.WriteLine(secondFile.ReadLine());
                            }
                        }
                    }
                }
            }
        }
    }
}
