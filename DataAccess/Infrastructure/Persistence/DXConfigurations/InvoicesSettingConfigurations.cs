using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InvoicesSettingConfiguration : IEntityTypeConfiguration<InvoicesSetting>
{


    public void Configure(EntityTypeBuilder<InvoicesSetting> builder)
    {
        builder.ToTable("Invoices_Settings");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

        builder.Property(e => e.TranCode)
            .HasMaxLength(5)
            .IsUnicode(false);
    }
}