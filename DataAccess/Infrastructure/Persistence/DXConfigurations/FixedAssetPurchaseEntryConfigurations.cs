using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FixedAssetPurchaseEntryConfiguration : IEntityTypeConfiguration<FixedAssetPurchaseEntry>
{
    public void Configure(EntityTypeBuilder<FixedAssetPurchaseEntry> builder)
    {
        builder.ToTable("FixedAssetPurchase_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AssetId).HasColumnName("AssetID");

        builder.Property(e => e.AssetNetCost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.AssetShip).HasMaxLength(150);

        builder.Property(e => e.BillExtra).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BillId).HasColumnName("BillID");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Discount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.NetPrice).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.NetTotal).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Price).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rate)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Tax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TaxPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalDiscount).HasColumnType("numeric(19, 5)");
    }
}