using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SalariesPayConfiguration : IEntityTypeConfiguration<SalariesPay>
{


    public void Configure(EntityTypeBuilder<SalariesPay> builder)
    {
        builder.ToTable("SalariesPay");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AccountID");

        builder.Property(e => e.Addition)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BankId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BankID");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.CalcId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("CalcID");

        builder.Property(e => e.Deduction)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Note).HasMaxLength(450);

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.PaymentMethod).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.PaytoAll).HasDefaultValueSql("((0))");

        builder.Property(e => e.PedgeId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("PedgeID");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(150);

        builder.Property(e => e.StorageId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StorageID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TreeId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("TreeID");

        builder.Property(e => e.WorkCounts).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.WorkIds)
            .HasMaxLength(2000)
            .HasColumnName("WorkIDs");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}