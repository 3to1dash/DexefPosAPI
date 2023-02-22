using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DefaultFilterPeriodConfiguration : IEntityTypeConfiguration<DefaultFilterPeriod>
{


    public void Configure(EntityTypeBuilder<DefaultFilterPeriod> builder)
    {
        builder.ToTable("DefaultFilterPeriod");

        builder.Property(e => e.Name).HasMaxLength(250);
    }
}