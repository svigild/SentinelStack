using System.IO;


// File to be scanned.
string filePath = "test.txt";
// List of patterns a security auditor would look for
List<string> dangerousKeywords = new List<string> { "password", "admin123", "api_key", "internal_ip" };

try
{
    // Checks that the file exists
    if (!File.Exists(filePath))
    {
        Console.WriteLine("Error: File doesn't exist: " + filePath);
        return;
    }

    // Reads the file line by line to avoid overloading the memory if the file is large
    String line;
    // Pass the file path and file name to the StreamReader constructor.
    StreamReader sr = new(filePath);
    // Boolean that will set to 'true' if something from dangerousKeywords is find in the file.
    bool foundIssue = false;

    // Read the first line of the text
    line = sr.ReadLine();
    while (line != null)
    {
        // Checks if line contains any value of dangerousKeywords
        foreach (var keyword in dangerousKeywords)
        {
            if (line.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("[CRITICAL]: In line: " + line + ": Detected: " + keyword);
                foundIssue = true;
            }
        }
        // Read the next line
        line = sr.ReadLine();
    }
    // Close the file
    sr.Close();

    if (!foundIssue) Console.WriteLine("Analysis completed: No core risks found.");

}
catch (Exception e)
{
    Console.WriteLine("[ERROR]: Unexpected error: " + e.Message);
}




