using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooKindMapperConfiguration : IEntityTypeConfiguration<WooKindMapper>
{


    public void Configure(EntityTypeBuilder<WooKindMapper> builder)
    {
        builder.ToTable("WooKindMapper");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.RemoteState).HasMaxLength(50);
    }
}