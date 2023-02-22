using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
{


    public void Configure(EntityTypeBuilder<Resource> builder)
    {
        builder.HasKey(e => e.UniqueId);

        builder.Property(e => e.UniqueId).HasColumnName("UniqueID");

        builder.Property(e => e.CustomField1).HasMaxLength(2000);

        builder.Property(e => e.Image).HasColumnType("image");

        builder.Property(e => e.ResourceId).HasColumnName("ResourceID");

        builder.Property(e => e.ResourceName).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}