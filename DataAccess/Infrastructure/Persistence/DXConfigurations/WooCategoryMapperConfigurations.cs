using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooCategoryMapperConfiguration : IEntityTypeConfiguration<WooCategoryMapper>
{
    public void Configure(EntityTypeBuilder<WooCategoryMapper> builder)
    {
        builder.ToTable("WooCategoryMapper");

        builder.Property(e => e.Id).HasColumnName("id");
    }
}