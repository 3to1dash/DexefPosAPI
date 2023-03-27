using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailycustConfiguration : IEntityTypeConfiguration<Dailycust>
{
    public void Configure(EntityTypeBuilder<Dailycust> builder)
    {
        builder.ToTable("Dailycust");

        builder.HasIndex(e => new {e.AccountId, e.BranchId, e.Deleted, e.Updated, e.Dt},
            "IX_dailycust_AccountID_BranchID_Deleted_Updated_dt_5C599");

        builder.HasIndex(e => new {e.AccountId, e.Deleted, e.Updated}, "IX_dailycust_AccountID_Deleted_Updated_E3C9A");

        builder.HasIndex(e => new {e.AccountId, e.Deleted, e.Updated}, "IX_dailycust_AccountID_Deleted_Updated_E6D89");

        builder.HasIndex(e => new {e.AccountId, e.Deleted, e.Updated, e.Dt},
            "IX_dailycust_AccountID_Deleted_Updated_dt_8474A");

        builder.HasIndex(e => new {e.Currency, e.Deleted, e.Updated}, "IX_dailycust_Currency_Deleted_Updated_1775C");

        builder.HasIndex(e => new {e.Currency, e.Deleted, e.Updated}, "IX_dailycust_Currency_Deleted_Updated_297F3");

        builder.HasIndex(e => new {e.Currency, e.Deleted, e.Updated}, "IX_dailycust_Currency_Deleted_Updated_C01D0");

        builder.HasIndex(e => e.Currency, "IX_dailycust_Currency_F98A4");

        builder.HasIndex(e => new {e.Deleted, e.Updated}, "IX_dailycust_Deleted_Updated_50FCA");

        builder.HasIndex(e => new {e.Deleted, e.Updated}, "IX_dailycust_Deleted_Updated_66E64");

        builder.HasIndex(e => new {e.Deleted, e.Updated, e.Dt}, "IX_dailycust_Deleted_Updated_dt_067C4");

        builder.HasIndex(e => e.TaskId, "IX_dailycust_TaskID_76E84");

        builder.HasIndex(e => e.Dealing, "IX_dailycust_dealing_29AF7");

        builder.HasIndex(e => e.Dt, "IX_dailycust_dt_AB53C");

        builder.HasIndex(e => e.Dt, "IX_dailycust_dt_D81E4");

        builder.HasIndex(e => e.Num, "IX_dailycust_num_90735");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.ActualRate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.AgingPaid)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.CashDiscount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CostId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CostID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Cpu)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CPU");

        builder.Property(e => e.Credit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("credit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Debit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("debit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Deleted).HasDefaultValueSql("((0))");

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DeletedCredit).HasColumnType("money");

        builder.Property(e => e.DeletedLocalCredit).HasColumnType("money");

        builder.Property(e => e.DeletedLocalDebit).HasColumnType("money");

        builder.Property(e => e.Deleteddebit).HasColumnType("money");

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.ExprDt)
            .HasColumnType("datetime")
            .HasColumnName("ExprDT");

        builder.Property(e => e.HasBill).HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceDiscount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceExtra)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoicePaid)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceRemain)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceSum)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceTotal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LocalCredit)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LocalDebit)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasColumnName("num");

        builder.Property(e => e.OpenBalance)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PeriodId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("PeriodID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.QtyDiscount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RemainAfterAging)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(450);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Tax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TaxId)
            .HasColumnName("TaxID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TermsId).HasColumnName("TermsID");

        builder.Property(e => e.TermsPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Updated).HasDefaultValueSql("((0))");

        builder.Property(e => e.Value)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}