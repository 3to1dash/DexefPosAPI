using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ArchiveRelConfiguration : IEntityTypeConfiguration<ArchiveRel>
{
    public void Configure(EntityTypeBuilder<ArchiveRel> builder)
    {
        builder.ToTable("archive_rel");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Caption)
            .HasMaxLength(50)
            .HasColumnName("caption");

        builder.Property(e => e.Detail)
            .HasMaxLength(150)
            .HasColumnName("detail");

        builder.Property(e => e.Photo)
            .HasColumnType("image")
            .HasColumnName("photo");

        builder.Property(e => e.Rid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}