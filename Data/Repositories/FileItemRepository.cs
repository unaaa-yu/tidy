using Microsoft.EntityFrameworkCore;
using Tidy.Backend.Models;

namespace Tidy.Data.Repositories;

public class FileItemRepository : IFileItemRepository
{
    private readonly TidyDbContext _context;

    public FileItemRepository(TidyDbContext context)
    {
        _context = context;
    }

    public Task<FileItem?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) =>
        _context.FileItems.FirstOrDefaultAsync(f => f.Id == id, cancellationToken);

    public Task<FileItem?> GetByPathAsync(string path, CancellationToken cancellationToken = default) =>
        _context.FileItems.FirstOrDefaultAsync(f => f.Path == path, cancellationToken);

    public Task<List<FileItem>> GetAllAsync(CancellationToken cancellationToken = default) =>
        _context.FileItems.ToListAsync(cancellationToken);

    public Task<List<string>> GetDuplicateHashesAsync(CancellationToken cancellationToken = default) =>
        _context.FileItems
            .Where(f => f.Hash != string.Empty)
            .GroupBy(f => f.Hash)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToListAsync(cancellationToken);

    public Task<List<FileItem>> GetByHashAsync(string hash, CancellationToken cancellationToken = default) =>
        _context.FileItems.Where(f => f.Hash == hash).ToListAsync(cancellationToken);

    public async Task AddAsync(FileItem fileItem, CancellationToken cancellationToken = default)
    {
        _context.FileItems.Add(fileItem);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task AddRangeAsync(IEnumerable<FileItem> fileItems, CancellationToken cancellationToken = default)
    {
        _context.FileItems.AddRange(fileItems);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task RemoveAsync(FileItem fileItem, CancellationToken cancellationToken = default)
    {
        _context.FileItems.Remove(fileItem);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
