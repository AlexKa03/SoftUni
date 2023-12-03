namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            List<string> bytesList = new List<string>();
            StringBuilder sb = new StringBuilder();

            using (StreamReader streamReader = new StreamReader(bytesFilePath))
            {
                byte[] fileBytes = File.ReadAllBytes(binaryFilePath);
                
                while (!streamReader.EndOfStream)
                {
                    bytesList.Add(streamReader.ReadLine());
                }

                foreach (var item in fileBytes)
                {
                    if (bytesList.Contains(item.ToString()))
                    {
                        sb.AppendLine(item.ToString());
                    }

                }
            }

            using (StreamWriter file = new StreamWriter(outputPath))
            {
                file.WriteLine(sb.ToString().Trim());
            }
        }
    }
}
