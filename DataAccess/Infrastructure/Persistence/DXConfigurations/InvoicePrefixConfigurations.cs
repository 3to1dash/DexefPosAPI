using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InvoicePrefixConfiguration : IEntityTypeConfiguration<InvoicePrefix>
{
    public void Configure(EntityTypeBuilder<InvoicePrefix> builder)
    {
        builder.ToTable("Invoice_Prefix");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Prefix).HasMaxLength(20);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}