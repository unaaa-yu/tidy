namespace Tidy.Backend.Models;

public class FileOperation
{
    public FileItem File { get; set; };

    public string Source { get; set; } = string.Empty;
    
    public string Destination { get; set; } = string.Empty;
}