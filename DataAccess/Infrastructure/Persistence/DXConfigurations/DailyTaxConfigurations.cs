using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyTaxConfiguration : IEntityTypeConfiguration<DailyTax>
{


    public void Configure(EntityTypeBuilder<DailyTax> builder)
    {
        builder.ToTable("DailyTax");

        builder.HasIndex(e => e.Dealing, "IX_DailyTax_Dealing_15C5A");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnName("AccountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Cpu).HasColumnName("CPU");

        builder.Property(e => e.Credit)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency).HasMaxLength(3);

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Debit)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.HijriDt)
            .HasColumnType("datetime")
            .HasColumnName("HijriDT");

        builder.Property(e => e.KindId)
            .HasColumnName("KindID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LocalCredit)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LocalDebit)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.NetTotal).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Note).HasMaxLength(500);

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ParentShip).HasMaxLength(150);

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Regnum).HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(150);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Tax)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TaxPerc)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TranCode)
            .HasMaxLength(3)
            .IsUnicode(false);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}