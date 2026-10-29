namespace Tidy.Backend.Services;

using Tidy.Backend.Models.ScanSession;

public interface IFolderScannerService
{
    Task<ScanSession> ScanFolderAsync(string path, CancellationToken cancellationToken = default);
}
