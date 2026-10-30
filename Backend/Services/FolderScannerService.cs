namespace Tidy.Backend.Services;

using Tidy.Backend.Models;

public interface IFolderScannerService
{
    Task<ScanSession> ScanFolderAsync(string path, CancellationToken cancellationToken = default);
}
