using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyCustAgingConfiguration : IEntityTypeConfiguration<DailyCustAging>
{


    public void Configure(EntityTypeBuilder<DailyCustAging> builder)
    {
        builder.ToTable("DailyCustAging");

        builder.HasIndex(e => e.CustId, "IX_DailyCustAging_CustID_139B6");

        builder.HasIndex(e => e.CustId, "IX_DailyCustAging_CustID_86341");

        builder.HasIndex(e => e.CustId, "IX_DailyCustAging_CustID_89B0E");

        builder.HasIndex(e => new { e.CustId, e.AgingPaid, e.NeedMoney }, "IX_DailyCustAging_CustID_AgingPaid_NeedMoney_DB164");

        builder.HasIndex(e => new { e.CustId, e.IsTarget }, "IX_DailyCustAging_CustID_IsTarget_BF177");

        builder.HasIndex(e => new { e.CustId, e.NeedMoney }, "IX_DailyCustAging_CustID_NeedMoney_0501F");

        builder.HasIndex(e => new { e.CustId, e.NeedMoney }, "IX_DailyCustAging_CustID_NeedMoney_19563");

        builder.HasIndex(e => new { e.CustId, e.NeedMoney }, "IX_DailyCustAging_CustID_NeedMoney_BD030");

        builder.HasIndex(e => new { e.CustId, e.NeedMoney }, "IX_DailyCustAging_CustID_NeedMoney_F05B1");

        builder.HasIndex(e => new { e.CustId, e.OpenBalance }, "IX_DailyCustAging_CustID_OpenBalance_894F6");

        builder.HasIndex(e => new { e.CustId, e.TaskId, e.InstallmentId }, "IX_DailyCustAging_CustID_TaskID_InstallmentID_86CFE");

        builder.HasIndex(e => e.IsTarget, "IX_DailyCustAging_IsTarget_6FF52");

        builder.HasIndex(e => e.IsTarget, "IX_DailyCustAging_IsTarget_BC4D4");

        builder.HasIndex(e => e.IsTarget, "IX_DailyCustAging_IsTarget_F065F");

        builder.HasIndex(e => new { e.IsTarget, e.InstallmentId, e.TaskId }, "IX_DailyCustAging_IsTarget_InstallmentID_TaskID_C07A0");

        builder.HasIndex(e => new { e.IsTarget, e.RegNum, e.InstallmentId, e.TaskId }, "IX_DailyCustAging_IsTarget_RegNum_InstallmentID_TaskID_4BD72");

        builder.HasIndex(e => new { e.IsTarget, e.TaskId, e.Dealing }, "IX_DailyCustAging_IsTarget_TaskID_Dealing_3BD84");

        builder.HasIndex(e => new { e.IsTarget, e.TaskId, e.Dealing }, "IX_DailyCustAging_IsTarget_TaskID_Dealing_FEE40");

        builder.HasIndex(e => new { e.TaskId, e.AgingPaid }, "IX_DailyCustAging_TaskID_AgingPaid_2ABFC");

        builder.HasIndex(e => new { e.BranchId, e.IsTarget, e.OpenBalance, e.NeedMoney, e.Dealing, e.ExprDt, e.RepId, e.InstallmentId }, "NonClusteredIndex-20200213-140035");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AgingPaid)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CashDiscount)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CostId)
            .HasColumnName("CostID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Credit)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency).HasMaxLength(50);

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Debit)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.ExprDt)
            .HasColumnType("datetime")
            .HasColumnName("ExprDT");

        builder.Property(e => e.InstallmentId).HasColumnName("InstallmentID");

        builder.Property(e => e.InvoicePaid)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceRemain)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceSum)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceTotal)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsAdjust).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsTarget).HasDefaultValueSql("((0))");

        builder.Property(e => e.NeedMoney)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.OpenBalance)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RegNum).HasDefaultValueSql("((0))");

        builder.Property(e => e.RepId)
            .HasColumnName("RepID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TaxAmount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TaxId)
            .HasColumnName("TaxID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxPerc)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TermsId)
            .HasColumnName("TermsID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TermsPerc)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TermsState).HasDefaultValueSql("((0))");

        builder.Property(e => e.UseAging).HasDefaultValueSql("((1))");
    }
}