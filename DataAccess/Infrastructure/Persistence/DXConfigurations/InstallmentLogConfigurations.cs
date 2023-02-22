using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InstallmentLogConfiguration : IEntityTypeConfiguration<InstallmentLog>
{


    public void Configure(EntityTypeBuilder<InstallmentLog> builder)
    {
        builder.ToTable("Installment_Log");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.EarnAccountId).HasColumnName("EarnAccountID");

        builder.Property(e => e.InstallmentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("InstallmentID");

        builder.Property(e => e.IsCredit).HasDefaultValueSql("((0))");

        builder.Property(e => e.Paid).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.PaidTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("PaidTaskID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaxAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TaxPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.UnEarnAccountId).HasColumnName("UnEarnAccountID");
    }
}