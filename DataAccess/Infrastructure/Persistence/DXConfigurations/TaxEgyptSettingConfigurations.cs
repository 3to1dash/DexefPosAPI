using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TaxEgyptSettingConfiguration : IEntityTypeConfiguration<TaxEgyptSetting>
{
    public void Configure(EntityTypeBuilder<TaxEgyptSetting> builder)
    {
        builder.ToTable("Tax_EgyptSetting");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.MaxCustValue).HasColumnType("numeric(18, 5)");
    }
}