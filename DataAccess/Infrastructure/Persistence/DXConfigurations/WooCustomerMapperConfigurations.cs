using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooCustomerMapperConfiguration : IEntityTypeConfiguration<WooCustomerMapper>
{
    public void Configure(EntityTypeBuilder<WooCustomerMapper> builder)
    {
        builder.ToTable("WooCustomerMapper");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.RemoteState)
            .HasMaxLength(50)
            .IsFixedLength();
    }
}