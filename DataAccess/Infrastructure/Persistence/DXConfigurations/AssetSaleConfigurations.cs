using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AssetSaleConfiguration : IEntityTypeConfiguration<AssetSale>
{
    public void Configure(EntityTypeBuilder<AssetSale> builder)
    {
        builder.ToTable("Asset_Sale");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Accountid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.AssetId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AssetID");

        builder.Property(e => e.AssetRemain).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.AssetRemainId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AssetRemainID");

        builder.Property(e => e.Assetvalue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("assetvalue");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Cost)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("cost");

        builder.Property(e => e.CostId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CostID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Custid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Note)
            .HasColumnName("note")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PayType).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.Remain).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Total).HasColumnType("money");

        builder.Property(e => e.Value)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}