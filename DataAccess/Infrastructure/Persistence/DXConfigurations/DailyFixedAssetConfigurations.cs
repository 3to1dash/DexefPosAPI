using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyFixedAssetConfiguration : IEntityTypeConfiguration<DailyFixedAsset>
{


    public void Configure(EntityTypeBuilder<DailyFixedAsset> builder)
    {
        builder.ToTable("DailyFixedAsset");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AssetCostOut).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.AssetCostTotal).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.AssetCostin).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.AssetId).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CostPrice)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.DeprecateCenterIn).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DeprecateCenterOut).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DestroyId).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Discount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Extra).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.NetPrice)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Note)
            .HasMaxLength(50)
            .HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.ParentShip).HasMaxLength(250);

        builder.Property(e => e.Price)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.QtyOut).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.QtyRentIn).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.QtyRentOut).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qtyin).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rate)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("RentID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(250);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Tax)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}