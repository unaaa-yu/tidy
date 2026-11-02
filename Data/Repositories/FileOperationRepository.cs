using Microsoft.EntityFrameworkCore;
using Tidy.Backend.Models;

namespace Tidy.Data.Repositories;

public class FileOperationRepository : IFileOperationRepository
{
    private readonly TidyDbContext _context;

    public FileOperationRepository(TidyDbContext context)
    {
        _context = context;
    }

    public Task<List<FileOperation>> GetAllAsync(CancellationToken cancellationToken = default) =>
        _context.FileOperations.ToListAsync(cancellationToken);

    public Task<List<FileOperation>> GetByFileIdAsync(Guid fileId, CancellationToken cancellationToken = default) =>
        _context.FileOperations.Where(o => o.File.Id == fileId).ToListAsync(cancellationToken);

    public async Task AddAsync(FileOperation operation, CancellationToken cancellationToken = default)
    {
        _context.FileOperations.Add(operation);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
