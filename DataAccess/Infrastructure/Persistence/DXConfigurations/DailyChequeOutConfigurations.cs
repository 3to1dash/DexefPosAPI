using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyChequeOutConfiguration : IEntityTypeConfiguration<DailyChequeOut>
{
    public void Configure(EntityTypeBuilder<DailyChequeOut> builder)
    {
        builder.ToTable("Daily_ChequeOut");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BankId).HasColumnName("BankID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.ChequeId).HasColumnName("ChequeID");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Owner).HasMaxLength(450);

        builder.Property(e => e.ProcessId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("ProcessID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Status).HasMaxLength(50);

        builder.Property(e => e.TargetOwner).HasMaxLength(150);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}