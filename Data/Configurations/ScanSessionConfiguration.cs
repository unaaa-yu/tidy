using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tidy.Backend.Models;

namespace Tidy.Data.Configurations;

public class ScanSessionConfiguration : IEntityTypeConfiguration<ScanSession>
{
    public void Configure(EntityTypeBuilder<ScanSession> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Path)
            .IsRequired()
            .HasMaxLength(1024);
    }
}
