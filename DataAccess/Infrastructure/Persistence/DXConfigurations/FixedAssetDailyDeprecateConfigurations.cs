using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FixedAssetDailyDeprecateConfiguration : IEntityTypeConfiguration<FixedAssetDailyDeprecate>
{


    public void Configure(EntityTypeBuilder<FixedAssetDailyDeprecate> builder)
    {
        builder.ToTable("FixedAsset_DailyDeprecate");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AssetId).HasColumnName("AssetID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.DepValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DeprecateCenterIn).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DeprecateCenterOut).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DepreciationRatio).HasColumnType("numeric(18, 2)");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.DtCalc).HasColumnType("datetime");

        builder.Property(e => e.DtLastCalc).HasColumnType("datetime");

        builder.Property(e => e.DtUse).HasColumnType("datetime");

        builder.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Notes).HasMaxLength(500);

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ScrapValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.StartValue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}