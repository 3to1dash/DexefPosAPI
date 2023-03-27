using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InsurancesPercentConfiguration : IEntityTypeConfiguration<InsurancesPercent>
{
    public void Configure(EntityTypeBuilder<InsurancesPercent> builder)
    {
        builder.ToTable("InsurancesPercent");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.InsurancesId).HasColumnName("InsurancesID");

        builder.Property(e => e.Ratio).HasDefaultValueSql("((0))");
    }
}