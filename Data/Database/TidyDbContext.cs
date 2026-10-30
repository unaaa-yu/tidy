using Microsoft.EntityFrameworkCore;
using Tidy.Backend.Models;

namespace Tidy.Data.Database;

public class TidyDbContext : DbContext
{
    public DbSet<FileItem> FileItems => Set<FileItem>(); // return the DbSet for FileItem

    public DbSet<FileOperation> FileOperations => Set<FileOperation>(); // return the DbSet for FileOperation
    public DbSet<ScanSession> ScanSessions => Set<ScanSession>(); // return the DbSet for ScanSession

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=tidy.db");
    }

    
}