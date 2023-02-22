using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InstallmentConfiguration : IEntityTypeConfiguration<Installment>
{


    public void Configure(EntityTypeBuilder<Installment> builder)
    {
        builder.ToTable("Installment");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BaseTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("BaseTaskID");

        builder.Property(e => e.BranchId)
            .HasColumnName("BranchID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Counts).HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency).HasMaxLength(50);

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.DtStart).HasColumnType("date");

        builder.Property(e => e.EarnAccountId).HasColumnName("EarnAccountID");

        builder.Property(e => e.EarnPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InorOut)
            .HasColumnName("INorOut")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InstallProfit)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LstMonth)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.Paid)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PaidValue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PayEvery)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PayMonthly).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.PrePaid)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Remain)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(50);

        builder.Property(e => e.StartDt).HasColumnType("datetime");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Total)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UnEarnAccountId).HasColumnName("UnEarnAccountID");
    }
}