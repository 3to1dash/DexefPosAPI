using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FixedAssetRecalcConfiguration : IEntityTypeConfiguration<FixedAssetRecalc>
{
    public void Configure(EntityTypeBuilder<FixedAssetRecalc> builder)
    {
        builder.HasNoKey();

        builder.ToTable("FixedAsset_Recalc");

        builder.Property(e => e.AssetAccountId).HasColumnName("AssetAccountID");

        builder.Property(e => e.AssetId).HasColumnName("AssetID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.DepAccountId).HasColumnName("DepAccountID");

        builder.Property(e => e.DepValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.NewValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.OldValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ReCalcAccountId).HasColumnName("ReCalcAccountID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Value).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.WrittenBy).HasMaxLength(150);
    }
}