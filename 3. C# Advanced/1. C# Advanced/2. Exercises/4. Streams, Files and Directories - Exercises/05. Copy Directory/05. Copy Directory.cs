namespace CopyDirectory
{
    using System;
    using System.IO;
    using System.Linq;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            DirectoryInfo outputFolderInfo = new DirectoryInfo(outputPath);
            FileInfo[] outputFileInfo = outputFolderInfo.GetFiles();

            foreach (var file in outputFileInfo)
            {
                file.Delete();
            }
            foreach (DirectoryInfo subDirectory in outputFolderInfo.GetDirectories())
            {
                subDirectory.Delete(true);
            }

            DirectoryInfo folderInfo = new DirectoryInfo(inputPath);
            FileInfo[] fileInfo = folderInfo.GetFiles();

            foreach (var file in fileInfo)
            {
                string targetFilePath = Path.Combine(outputPath, file.Name);
                file.CopyTo(targetFilePath, false);
            }
        }
    }
}
