using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TaxEgyptHomeConfiguration : IEntityTypeConfiguration<TaxEgyptHome>
{
    public void Configure(EntityTypeBuilder<TaxEgyptHome> builder)
    {
        builder.ToTable("Tax_EgyptHome");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Discretion).HasMaxLength(150);

        builder.Property(e => e.Name).HasMaxLength(50);
    }
}