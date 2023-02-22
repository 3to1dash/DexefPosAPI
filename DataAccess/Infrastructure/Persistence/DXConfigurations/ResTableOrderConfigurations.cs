using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ResTableOrderConfiguration : IEntityTypeConfiguration<ResTableOrder>
{


    public void Configure(EntityTypeBuilder<ResTableOrder> builder)
    {
        builder.ToTable("ResTableOrder");

        builder.Property(e => e.OrderTaskId).HasColumnType("numeric(19, 15)");

        builder.Property(e => e.OrderType)
            .HasMaxLength(50)
            .IsFixedLength();
    }
}