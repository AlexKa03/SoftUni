namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            DirectoryInfo folderInfo = new DirectoryInfo(inputFolderPath);
            FileInfo[] fileInfo = folderInfo.GetFiles();

            var report = fileInfo
                .GroupBy(file => file.Extension.ToLower())
                .OrderByDescending(group => group.Count())
                .ThenBy(group => group.Key)
                .ToDictionary(group => group.Key, group => group.OrderBy(file => file.Length).ToList());

            StringBuilder sb = new StringBuilder();

            foreach (var group in report)
            {
                sb.AppendLine(group.Key);
                foreach (var file in group.Value)
                {
                    sb.AppendLine($"--{file.Name} - {file.Length / 1024f:F3}kb");
                }
            }

            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullReportPath = desktopPath + reportFileName;

            File.WriteAllText(fullReportPath, textContent);
        }
    }
}
