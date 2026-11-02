using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tidy.Backend.Models;

namespace Tidy.Data.Configurations;

public class FileItemConfiguration : IEntityTypeConfiguration<FileItem>
{
    public void Configure(EntityTypeBuilder<FileItem> builder)
    {
        builder.HasKey(f => f.Id);

        builder.Property(f => f.Name)
            .IsRequired()
            .HasMaxLength(260);

        builder.Property(f => f.Path)
            .IsRequired()
            .HasMaxLength(1024);

        builder.HasIndex(f => f.Path)
            .IsUnique();

        // Not unique: duplicate files share a hash, which is how duplicates are found.
        builder.HasIndex(f => f.Hash);
    }
}
