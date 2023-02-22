using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TmpStoreTableConfiguration : IEntityTypeConfiguration<TmpStoreTable>
{


    public void Configure(EntityTypeBuilder<TmpStoreTable> builder)
    {
        builder.HasNoKey();

        builder.ToTable("TmpStoreTable");

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("code");

        builder.Property(e => e.CostPrice).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Dt)
            .HasColumnType("date")
            .HasColumnName("dt");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.ItemIds).HasColumnName("ItemIDs");

        builder.Property(e => e.ItemType).HasMaxLength(50);

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.KindIds).HasColumnName("KindIDs");

        builder.Property(e => e.MainUnite).HasMaxLength(50);

        builder.Property(e => e.Qty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty1In).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty1Out).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty2In)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("Qty2IN");

        builder.Property(e => e.Qty2Out).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.QtyIn).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.QtyOut).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalIn)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("TotalIN");

        builder.Property(e => e.TotalOut).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Unite).HasMaxLength(50);

        builder.Property(e => e.UniteQty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.VendorName).HasMaxLength(400);
    }
}