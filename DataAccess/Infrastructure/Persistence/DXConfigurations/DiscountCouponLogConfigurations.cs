using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DiscountCouponLogConfiguration : IEntityTypeConfiguration<DiscountCouponLog>
{


    public void Configure(EntityTypeBuilder<DiscountCouponLog> builder)
    {
        builder.HasKey(e => e.CouponId);

        builder.ToTable("DiscountCouponLog");

        builder.Property(e => e.CouponId)
            .ValueGeneratedNever()
            .HasColumnName("CouponID");

        builder.Property(e => e.EndDate).HasColumnType("datetime");

        builder.Property(e => e.MaxAmount).HasColumnType("money");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");

        builder.Property(e => e.Perc).HasColumnType("money");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StartDate)
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Used).HasDefaultValueSql("((0))");

        builder.Property(e => e.UsedDate).HasColumnType("datetime");

        builder.Property(e => e.UsedDiscount)
            .HasColumnType("decimal(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UsedInvoiceAmount)
            .HasColumnType("decimal(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UsedInvoiceNum).HasMaxLength(50);

        builder.Property(e => e.UsedInvoiceTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("UsedInvoiceTaskID");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}