using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FuelTypeConfiguration : IEntityTypeConfiguration<FuelType>
{


    public void Configure(EntityTypeBuilder<FuelType> builder)
    {
        builder.ToTable("FuelType");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Value).HasColumnType("numeric(18, 5)");
    }
}