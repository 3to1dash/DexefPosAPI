using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustInstallmentSliceConfiguration : IEntityTypeConfiguration<CustInstallmentSlice>
{


    public void Configure(EntityTypeBuilder<CustInstallmentSlice> builder)
    {
        builder.ToTable("Cust_InstallmentSlice");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.EarnedAccountId).HasColumnName("EarnedAccountID");

        builder.Property(e => e.EndPaid).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.ExtraCost).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Name).HasMaxLength(150);

        builder.Property(e => e.PrePaid).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Profit).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.UnEarnedAccountId).HasColumnName("UnEarnedAccountID");
    }
}