using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ItemsRequestLogConfiguration : IEntityTypeConfiguration<ItemsRequestLog>
{
    public void Configure(EntityTypeBuilder<ItemsRequestLog> builder)
    {
        builder.ToTable("ItemsRequest_Log");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.DealingDt)
            .HasColumnType("datetime")
            .HasColumnName("DealingDT");

        builder.Property(e => e.DealingTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("DealingTaskID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Status).HasMaxLength(50);

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.TargetStoreId).HasColumnName("TargetStoreID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}