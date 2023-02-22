using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindColorConfiguration : IEntityTypeConfiguration<KindColor>
{


    public void Configure(EntityTypeBuilder<KindColor> builder)
    {
        builder.ToTable("kind_Colors");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Color).HasMaxLength(50);

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Num).HasMaxLength(50);
    }
}