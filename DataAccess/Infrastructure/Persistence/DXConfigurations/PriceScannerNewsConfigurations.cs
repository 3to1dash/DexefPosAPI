using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PriceScannerNewsConfiguration : IEntityTypeConfiguration<PriceScannerNews>
{


    public void Configure(EntityTypeBuilder<PriceScannerNews> builder)
    {
        builder.ToTable("PriceScanner_News");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.News).HasMaxLength(250);
    }
}