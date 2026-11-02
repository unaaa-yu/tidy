using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Tidy.Data;

// Lets `dotnet ef` create a TidyDbContext at design time, since the
// real constructor now takes DbContextOptions instead of configuring itself.
public class TidyDbContextFactory : IDesignTimeDbContextFactory<TidyDbContext>
{
    public TidyDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<TidyDbContext>();
        optionsBuilder.UseSqlite("Data Source=tidy.db");
        return new TidyDbContext(optionsBuilder.Options);
    }
}
