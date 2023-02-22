using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PaymentTermConfiguration : IEntityTypeConfiguration<PaymentTerm>
{


    public void Configure(EntityTypeBuilder<PaymentTerm> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Discount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DueType).HasMaxLength(50);

        builder.Property(e => e.MinPayment).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.PaymentType).HasMaxLength(50);

        builder.Property(e => e.Profit).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}