
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("====================================");
        Console.WriteLine(" Duplicate Source File Finder");
        Console.WriteLine("====================================\n");

        if (args.Length < 1)
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("dotnet run -- <folderPath> [outputFile]");
            return;
        }

        string baseFolder = args[0];
        string outputFile =
            args.Length > 1 ? args[1] : "";

        try
        {
            FileScanner scanner = new FileScanner();

            scanner.Scan(baseFolder, outputFile);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Scan Completed Successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}