using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BatchNumberTransferTempConfiguration : IEntityTypeConfiguration<BatchNumberTransferTemp>
{


    public void Configure(EntityTypeBuilder<BatchNumberTransferTemp> builder)
    {
        builder.ToTable("Batch_number_TransferTemp");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.ExprDt)
            .HasColumnType("datetime")
            .HasColumnName("ExprDT");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.OperateId).HasColumnName("OperateID");

        builder.Property(e => e.Qty).HasColumnType("decimal(32, 12)");

        builder.Property(e => e.RowId).HasColumnName("RowID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.ToItemId).HasColumnName("ToItemID");

        builder.Property(e => e.ToOperateId).HasColumnName("ToOperateID");
    }
}