using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EstimateShippingCompanyConfiguration : IEntityTypeConfiguration<EstimateShippingCompany>
{


    public void Configure(EntityTypeBuilder<EstimateShippingCompany> builder)
    {
        builder.ToTable("Estimate_ShippingCompany");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Address).HasMaxLength(50);

        builder.Property(e => e.Isactive).HasColumnName("ISActive");

        builder.Property(e => e.Mob).HasMaxLength(50);

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Num).HasColumnName("num");
    }
}