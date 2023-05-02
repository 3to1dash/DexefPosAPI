using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BarcodeScaleConfiguration : IEntityTypeConfiguration<BarcodeScale>
{
    public void Configure(EntityTypeBuilder<BarcodeScale> builder)
    {
        builder.ToTable("BarcodeScale");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}