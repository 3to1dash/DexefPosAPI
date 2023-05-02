using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CashLogConfiguration : IEntityTypeConfiguration<CashLog>
{
    public void Configure(EntityTypeBuilder<CashLog> builder)
    {
        builder.ToTable("Cash_Log");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.Amount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InstallmentId).HasColumnName("InstallmentID");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.ParentDealing).HasMaxLength(50);

        builder.Property(e => e.ParentDt)
            .HasColumnType("datetime")
            .HasColumnName("ParentDT");

        builder.Property(e => e.ParentNumber).HasMaxLength(50);

        builder.Property(e => e.ParentTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("ParentTaskID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");
    }
}