using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RtlTileConfiguration : IEntityTypeConfiguration<RtlTile>
{
    public void Configure(EntityTypeBuilder<RtlTile> builder)
    {
        builder.HasKey(e => e.Ar);

        builder.ToTable("RTL_Tiles");

        builder.Property(e => e.Ar).HasMaxLength(50);

        builder.Property(e => e.En).HasMaxLength(50);

        builder.Property(e => e.Fr).HasMaxLength(50);

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}