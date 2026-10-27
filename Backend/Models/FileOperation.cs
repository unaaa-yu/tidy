namespace Tidy.Backend.Models;

public class FileOperation
{
    public FileItem file { get; set; };

    public string source { get; set; } = string.Empty;
    
    public string destination { get; set; } = string.Empty;
}