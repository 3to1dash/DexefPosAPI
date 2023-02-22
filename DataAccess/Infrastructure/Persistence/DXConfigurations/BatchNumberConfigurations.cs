using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BatchNumberConfiguration : IEntityTypeConfiguration<BatchNumber>
{


    public void Configure(EntityTypeBuilder<BatchNumber> builder)
    {
        builder.ToTable("Batch_number");

        builder.HasIndex(e => new { e.ItemId, e.Operate }, "NonClusteredIndex-20211105-131634");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Barcode).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Detail).HasMaxLength(50);

        builder.Property(e => e.ExprDt)
            .HasColumnType("datetime")
            .HasColumnName("ExprDT");

        builder.Property(e => e.InQty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsActive).HasDefaultValueSql("((1))");

        builder.Property(e => e.ItemId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ItemID");

        builder.Property(e => e.KindId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("KindID");

        builder.Property(e => e.ManufacturingDt)
            .HasColumnType("datetime")
            .HasColumnName("ManufacturingDT");

        builder.Property(e => e.Note).HasMaxLength(50);

        builder.Property(e => e.Operate).HasMaxLength(50);

        builder.Property(e => e.OutQty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Sn)
            .HasMaxLength(50)
            .HasColumnName("SN");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.Temp).HasColumnType("numeric(19, 5)");
    }
}