using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DiscountQtyConfiguration : IEntityTypeConfiguration<DiscountQty>
{
    public void Configure(EntityTypeBuilder<DiscountQty> builder)
    {
        builder.ToTable("DiscountQty");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dt1).HasColumnType("datetime");

        builder.Property(e => e.Dt2).HasColumnType("datetime");

        builder.Property(e => e.IsPerc).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsperSlice).HasColumnName("ISPerSlice");

        builder.Property(e => e.ItemCounts).HasDefaultValueSql("((0))");

        builder.Property(e => e.Name).HasMaxLength(150);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}