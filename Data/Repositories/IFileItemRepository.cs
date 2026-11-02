using Tidy.Backend.Models;

namespace Tidy.Data.Repositories;

public interface IFileItemRepository
{
    Task<FileItem?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<FileItem?> GetByPathAsync(string path, CancellationToken cancellationToken = default);

    Task<List<FileItem>> GetAllAsync(CancellationToken cancellationToken = default);

    // Hashes that occur on more than one file - the raw material for building DuplicateGroups.
    Task<List<string>> GetDuplicateHashesAsync(CancellationToken cancellationToken = default);

    Task<List<FileItem>> GetByHashAsync(string hash, CancellationToken cancellationToken = default);

    Task AddAsync(FileItem fileItem, CancellationToken cancellationToken = default);

    Task AddRangeAsync(IEnumerable<FileItem> fileItems, CancellationToken cancellationToken = default);

    Task RemoveAsync(FileItem fileItem, CancellationToken cancellationToken = default);
}
