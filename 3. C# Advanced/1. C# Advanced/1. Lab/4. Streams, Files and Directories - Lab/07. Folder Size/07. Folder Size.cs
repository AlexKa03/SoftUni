namespace FolderSize
{
    using System;
    using System.IO;
    using System.Linq;

    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        //from 'public static void' to 'public static long'
        public static long GetFolderSize(string folderPath, string outputFilePath)
        {
            DirectoryInfo folderInfo = new DirectoryInfo(folderPath);
            FileInfo[] files = folderInfo.GetFiles();

            long bytes = 0;

            foreach (var file in files)
            {
                bytes += file.Length;
            }

            DirectoryInfo[] subDirs = folderInfo.GetDirectories();

            foreach (var subDir in subDirs)
            {
                bytes += GetFolderSize(subDir.FullName, outputFilePath);
            }

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.Write($"{bytes / 1024.0} KB");
            }

            return bytes;
        }
    }
}
