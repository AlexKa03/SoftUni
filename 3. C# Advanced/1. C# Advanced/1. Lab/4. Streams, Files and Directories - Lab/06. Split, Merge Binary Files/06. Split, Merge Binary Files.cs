namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] fileContent = File.ReadAllBytes(sourceFilePath);
            int halfIndex = fileContent.Length / 2 + fileContent.Length % 2;

            byte[] partOne = fileContent.Take(halfIndex).ToArray();
            byte[] partTwo = fileContent.Skip(halfIndex).ToArray();

            File.WriteAllBytes(partOneFilePath, partOne);
            File.WriteAllBytes(partTwoFilePath, partTwo);
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            byte[] partOne = File.ReadAllBytes(partOneFilePath);
            byte[] partTwo = File.ReadAllBytes(partTwoFilePath);

            byte[] joinedFile = partOne.Concat(partTwo).ToArray();
            File.WriteAllBytes(joinedFilePath, joinedFile);
        }
    }
}