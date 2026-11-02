using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tidy.Data.Repositories;

namespace Tidy.Data;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDataLayer(this IServiceCollection services, string connectionString = "Data Source=tidy.db")
    {
        services.AddDbContext<TidyDbContext>(options => options.UseSqlite(connectionString));

        services.AddScoped<IFileItemRepository, FileItemRepository>();
        services.AddScoped<IFileOperationRepository, FileOperationRepository>();
        services.AddScoped<IScanSessionRepository, ScanSessionRepository>();

        return services;
    }
}
