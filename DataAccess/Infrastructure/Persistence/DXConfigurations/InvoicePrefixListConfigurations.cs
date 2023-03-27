using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InvoicePrefixListConfiguration : IEntityTypeConfiguration<InvoicePrefixList>
{
    public void Configure(EntityTypeBuilder<InvoicePrefixList> builder)
    {
        builder.ToTable("Invoice_prefixList");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.ParentId).HasColumnName("ParentID");
    }
}