using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripStatusConfiguration : IEntityTypeConfiguration<TripStatus>
{
    public void Configure(EntityTypeBuilder<TripStatus> builder)
    {
        builder.ToTable("Trip_Status");

        builder.Property(e => e.Id)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("id");

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .IsUnicode(false);
    }
}