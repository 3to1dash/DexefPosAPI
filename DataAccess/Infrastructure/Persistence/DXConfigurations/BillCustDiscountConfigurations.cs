using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BillCustDiscountConfiguration : IEntityTypeConfiguration<BillCustDiscount>
{
    public void Configure(EntityTypeBuilder<BillCustDiscount> builder)
    {
        builder.ToTable("Bill_CustDiscount");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.CanEdit).HasDefaultValueSql("((0))");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discount")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountId)
            .HasColumnName("DiscountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Invalue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("invalue");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID")
            .HasDefaultValueSql("((0))");
    }
}