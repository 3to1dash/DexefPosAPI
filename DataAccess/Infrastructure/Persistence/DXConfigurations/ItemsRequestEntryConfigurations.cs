using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ItemsRequestEntryConfiguration : IEntityTypeConfiguration<ItemsRequestEntry>
{
    public void Configure(EntityTypeBuilder<ItemsRequestEntry> builder)
    {
        builder.ToTable("ItemsRequest_Entry");

        builder.HasIndex(e => e.TaskId, "IX_ItemsRequest_Entry_TaskID_FD571");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CancelQty)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.InQty)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.MainTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("MainTaskID");

        builder.Property(e => e.Operate).HasMaxLength(50);

        builder.Property(e => e.OutQty)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.RemainQty).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.RequestQty)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Status).HasMaxLength(50);

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.TargetStoreId).HasColumnName("TargetStoreID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Unite).HasMaxLength(50);

        builder.Property(e => e.UniteQty).HasColumnType("numeric(18, 5)");
    }
}