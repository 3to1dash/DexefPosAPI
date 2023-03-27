using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InvoiceDepartmentEntryConfiguration : IEntityTypeConfiguration<InvoiceDepartmentEntry>
{
    public void Configure(EntityTypeBuilder<InvoiceDepartmentEntry> builder)
    {
        builder.ToTable("InvoiceDepartment_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");
    }
}