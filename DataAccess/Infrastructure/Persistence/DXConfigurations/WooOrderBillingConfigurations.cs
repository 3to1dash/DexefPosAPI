using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooOrderBillingConfiguration : IEntityTypeConfiguration<WooOrderBilling>
{


    public void Configure(EntityTypeBuilder<WooOrderBilling> builder)
    {
        builder.ToTable("WooOrderBilling");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Address1).HasColumnName("address_1");

        builder.Property(e => e.Address2).HasColumnName("address_2");

        builder.Property(e => e.City).HasColumnName("city");

        builder.Property(e => e.Company).HasColumnName("company");

        builder.Property(e => e.Country).HasColumnName("country");

        builder.Property(e => e.Email).HasColumnName("email");

        builder.Property(e => e.FirstName).HasColumnName("first_name");

        builder.Property(e => e.LastName).HasColumnName("last_name");

        builder.Property(e => e.Phone).HasColumnName("phone");

        builder.Property(e => e.Postcode).HasColumnName("postcode");

        builder.Property(e => e.State).HasColumnName("state");
    }
}