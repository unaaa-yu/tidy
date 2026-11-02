using Microsoft.EntityFrameworkCore;
using Tidy.Backend.Models;

namespace Tidy.Data;

public class TidyDbContext : DbContext
{
    public TidyDbContext(DbContextOptions<TidyDbContext> options) : base(options)
    {
    }

    public DbSet<FileItem> FileItems => Set<FileItem>();

    public DbSet<FileOperation> FileOperations => Set<FileOperation>();

    public DbSet<ScanSession> ScanSessions => Set<ScanSession>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=tidy.db");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TidyDbContext).Assembly);
    }
}