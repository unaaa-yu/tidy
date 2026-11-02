using Tidy.Backend.Models;

namespace Tidy.Data.Repositories;

public interface IScanSessionRepository
{
    Task<ScanSession?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<ScanSession?> GetLatestAsync(CancellationToken cancellationToken = default);

    Task<List<ScanSession>> GetAllAsync(CancellationToken cancellationToken = default);

    Task AddAsync(ScanSession session, CancellationToken cancellationToken = default);
}
