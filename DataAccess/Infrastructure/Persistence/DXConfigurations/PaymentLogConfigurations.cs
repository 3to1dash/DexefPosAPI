using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PaymentLogConfiguration : IEntityTypeConfiguration<PaymentLog>
{
    public void Configure(EntityTypeBuilder<PaymentLog> builder)
    {
        builder.ToTable("PaymentLog");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.Credit)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Debit)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.TargetCredit)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TargetCurrency).HasMaxLength(50);

        builder.Property(e => e.TargetDealing).HasMaxLength(50);

        builder.Property(e => e.TargetDebit)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TargetNum).HasMaxLength(50);

        builder.Property(e => e.TargetTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TargetTaskID");

        builder.Property(e => e.TargetTransferRate)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
    }
}