using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EstimateTypeConfiguration : IEntityTypeConfiguration<EstimateType>
{


    public void Configure(EntityTypeBuilder<EstimateType> builder)
    {
        builder.ToTable("EstimateType");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.WrittenBy).HasMaxLength(150);
    }
}