using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InsurancesItemConfiguration : IEntityTypeConfiguration<InsurancesItem>
{
    public void Configure(EntityTypeBuilder<InsurancesItem> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.InsurancesId).HasColumnName("InsurancesID");

        builder.Property(e => e.PercentId).HasColumnName("PercentID");
    }
}