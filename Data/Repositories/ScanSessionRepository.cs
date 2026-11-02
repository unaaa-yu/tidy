using Microsoft.EntityFrameworkCore;
using Tidy.Backend.Models;

namespace Tidy.Data.Repositories;

public class ScanSessionRepository : IScanSessionRepository
{
    private readonly TidyDbContext _context;

    public ScanSessionRepository(TidyDbContext context)
    {
        _context = context;
    }

    public Task<ScanSession?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) =>
        _context.ScanSessions.FirstOrDefaultAsync(s => s.Id == id, cancellationToken);

    public Task<ScanSession?> GetLatestAsync(CancellationToken cancellationToken = default) =>
        _context.ScanSessions.OrderByDescending(s => s.Time).FirstOrDefaultAsync(cancellationToken);

    public Task<List<ScanSession>> GetAllAsync(CancellationToken cancellationToken = default) =>
        _context.ScanSessions.ToListAsync(cancellationToken);

    public async Task AddAsync(ScanSession session, CancellationToken cancellationToken = default)
    {
        _context.ScanSessions.Add(session);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
