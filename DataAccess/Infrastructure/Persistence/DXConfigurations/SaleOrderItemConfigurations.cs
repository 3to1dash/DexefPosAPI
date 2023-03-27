using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SaleOrderItemConfiguration : IEntityTypeConfiguration<SaleOrderItem>
{
    public void Configure(EntityTypeBuilder<SaleOrderItem> builder)
    {
        builder.ToTable("SaleOrder_Items");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Cpu)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DayIndex)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.DtDue).HasColumnType("datetime");

        builder.Property(e => e.InProgress).HasDefaultValueSql("((0))");

        builder.Property(e => e.Isdone)
            .HasColumnName("ISDone")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.KindId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("KindID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OrderId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("OrderID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PeriodId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("PeriodID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Unite).HasMaxLength(50);
    }
}