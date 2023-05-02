using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AssetRentEntryConfiguration : IEntityTypeConfiguration<AssetRentEntry>
{
    public void Configure(EntityTypeBuilder<AssetRentEntry> builder)
    {
        builder.ToTable("AssetRent_Entry");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AssetId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AssetID");

        builder.Property(e => e.CustD).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Period).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Price).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("RentID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");
    }
}