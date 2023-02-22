using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TempProcessdatumConfiguration : IEntityTypeConfiguration<TempProcessdatum>
{


    public void Configure(EntityTypeBuilder<TempProcessdatum> builder)
    {
        builder.HasNoKey();

        builder.ToTable("temp_processdata");

        builder.HasIndex(e => new { e.Itemid, e.SellId, e.PurchaseId, e.OrgSellQty, e.SettledSellQty, e.RemainingQtyinPurId }, "ClusteredIndex-20200520-233822")
            .IsClustered();

        builder.HasIndex(e => e.SellId, "IX_temp_processdata_SellId_82B98");

        builder.Property(e => e.Itemid).HasColumnName("itemid");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.OrgSellQty).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.PurchaseCost)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PurchaseTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("PurchaseTaskID");

        builder.Property(e => e.RemainingQtyinPurId).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SettledSellQty).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
    }
}