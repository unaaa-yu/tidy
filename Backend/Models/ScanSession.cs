namespace Tidy.Backend.Models;

public class ScanSession
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Path { get; set; } = string.Empty;

    public DateTime time { get; set; };

    public List<FileItem> Files { get; set; } = new List<FileItem>();

    public List<DuplicateGroup> DuplicateGroups { get; set; } = new List<DuplicateGroup>();
}