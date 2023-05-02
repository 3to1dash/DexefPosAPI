using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ArchiveConfiguration : IEntityTypeConfiguration<Archive>
{
    public void Configure(EntityTypeBuilder<Archive> builder)
    {
        builder.ToTable("archive");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Isarchive)
            .HasColumnName("isarchive")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(250)
            .HasColumnName("name");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Rtfformat).HasColumnName("rtfformat");

        builder.Property(e => e.Txt).HasColumnName("txt");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}