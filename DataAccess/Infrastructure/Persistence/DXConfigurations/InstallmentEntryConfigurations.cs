using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InstallmentEntryConfiguration : IEntityTypeConfiguration<InstallmentEntry>
{


    public void Configure(EntityTypeBuilder<InstallmentEntry> builder)
    {
        builder.ToTable("Installment_Entry");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Alarm).HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Done).HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.EarnAccountId).HasColumnName("EarnAccountID");

        builder.Property(e => e.EarnPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Emplyee).HasMaxLength(150);

        builder.Property(e => e.InstallmentId).HasColumnName("InstallmentID");

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Paid)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PaidDealing).HasMaxLength(50);

        builder.Property(e => e.PaidDt).HasColumnType("datetime");

        builder.Property(e => e.PaidNum).HasMaxLength(50);

        builder.Property(e => e.PaidTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("PaidTaskID");

        builder.Property(e => e.PaidUser).HasMaxLength(50);

        builder.Property(e => e.RowTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("RowTaskID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UnEarnAccountId).HasColumnName("UnEarnAccountID");

        builder.Property(e => e.UsedProfit)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Value)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.HasOne(d => d.Installment)
            .WithMany(p => p.InstallmentEntries)
            .HasForeignKey(d => d.InstallmentId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Installment_Entry_Installment");
    }
}