using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InvoiceDepartmentConfiguration : IEntityTypeConfiguration<InvoiceDepartment>
{


    public void Configure(EntityTypeBuilder<InvoiceDepartment> builder)
    {
        builder.ToTable("InvoiceDepartment");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.DesignId).HasColumnName("DesignID");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Printer).HasMaxLength(50);
    }
}