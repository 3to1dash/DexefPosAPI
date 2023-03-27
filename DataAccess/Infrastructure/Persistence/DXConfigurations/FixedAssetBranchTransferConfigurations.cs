using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FixedAssetBranchTransferConfiguration : IEntityTypeConfiguration<FixedAssetBranchTransfer>
{
    public void Configure(EntityTypeBuilder<FixedAssetBranchTransfer> builder)
    {
        builder.ToTable("FixedAsset_BranchTransfer");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dafter).HasMaxLength(5);

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Dthijri)
            .HasMaxLength(19)
            .IsUnicode(false)
            .HasColumnName("DTHijri")
            .IsFixedLength();

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.NewAddress).HasMaxLength(100);

        builder.Property(e => e.NewAssetId).HasColumnName("NewAssetID");

        builder.Property(e => e.NewBranchId).HasColumnName("NewBranchID");

        builder.Property(e => e.NewCostId).HasColumnName("NewCostID");

        builder.Property(e => e.NewNeighbour1).HasMaxLength(50);

        builder.Property(e => e.NewNeighbour2).HasMaxLength(50);

        builder.Property(e => e.NewNeighbour3).HasMaxLength(50);

        builder.Property(e => e.NewPrice).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.NewQty).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.NewRackNum).HasMaxLength(50);

        builder.Property(e => e.NewRoom).HasMaxLength(50);

        builder.Property(e => e.NewStore).HasMaxLength(50);

        builder.Property(e => e.NewTotal).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.NewValue).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.OldAddress).HasMaxLength(100);

        builder.Property(e => e.OldAssetId).HasColumnName("OldAssetID");

        builder.Property(e => e.OldBranchId).HasColumnName("OldBranchID");

        builder.Property(e => e.OldCostId).HasColumnName("OldCostID");

        builder.Property(e => e.OldNeighbour1).HasMaxLength(50);

        builder.Property(e => e.OldNeighbour2).HasMaxLength(50);

        builder.Property(e => e.OldNeighbour3).HasMaxLength(50);

        builder.Property(e => e.OldPrice).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.OldQty).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.OldRackNum).HasMaxLength(50);

        builder.Property(e => e.OldRoom).HasMaxLength(50);

        builder.Property(e => e.OldStore).HasMaxLength(50);

        builder.Property(e => e.OldTotal).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.OldValue).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UpdatedBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}