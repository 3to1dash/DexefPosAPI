using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InvoiceMustSaveConfiguration : IEntityTypeConfiguration<InvoiceMustSave>
{
    public void Configure(EntityTypeBuilder<InvoiceMustSave> builder)
    {
        builder.ToTable("Invoice_MustSave");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.Dattax).HasColumnName("DATTax");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.DueDt).HasColumnName("DueDT");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");
    }
}