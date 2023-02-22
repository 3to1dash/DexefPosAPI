using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripDirectionTypeConfiguration : IEntityTypeConfiguration<TripDirectionType>
{


    public void Configure(EntityTypeBuilder<TripDirectionType> builder)
    {
        builder.ToTable("Trip_Direction_Type");

        builder.Property(e => e.Id).ValueGeneratedNever();

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .IsUnicode(false);
    }
}