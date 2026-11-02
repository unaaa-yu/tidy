using Tidy.Backend.Models;

namespace Tidy.Data.Repositories;

public interface IFileOperationRepository
{
    Task<List<FileOperation>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<List<FileOperation>> GetByFileIdAsync(Guid fileId, CancellationToken cancellationToken = default);

    Task AddAsync(FileOperation operation, CancellationToken cancellationToken = default);
}
