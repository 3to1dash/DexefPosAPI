using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DiscountCashConfiguration : IEntityTypeConfiguration<DiscountCash>
{
    public void Configure(EntityTypeBuilder<DiscountCash> builder)
    {
        builder.ToTable("DiscountCash");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Days).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Discount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Discount2)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountInBill).HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountWithin2).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsNetPrice).HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.PeriodIndex).HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(150);
    }
}