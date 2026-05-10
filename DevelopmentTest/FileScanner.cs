using System.Collections.Generic;
using System.IO;
using System.Linq;

public class FileScanner
{
    private readonly string[] extensions =
    {
        ".c",
        ".cpp",
        ".h",
        ".rc"
    };

    public void Scan(
        string baseFolder,
        string outputFile)
    {
        if (!Directory.Exists(baseFolder))
        {
            Console.WriteLine("Folder does not exist.");
            return;
        }

        Dictionary<string, List<string>>
            fileProjects =
            new Dictionary<string, List<string>>();

        // Scan all files recursively
        var files = Directory.GetFiles(
            baseFolder,
            "*.*",
            SearchOption.AllDirectories);

        Console.WriteLine("Scanning Folder:");
        Console.WriteLine(baseFolder);
        Console.WriteLine();

        foreach (string file in files)
        {
            string extension =
                Path.GetExtension(file).ToLower();

            // Skip unsupported files
            if (!extensions.Contains(extension))
                continue;

            string fileName =
                Path.GetFileName(file);

            // Generate content hash
            string fileHash =
                HashUtility.GetFileHash(file);

            // Create unique identifier
            string uniqueKey =
                fileName + "|" + fileHash;

            string relativePath =
                Path.GetRelativePath(
                    baseFolder,
                    file);

            string[] parts =
                relativePath.Split(
                    Path.DirectorySeparatorChar);

            string projectName =
                parts.Length > 1
                ? parts[0]
                : "Root";

            if (!fileProjects.ContainsKey(uniqueKey))
            {
                fileProjects[uniqueKey] =
                    new List<string>();
            }

            if (!fileProjects[uniqueKey]
                .Contains(projectName))
            {
                fileProjects[uniqueKey]
                    .Add(projectName);
            }
        }

        // Group files by identical projects
        var grouped =
            fileProjects
            .Where(x => x.Value.Count > 1)
            .GroupBy(
                x => string.Join(
                    ",",
                    x.Value.OrderBy(v => v)));

        List<string> outputLines =
            new List<string>();

        foreach (var group in grouped)
        {
            List<string> projects =
                group.First().Value;

            foreach (string project in projects)
            {
                outputLines.Add("/" + project);
            }

            foreach (var file in group)
            {
                string fileName =
                    file.Key.Split('|')[0];

                outputLines.Add(
                    "\t" + fileName);
            }

            outputLines.Add("");
        }

        foreach (string line in outputLines)
        {
            Console.WriteLine(line);
        }

        // Save output to file
        if (!string.IsNullOrEmpty(outputFile))
        {
            File.WriteAllLines(
                outputFile,
                outputLines);

            Console.WriteLine(
                "\nOutput saved to: "
                + outputFile);
        }
    }
}