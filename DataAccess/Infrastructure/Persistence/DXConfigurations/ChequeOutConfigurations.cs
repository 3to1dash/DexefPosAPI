using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ChequeOutConfiguration : IEntityTypeConfiguration<ChequeOut>
{


    public void Configure(EntityTypeBuilder<ChequeOut> builder)
    {
        builder.ToTable("cheque_Out");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnName("AccountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BankId).HasColumnName("BankID");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.ChequeId).HasColumnName("ChequeID");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Ctype)
            .HasMaxLength(50)
            .HasColumnName("CType");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dafter).HasMaxLength(20);

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note).HasMaxLength(550);

        builder.Property(e => e.ProcessId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("ProcessID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Total).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}