using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UnitsEntryConfiguration : IEntityTypeConfiguration<UnitsEntry>
{


    public void Configure(EntityTypeBuilder<UnitsEntry> builder)
    {
        builder.ToTable("UnitsEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Code).HasMaxLength(50);

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Qty).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.UnitId).HasColumnName("UnitID");
    }
}