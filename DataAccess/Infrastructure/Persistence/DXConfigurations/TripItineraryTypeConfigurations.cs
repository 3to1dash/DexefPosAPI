using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripItineraryTypeConfiguration : IEntityTypeConfiguration<TripItineraryType>
{
    public void Configure(EntityTypeBuilder<TripItineraryType> builder)
    {
        builder.ToTable("Trip_Itinerary_Type");

        builder.Property(e => e.Id).ValueGeneratedNever();

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .IsUnicode(false);
    }
}