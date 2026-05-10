using System.IO;
using System.Security.Cryptography;

public static class HashUtility
{
    // Generate SHA256 hash
    // for file content comparison
    public static string GetFileHash(
        string filePath)
    {
        using (SHA256 sha256 =
            SHA256.Create())
        {
            using (FileStream stream =
                File.OpenRead(filePath))
            {
                byte[] hash =
                    sha256.ComputeHash(stream);

                return BitConverter
                    .ToString(hash)
                    .Replace("-", "");
            }
        }
    }
}