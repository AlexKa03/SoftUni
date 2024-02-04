namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream file = new FileStream(inputFilePath, FileMode.Open))
            {
                using(BinaryReader binary = new BinaryReader(file))
                {
                    byte[] bytesToWrite = binary.ReadBytes((int)file.Length);

                    byte[] copiedBytes = new byte[bytesToWrite.Length];

                    bytesToWrite.CopyTo(copiedBytes, 0);

                    using (FileStream fileStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                    {
                        using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                        {
                            binaryWriter.Write(copiedBytes);
                        }
                    }
                }
            }
        }
    }
}
