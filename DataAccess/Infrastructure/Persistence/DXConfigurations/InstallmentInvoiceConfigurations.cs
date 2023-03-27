using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InstallmentInvoiceConfiguration : IEntityTypeConfiguration<InstallmentInvoice>
{
    public void Configure(EntityTypeBuilder<InstallmentInvoice> builder)
    {
        builder.ToTable("Installment_Invoice");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.EarnedAccountId).HasColumnName("EarnedAccountID");

        builder.Property(e => e.EndPaid).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Extra)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PrePaid).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.ProfitPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SliceId).HasColumnName("sliceID");

        builder.Property(e => e.StartDt)
            .HasColumnType("datetime")
            .HasColumnName("StartDT");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UnEarnedAccountId).HasColumnName("UnEarnedAccountID");
    }
}