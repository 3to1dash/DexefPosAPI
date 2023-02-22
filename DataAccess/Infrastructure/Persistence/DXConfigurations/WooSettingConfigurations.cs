using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooSettingConfiguration : IEntityTypeConfiguration<WooSetting>
{


    public void Configure(EntityTypeBuilder<WooSetting> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.PropertyName).HasMaxLength(100);

        builder.Property(e => e.PropertyValue).HasMaxLength(100);
    }
}