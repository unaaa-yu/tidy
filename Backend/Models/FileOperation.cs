namespace Tidy.Backend.Models;

public class FileOperation
{
    public Guid Id { get; set; } = Guid.NewGuid();
    
    public required FileItem File { get; set; }

    public string Source { get; set; } = string.Empty;
    
    public string Destination { get; set; } = string.Empty;
}