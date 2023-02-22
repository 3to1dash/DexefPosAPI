using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ItemsRequestConfiguration : IEntityTypeConfiguration<ItemsRequest>
{


    public void Configure(EntityTypeBuilder<ItemsRequest> builder)
    {
        builder.ToTable("ItemsRequest");

        builder.HasIndex(e => e.Closed, "IX_ItemsRequest_Closed_F99D4");

        builder.HasIndex(e => new { e.ParentTaskId, e.Dealing }, "IX_ItemsRequest_ParentTaskID_Dealing_E7414");

        builder.HasIndex(e => new { e.TargetBranchId, e.Closed }, "IX_ItemsRequest_TargetBranchID_Closed_62846");

        builder.HasIndex(e => e.TaskId, "IX_ItemsRequest_TaskID_D8FF3");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CloseBy).HasMaxLength(50);

        builder.Property(e => e.CloseDt)
            .HasColumnType("datetime")
            .HasColumnName("CloseDT");

        builder.Property(e => e.CloseTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("CloseTaskID");

        builder.Property(e => e.Closed).HasDefaultValueSql("((0))");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.LastTrans)
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        builder.Property(e => e.MainTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("MainTaskID");

        builder.Property(e => e.ParentTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("ParentTaskID");

        builder.Property(e => e.PrevStatus).HasMaxLength(50);

        builder.Property(e => e.RepId)
            .HasColumnName("RepID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(250);

        builder.Property(e => e.Status).HasMaxLength(50);

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.TableId).HasColumnName("TableID");

        builder.Property(e => e.TargetBranchId).HasColumnName("TargetBranchID");

        builder.Property(e => e.TargetStoreId).HasColumnName("TargetStoreID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}