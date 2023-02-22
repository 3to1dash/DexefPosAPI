using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripAirportConfiguration : IEntityTypeConfiguration<TripAirport>
{


    public void Configure(EntityTypeBuilder<TripAirport> builder)
    {
        builder.HasKey(e => e.Code);

        builder.ToTable("Trip_Airports");

        builder.HasIndex(e => e.Id, "IX_Trip_Airports_id_9E3A4");

        builder.Property(e => e.Code)
            .HasMaxLength(4)
            .IsUnicode(false);

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.City).HasMaxLength(50);

        builder.Property(e => e.Country).HasMaxLength(50);

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.IsDomestic).HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}