using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyBatchNumberConfiguration : IEntityTypeConfiguration<DailyBatchNumber>
{
    public void Configure(EntityTypeBuilder<DailyBatchNumber> builder)
    {
        builder.ToTable("Daily_BatchNumber");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.ItemId)
            .HasColumnName("ItemID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.OperateId).HasColumnName("OperateID");

        builder.Property(e => e.QtyIn)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.QtyOut)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}