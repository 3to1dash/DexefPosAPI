using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RecieveConsignmentQtyConfiguration : IEntityTypeConfiguration<RecieveConsignmentQty>
{
    public void Configure(EntityTypeBuilder<RecieveConsignmentQty> builder)
    {
        builder.ToTable("RecieveConsignment_Qty");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Cost)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InCost)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InQty)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.KindId)
            .HasColumnName("KindID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OutCost)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OutQty)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.VendorId)
            .HasColumnName("VendorID")
            .HasDefaultValueSql("((0))");
    }
}