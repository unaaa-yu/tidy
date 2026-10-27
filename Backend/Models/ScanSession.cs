namespace Tidy.Backend.Models;

public class ScanSession
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Path { get; set; } = string.Empty;

    public DateTime Time { get; set; };
}
