using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InvoiceInstallmentConfiguration : IEntityTypeConfiguration<InvoiceInstallment>
{


    public void Configure(EntityTypeBuilder<InvoiceInstallment> builder)
    {
        builder.ToTable("InvoiceInstallment");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.EarnedAccountId).HasColumnName("EarnedAccountID");

        builder.Property(e => e.EndPaid).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.EndPaymentDt)
            .HasColumnType("datetime")
            .HasColumnName("EndPaymentDT");

        builder.Property(e => e.FirstPaymentDt)
            .HasColumnType("datetime")
            .HasColumnName("FirstPaymentDT");

        builder.Property(e => e.InstallmentAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.InstallmentId).HasColumnName("InstallmentID");

        builder.Property(e => e.InvoiceAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.InvoiceRemain).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.NetTotal).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.PrePaid).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UnEarnedAccountId).HasColumnName("UnEarnedAccountID");
    }
}