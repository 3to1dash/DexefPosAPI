using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ShortCutConfiguration : IEntityTypeConfiguration<ShortCut>
{
    public void Configure(EntityTypeBuilder<ShortCut> builder)
    {
        builder.HasNoKey();

        builder.ToTable("ShortCut");

        builder.Property(e => e.Keys).HasMaxLength(50);

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.WrittenBy).HasMaxLength(150);
    }
}