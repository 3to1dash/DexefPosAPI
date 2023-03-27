using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustDailyBalanceConfiguration : IEntityTypeConfiguration<CustDailyBalance>
{
    public void Configure(EntityTypeBuilder<CustDailyBalance> builder)
    {
        builder.ToTable("Cust_DailyBalance");

        builder.HasIndex(e => e.ForAdjust, "IX_Cust_DailyBalance_ForAdjust_1B46E");

        builder.HasIndex(e => e.ForAdjust, "IX_Cust_DailyBalance_ForAdjust_2BB05");

        builder.HasIndex(e => e.ForAdjust, "IX_Cust_DailyBalance_ForAdjust_9EE57");

        builder.HasIndex(e => new {e.ForAdjust, e.BaseTaskId}, "IX_Cust_DailyBalance_ForAdjust_BaseTaskID_7C205");

        builder.HasIndex(e => new {e.ForAdjust, e.CustId, e.BaseTaskId},
            "IX_Cust_DailyBalance_ForAdjust_CustID_BaseTaskID_99A18");

        builder.HasIndex(e => new {e.ForAdjust, e.CustId}, "IX_Cust_DailyBalance_ForAdjust_CustID_D6700");

        builder.HasIndex(e => new {e.ForAdjust, e.IsTarget}, "IX_Cust_DailyBalance_ForAdjust_IsTarget_45AE3");

        builder.HasIndex(e => new {e.ForAdjust, e.IsTarget}, "IX_Cust_DailyBalance_ForAdjust_IsTarget_FDC80");

        builder.HasIndex(e => new {e.ForAdjust, e.IsTarget, e.TaskId},
            "IX_Cust_DailyBalance_ForAdjust_IsTarget_TaskID_B6B2B");

        builder.HasIndex(e => new {e.ForAdjust, e.IsTarget, e.TaskId},
            "IX_Cust_DailyBalance_ForAdjust_IsTarget_TaskID_F49A7");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BaseRegNum).HasDefaultValueSql("((0))");

        builder.Property(e => e.BaseTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("BaseTaskID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Credit)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.CustomerCurPaid)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Debit)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DocumentNum).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.ExprDt)
            .HasColumnType("datetime")
            .HasColumnName("ExprDT");

        builder.Property(e => e.ForAdjust).HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceCurPaid)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceDiscount)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceExtra)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoicePay)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceRemain)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceSum)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceTaxes).HasColumnType("money");

        builder.Property(e => e.InvoiceTotal)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsInstall).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsPaid).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsSolve).HasDefaultValueSql("((0))");

        builder.Property(e => e.NeedMoney)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OpenBalance)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SourceCurPaid)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TargetDealing)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TermsId).HasColumnName("TermsID");

        builder.Property(e => e.TermsPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TermsValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalPaid)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UserCashDiscount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UserDiscount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UserPayment)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}