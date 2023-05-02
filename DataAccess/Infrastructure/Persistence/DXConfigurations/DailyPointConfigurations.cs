using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyPointConfiguration : IEntityTypeConfiguration<DailyPoint>
{
    public void Configure(EntityTypeBuilder<DailyPoint> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dealing).HasMaxLength(150);

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.InPoints).HasDefaultValueSql("((0))");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.OutPoints).HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SumBill).HasColumnType("decimal(18, 5)");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}