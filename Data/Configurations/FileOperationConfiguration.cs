using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tidy.Backend.Models;

namespace Tidy.Data.Configurations;

public class FileOperationConfiguration : IEntityTypeConfiguration<FileOperation>
{
    public void Configure(EntityTypeBuilder<FileOperation> builder)
    {
        builder.HasKey(o => o.Id);

        builder.Property(o => o.Source)
            .IsRequired()
            .HasMaxLength(1024);

        builder.Property(o => o.Destination)
            .IsRequired()
            .HasMaxLength(1024);

        builder.HasOne(o => o.File)
            .WithMany()
            .IsRequired();
    }
}
