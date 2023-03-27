using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EinvoiceMappingConfiguration : IEntityTypeConfiguration<EinvoiceMapping>
{
    public void Configure(EntityTypeBuilder<EinvoiceMapping> builder)
    {
        builder.ToTable("EInvoice_Mapping");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Status).HasMaxLength(50);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Uuid)
            .HasMaxLength(150)
            .HasColumnName("UUID");
    }
}