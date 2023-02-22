using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FixedAssetScrapConfiguration : IEntityTypeConfiguration<FixedAssetScrap>
{


    public void Configure(EntityTypeBuilder<FixedAssetScrap> builder)
    {
        builder.ToTable("FixedAsset_Scrap");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AssetAccountId).HasColumnName("AssetAccountID");

        builder.Property(e => e.AssetId).HasColumnName("AssetID");

        builder.Property(e => e.AssetValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CalacValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.CalcAccountId).HasColumnName("CalcAccountID");

        builder.Property(e => e.Currency).HasMaxLength(50);

        builder.Property(e => e.DepAccountId).HasColumnName("DepAccountID");

        builder.Property(e => e.DepValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note)
            .HasColumnName("note")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Num).HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(150);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TotalAssetValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalCalacValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalDepValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalQty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
    }
}